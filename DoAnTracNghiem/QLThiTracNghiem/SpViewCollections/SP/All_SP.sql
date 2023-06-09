USE [DB_THI_TN]
GO
/****** Object:  StoredProcedure [dbo].[SP_Bao_Cao_DS_Dk_Thi]    Script Date: 6/17/2023 7:13:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Proc [dbo].[SP_Bao_Cao_DS_Dk_Thi]
@TuNgay Date,
@DenNgay Date
as
begin
	Set xact_abort on
	begin distributed transaction
	Declare @commandstr nvarchar(4000)

	if OBJECT_ID('tempdb..##LocalTable') is null
	begin
	Create Table ##LocalTable
	(
		[TENLOP] [nvarchar](40) NULL,
		[TENMH] [nvarchar](50) NULL,
		[TENGV] [nvarchar](100) NULL,
		[SOCAUTHI] [smallint] NULL,
		[NGAYTHI] [nvarchar](50) NULL,
		[DATHI] [bit] NULL,
		[GHICHU] [ntext] NULL,
	)
	end

	if OBJECT_ID('tempdb..##RemoteTable') is null
	begin
	Create Table ##RemoteTable
	(
		[TENLOP] [nvarchar](40) NULL,
		[TENMH] [nvarchar](50) NULL,
		[TENGV] [nvarchar](100) NULL,
		[SOCAUTHI] [smallint] NULL,
		[NGAYTHI] [nvarchar](50) NULL,
		[DATHI] [bit] NULL,
		[GHICHU] [ntext] NULL
	)
	end

	Truncate table ##LocalTable
	Truncate table ##RemoteTable
	set @commandstr =  'Insert into ##LocalTable Exec SP_DS_Loc_DK_Thi ''' + Format(@TuNgay, 'yyyy-MM-dd') + ''',' + '''' + 
	Format(@DenNgay, 'yyyy-MM-dd') + '''';
	
	IF  EXISTS (SELECT job_id FROM msdb.dbo.sysjobs_view WHERE name = N'Job_1')
        EXEC msdb.dbo.sp_delete_job @job_name=N'Job_1' 

	execute msdb.dbo.sp_add_job @job_name = N'Job_1', @start_step_id = 1
    EXECUTE msdb.dbo.sp_add_jobserver  @job_name = N'Job_1', @server_name =  @@SERVERNAME
    execute msdb.dbo.sp_add_jobstep  @job_name =  N'Job_1' , @step_id = 1, @step_name = 'DS_DK', 
					@command =  @commandstr ,   @server = @@SERVERNAME, @database_name = 'DB_THI_TN'
	execute msdb.dbo.sp_start_job  @job_name =  N'Job_1'

	INSERT INTO ##RemoteTable
	EXEC LINK1.DB_THI_TN.dbo.SP_DS_Loc_DK_Thi @TuNgay, @DenNgay
	commit transaction;
	
	Declare  @jobStatus int;
	While 1=1
	begin
	SELECT TOP 1 @jobStatus = run_status 
		FROM msdb.dbo.sysjobhistory 
		WHERE job_id = (SELECT job_id FROM msdb.dbo.sysjobs WHERE step_name='DS_DK' and name = 'Job_1') 
    --ORDER BY run_date DESC, run_time DESC;
    IF @jobStatus IN (1, 0, 3) -- job completed (succeeded, failed, or canceled)
        BREAK;
    ELSE -- job still running
        WAITFOR DELAY '00:00:02'; -- wait for 2 seconds before checking again
	end

	Select TENLOP, TENMH, TENGV, SOCAUTHI, NGAYTHI, DATHI, GHICHU from ##LocalTable

	Select TENLOP, TENMH, TENGV, SOCAUTHI, NGAYTHI, DATHI, GHICHU from ##RemoteTable

	-- Job nay sau khi chay se luu lai owner nen phai xoa de user sau chay duoc
	IF  EXISTS (SELECT job_id FROM msdb.dbo.sysjobs_view WHERE name = N'Job_1')
        EXEC msdb.dbo.sp_delete_job @job_name=N'Job_1' 
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Cham_Thi]    Script Date: 6/17/2023 7:13:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Proc [dbo].[SP_Cham_Thi] 
@MaSV nchar(8),
@MaMH nchar(5),
@Diem float,
@LanThi smallint,
@NgayThi DateTime,
@BaiThi TYPE_DETHI readonly
as
begin
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
begin transaction;

begin try
	declare @combineKey varbinary(16) = HashBytes('MD5', CONCAT(@MaSV, @MaMH, @LanThi))
	-- cập nhật bảng điểm của user
	insert into BangDiem values(@MaSV, @MaMH, @LanThi, @NgayThi, @Diem, @combineKey, DEFAULT);

	-- cập nhật các câu hỏi chi tiết của sinh viên vào ChiTiet_BaiThi
	Insert into ChiTiet_BaiThi(UKDK, CAUHOI, STT, LUACHON)
	Select @combineKey, CAUHOI, STT, LUACHON 
	from @BaiThi
	
	commit transaction;
end try
begin catch
	if @@TRANCOUNT > 0
		rollback transaction;
	 DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
	 raiserror(@ErrorMessage, 16,2);
end catch
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Create_User_Login]    Script Date: 6/17/2023 7:13:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_Create_User_Login]
@loginname nvarchar(10), @password nvarchar(50),
@role nvarchar(10), @magv nvarchar(10)
as
begin
	declare @res int
	exec @res = sp_addlogin @loginname, @password, 'DB_THI_TN'
	if(@res = 1)
	begin 
		raiserror('Login name bị trùng', 16, 1)
		return
	end

	exec @res = sp_grantdbaccess @loginname, @magv
	if(@res = 1)
	begin
		exec sp_droplogin @loginname
		raiserror('Mã giảng viên đã tồn tại',16, 2)
		return
	end


	begin try
		exec sp_addrolemember @role, @magv
	end try
	begin catch
		exec sp_droplogin @loginname
		raiserror('Sai tên role', 16,2)
		return
	end catch

	if(@role = 'Truong' OR @role = 'CoSo')
	begin
		exec sp_addsrvrolemember @loginname, 'securityadmin'
		Declare @commandstr nvarchar(max)
		set @commandstr = 'USE [msdb] CREATE USER [' + @magv + '] FOR LOGIN [' + @loginname + ']'
		exec (@commandstr)

		set @commandstr = 'USE [msdb] ALTER ROLE [db_owner] ADD MEMBER [' + @magv + ']'
		exec (@commandstr)

		set @commandstr = 'USE [msdb] ALTER ROLE [SQLAgentUserRole] ADD MEMBER [' + @magv + ']'
		exec (@commandstr)

		set @commandstr = 'USE [msdb] ALTER ROLE [SQLAgentReaderRole] ADD MEMBER [' + @magv + ']'
		exec (@commandstr)

		set @commandstr = 'USE [msdb] ALTER ROLE [SQLAgentOperatorRole] ADD MEMBER [' + @magv + ']'
		exec (@commandstr)
	end
end
GO
/****** Object:  StoredProcedure [dbo].[SP_CT_Bai_Thi]    Script Date: 6/17/2023 7:13:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CT_Bai_Thi] (
	@MASV nchar(8),
	@MaMH nchar(5),
	@Lanthi int)
AS
BEGIN
	
	declare @IDBAITHI varbinary(16) = HashBytes('MD5', CONCAT(@MaSV, @MaMH, @Lanthi))

	SELECT 
		ct.STT as STT,
		ct.CAUHOI as CauSo,
		bd.NOIDUNG as NoiDung,
		'A.' + cast(bd.A as nvarchar(max)) + '\n' +
		'B.' + cast(bd.B as nvarchar(max)) + '\n' +
		'C.' + cast(bd.C as nvarchar(max)) + '\n' +
		'D.' + cast(bd.D as nvarchar(max))
		as CacChonLua,
		bd.DAP_AN as DapAn,
		ct.LUACHON as DaChon
	FROM 
		ChiTiet_BaiThi ct 
		INNER JOIN Bode bd ON ct.CAUHOI = bd.CAUHOI
	WHERE UKDK = @IDBAITHI
	ORDER BY ct.STT
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Dang_Nhap_Cho_SV]    Script Date: 6/17/2023 7:13:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_Dang_Nhap_Cho_SV] 
@Username nchar(8),
@Password nvarchar(50)
as
begin

	Select MASV, 
	MALOP,
	HOTEN = HO + ' ' + TEN, 
	TenNhom = (select name from sys.sysusers where uid IN (
	select groupuid from sys.sysmembers where memberuid IN 
	(select uid from sys.sysusers where sid = SUSER_SID('SV'))))
	from Sinhvien as dbtt 
	where dbtt.MASV = @Username and dbtt.PASSWORD = @Password
end
GO
/****** Object:  StoredProcedure [dbo].[SP_DS_Co_The_Thi]    Script Date: 6/17/2023 7:13:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Proc [dbo].[SP_DS_Co_The_Thi]
@MaLop nchar(15)
AS
BEGIN
    DECLARE @datenow DateTime = GETDATE();

    SELECT gd.MAMH, mh.TenMH AS TENMH, gd.TRINHDO, gd.NGAYTHI, gd.LAN, gd.SOCAUTHI, gd.THOIGIAN
    FROM Giaovien_Dangky gd
    JOIN Monhoc mh ON mh.MAMH = gd.MAMH
    WHERE @MaLop = gd.MALOP AND @datenow < gd.NGAYTHI
    ORDER BY gd.NGAYTHI;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_DS_Loc_DK_Thi]    Script Date: 6/17/2023 7:13:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Proc [dbo].[SP_DS_Loc_DK_Thi]
@tuNgay Date,
@denNgay Date
as
begin

Select * into #LocDate from Giaovien_Dangky where NGAYTHI between @tuNgay and @denNgay

Select TENLOP, 
TENMH, 
TENGV = gv.Ho + ' ' + gv.Ten,
SOCAUTHI,
Format(NGAYTHI, 'dd-MM-yyyy hh:mm:ss') NGAYTHI,
DATHI = (select case when exists(
	select BangDiem.MaSV from Sinhvien 
	Join BangDiem 
	on MALOP = gd.MALOP 
	and MAMH = gd.MAMH
	and gd.LAN =BangDiem.LAN) then 1 else 0 end),
CONCAT(N'Lần Thi: ', Lan) + N' Trình độ: ' + TRINHDO as GHICHU
from #LocDate gd 
Join Monhoc on gd.MAMH = Monhoc.MAMH
Join Giaovien gv on gd.MAGV = gv.MAGV
Join Lop on Lop.MALOP = gd.MALOP
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Get_User_Info]    Script Date: 6/17/2023 7:13:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[SP_Get_User_Info] @Loginname nvarchar(50)
AS
Declare @Username nvarchar(50)
Select @Username=Name from sys.sysusers where sid = SUSER_SID(@Loginname)
Begin
Select MaNV = @Username,
		HoTen = (Select HO + ' ' + TEN from Giaovien where MAGV = @Username),
		TenNhom = Name from sys.sysusers 
where uid = (select GroupUID 
from sys.sysmembers 
where memberuid = (select uid from sys.sysusers where name = @Username))
end

GO
/****** Object:  StoredProcedure [dbo].[SP_Kiem_Tra_CauHoi]    Script Date: 6/17/2023 7:13:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_Kiem_Tra_CauHoi](
	@MACAUHOI int)
AS
BEGIN
	DECLARE @cnt int
	SELECT @cnt = COUNT(CAUHOI) FROM ChiTiet_BaiThi WHERE CAUHOI = @MACAUHOI

	if(@cnt > 0) 
	begin
		print '1'
		return 1 -- Cau hoi da co sinh vien thi
	end

	SELECT @cnt = COUNT(CAUHOI) FROM LINK1.DB_THI_TN.dbo.ChiTiet_BaiThi WHERE CAUHOI = @MACAUHOI
	if(@cnt > 0) 
	begin
		print '1'
		return 1 -- Cau hoi da co sinh vien thi
	end

	print '0'
	return 0
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Kiem_Tra_DaThi]    Script Date: 6/17/2023 7:13:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[SP_Kiem_Tra_DaThi]
@MaMH nvarchar(10),
@MaLop nvarchar(10),
@LanThi int
as
begin
 if( exists(
	select BangDiem.MaSV from Sinhvien 
	Join BangDiem 
	on MALOP = @MaLop
	and MAMH = @MaMH
	and @LanThi =BangDiem.LAN)) 
	
	return 1; 
else 
	return 0;
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Kiem_Tra_GiaoVien]    Script Date: 6/17/2023 7:13:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_Kiem_Tra_GiaoVien]
@MaGV nchar(8)
as
begin
if(exists(Select MAGV from Giaovien where MAGV = @MaGV))
return 1;
else
return 0;
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Kiem_Tra_Khoa]    Script Date: 6/17/2023 7:13:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_Kiem_Tra_Khoa]
@MaKhoa nvarchar(15)
as
begin
if exists( Select MAKH from Khoa where KHOA.MAKH = @MaKhoa)
return 1;
else 
if exists(Select MAKH from LINK0.DB_THI_TN.DBO.KHOA as dbtt where dbtt.MAKH = @MaKhoa)
return 1;
else
return 0;
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Kiem_Tra_Lop]    Script Date: 6/17/2023 7:13:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_Kiem_Tra_Lop]
@MaLop nvarchar(15)
as
begin
if exists( Select MALOP from Lop where Lop.MALOP = @MaLop)
return 1;
else 
if exists(Select MALOP from LINK2.DB_THI_TN.DBO.Lop as dbtt where dbtt.MALOP = @MaLop)
return 1;
else
return 0;
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Kiem_Tra_MonHoc]    Script Date: 6/17/2023 7:13:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_Kiem_Tra_MonHoc]
@MaMH nvarchar(15)
as
begin
if(exists(Select MAMH from Monhoc where MAMH = @MaMH))
return 1;
else
return 0;
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Kiem_Tra_SinhVien]    Script Date: 6/17/2023 7:13:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[SP_Kiem_Tra_SinhVien]
@MaSV nvarchar(10)
as
begin
if exists(select MASV from Sinhvien where @MaSV = MASV) 
	return 1;
else if exists( Select MASV from LINK2.DB_THI_TN.DBO.Sinhvien sv where @MaSV = sv.MASV)
	return 1;
else 
	return 0;
end
GO
/****** Object:  StoredProcedure [dbo].[SP_KT_DKThi]    Script Date: 6/17/2023 7:13:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[SP_KT_DKThi]
@trinhdo nvarchar(1),
@socauthi int,
@monhoc as nchar(5)
as
begin
declare @tongCauTrinhDo int
declare @trinhdo2 nvarchar(1)

if(@trinhdo = 'A') 
set @trinhdo2 = 'B'
else if(@trinhdo = 'B') 
set @trinhdo2 = 'C'

-- 0: đủ
-- # 0: số câu còn thiếu
-- Lọc câu hỏi theo môn học 

Select CAUHOI, TRINHDO  into #temp from Bode where MAMH = @monhoc

select @tongCauTrinhDo = count(CAUHOI)  from #temp where @trinhdo = TRINHDO
if(@tongCauTrinhDo >= @socauthi)
	return 0;
else
	begin
	if(@tongCauTrinhDo >= @socauthi * 0.7)
		begin
		declare @tongCauTrinhDoDuoi int
		select @tongCauTrinhDoDuoi = count(CAUHOI) from #temp where @trinhdo2 = TRINHDO
			if(@tongCauTrinhDo + @tongCauTrinhDoDuoi >= @socauthi)
				return 0;
		else
			--raiserror('Số câu ở trình độ thấp hơn không đủ để bù thêm cho câu ở trình độ hiện tại là %d. Cụ thể số câu ở trình độ hiện tại: %d
			 --số câu trình độ dưới 1 bậc: %d
			--Tổng số câu thi: %d', 16,2,@tongCauTrinhDoDuoi, @tongCauTrinhDo, @soCauThi);
			return @soCauThi - @tongCauTrinhDo - @tongCauTrinhDoDuoi ;
		end
	else
		declare @socauthieu int = @socauthi - @tongCauTrinhDo
		--raiserror('Thiếu %d số câu. Cụ thể số câu trình độ hiện tại: %d Số câu thi: %d', 16,2, @socauthieu, @tongCauTrinhDo, @socauthi);
		return @socauthieu;
	end
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Lay_BangDiem]    Script Date: 6/17/2023 7:13:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Lay_BangDiem] (
	@MALOP NCHAR(15)
	, @MAMH NCHAR(15)
	, @LAN SMALLINT
)
AS 
SELECT DSSV.MASV, HO, TEN, DIEM, dbo.FN_Chuyen_Diem_Thanh_Chu(DIEM) AS DIEMCHU
FROM (SELECT MASV, HO, TEN FROM SINHVIEN WHERE MALOP = @MALOP) AS DSSV
JOIN (SELECT MASV, DIEM FROM BANGDIEM WHERE MAMH = @MAMH AND LAN = @LAN) AS DSDIEM
on DSSV.MASV = DSDIEM.MASV
GO
/****** Object:  StoredProcedure [dbo].[SP_Lay_Cau_Thi]    Script Date: 6/17/2023 7:13:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[SP_Lay_Cau_Thi]
@MaMH nvarchar(5), 
@SoCauThi int,
@TrinhDo nvarchar(1)
as
begin
--Tạo 1 table CauHoi
Create table #BangCauHoiThi(
	CAUHOI int,
	TRINHDO nchar(1),
	NOIDUNG ntext,
	A ntext,
	B ntext,
	C ntext,
	D ntext,
	DAP_AN nchar(1),
	MAGV nchar(8)
)

--Set trình độ
declare @TrinhDoDuoi nvarchar(1) = 'C'
if(@TrinhDo = 'A') 
	set @TrinhDoDuoi = 'B'
else if(@TrinhDo = 'B') 
	set @TrinhDoDuoi = 'C'

--Tạo bảng tạm lấy các câu hỏi theo môn học và trình độ
Select CAUHOI, TRINHDO, NOIDUNG, A,B,C,D, DAP_AN, MAGV into #BangLocBoDe from Bode
where MAMH = @MaMH and (TRINHDO = @TrinhDo or TRINHDO = @TrinhDoDuoi)

declare @TongTrinhDoHienTai int = 0

--Lấy các câu theo trình độ hiện tại
Insert  into #BangCauHoiThi 
Select Top(@SoCauThi) CAUHOI, TRINHDO, NOIDUNG, A,B,C,D, DAP_AN,MAGV from #BangLocBoDe  
where TRINHDO = @TrinhDo 
	and MAGV in (Select MAGV from Giaovien where MAKH in (Select MAKH from Khoa)) -- ưu tiên câu hỏi theo cơ sở
order by NEWID() 

Select @TongTrinhDoHienTai = Count(*) from #BangCauHoiThi

-- Case 0: Tổng câu trình độ đã đủ
if(@TongTrinhDoHienTai >= @SoCauThi)
begin
	Select * from #BangCauHoiThi 
end
else
begin
	-- Kiểm tra tổng số câu ở trình độ A có trên 70% hay không ?
	Select * into #BangTrinhDo from #BangLocBoDe where TRINHDO = @TrinhDo
	if(@@ROWCOUNT >= 0.7 * @SoCauThi) 
		begin
			-- Case : Tổng câu trình độ bị thiếu tiến hành lấy ở cơ sở khác với cùng trình độ
			Insert Into #BangCauHoiThi (CAUHOI, TRINHDO, NOIDUNG, A, B, C, D, DAP_AN,MAGV)
			SELECT TOP (@SoCauThi - @TongTrinhDoHienTai) CAUHOI, TRINHDO, NOIDUNG, A, B, C, D,DAP_AN, MAGV
			FROM #BangTrinhDo WHERE MAGV IN (
					SELECT MAGV FROM Giaovien WHERE MAKH NOT IN (SELECT MAKH FROM Khoa))
			ORDER BY NEWID()
			-- Cập nhật lại số câu có trong BangCauHoi
			Select @TongTrinhDoHienTai = Count(*) from #BangCauHoiThi

			--Kiểm tra số câu đã đủ hay chưa
			if(@TongTrinhDoHienTai >= @SoCauThi)
			begin
				Select * from #BangCauHoiThi 
			end
			else
			begin
				--Lấy các câu ở trình độ dưới
				Select * into #BangTrinhDoDuoi from #BangLocBoDe where TRINHDO = @TrinhDoDuoi
				if(@@ROWCOUNT + @TongTrinhDoHienTai >= @SoCauThi)
				begin
					--Các câu trình độ dưới ưu tiên theo cơ sở
					Insert Into #BangCauHoiThi (CAUHOI, TRINHDO, NOIDUNG, A, B, C, D,DAP_AN, MAGV)
						SELECT TOP (@SoCauThi - @TongTrinhDoHienTai) CAUHOI, TRINHDO, NOIDUNG, A, B, C, D, DAP_AN,MAGV
					FROM #BangTrinhDoDuoi WHERE MAGV IN (
						SELECT MAGV FROM Giaovien WHERE MAKH IN (SELECT MAKH FROM Khoa))
					ORDER BY NEWID()

					Select @TongTrinhDoHienTai = Count(*) from #BangCauHoiThi

					--Tiếp tục lấy thêm các câu ở trình độ dưới khi số câu lấy ở phía trên là chưa đủ
					if(@TongTrinhDoHienTai < @SoCauThi)
						begin
							Insert Into #BangCauHoiThi (CAUHOI, TRINHDO, NOIDUNG, A, B, C, D, DAP_AN, MAGV)
							SELECT TOP (@SoCauThi - @TongTrinhDoHienTai) CAUHOI, TRINHDO, NOIDUNG, A, B, C, D,DAP_AN, MAGV
							FROM #BangTrinhDoDuoi WHERE MAGV IN (
							SELECT MAGV FROM Giaovien WHERE MAKH IN (SELECT MAKH FROM Khoa))
						ORDER BY NEWID()
					end

					--Trả bảng câu hỏi về
					Select * from #BangCauHoiThi
				end
				else
					raiserror('Không đủ số câu trong bộ đề', 16,1)
			end
		end
	else
		raiserror('Không đủ số câu trong bộ đề', 16, 2)
end
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Lay_DS_Bai_Thi]    Script Date: 6/17/2023 7:13:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_Lay_DS_Bai_Thi]
@username nvarchar(8) --masv
AS
BEGIN

	SELECT 
		bd.MAMH,
		mh.TENMH,
		bd.LAN,
		bd.NGAYTHI,
		bd.DIEM,
		bd.MASV
	FROM 
		(SELECT 
			MAMH,
			LAN,
			NGAYTHI,
			DIEM,
			MASV
		FROM BangDiem WHERE MASV = @username) bd
		INNER JOIN Monhoc mh ON bd.MAMH = mh.MAMH 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Lay_DS_CauHoi]    Script Date: 6/17/2023 7:13:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_Lay_DS_CauHoi](
	@magv nchar(8), @mamh nchar(5))
AS
BEGIN
	SELECT 
		bd.CAUHOI as IDCAUHOI
		, bd.TRINHDO
		, bd.NOIDUNG
		, bd.A
		, bd.B
		, bd.C
		, bd.D
		, bd.DAP_AN
	FROM Bode bd
	WHERE bd.MAGV = @magv and bd.MAMH = @mamh
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Lay_DS_Lich_Thi_Da_Thi]    Script Date: 6/17/2023 7:13:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Lay_DS_Lich_Thi_Da_Thi] AS
begin
	SET NOCOUNT ON;  
    IF 1=0 BEGIN  
        SET FMTONLY OFF  
    END  

	Select * into #LocDSDaThi 
	from Giaovien_Dangky gd 
	where exists(
		select BangDiem.MaSV from Sinhvien 
		Join BangDiem 
		on MALOP = gd.MALOP 
		and MAMH = gd.MAMH
		and gd.LAN = BangDiem.LAN)

	Declare @cosohientai nvarchar(10)
	Select @cosohientai = TenCS from CoSo 
	Select Lop.MALOP, TENLOP, 
	MH.MAMH, TENMH, 
	Format(NGAYTHI, 'dd-MM-yyyy hh:mm:ss') NGAYTHI,
	LAN
	from #LocDSDaThi gd
	Join MonHoc MH on gd.MAMH = MH.MAMH
	Join Lop on Lop.MALOP = gd.MALOP
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Sua_CauHoi]    Script Date: 6/17/2023 7:13:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_Sua_CauHoi](
	@IDCauHoi int, @trinhdo nchar(1), @noidung ntext, 
	@a ntext, @b ntext, @c ntext, @d ntext, @dapan nchar(1))
AS
BEGIN
	UPDATE Bode
	SET 
		TRINHDO = @trinhdo
		, NOIDUNG = @noidung
		, A = @a, B = @b, C = @c, D = @d
		, DAP_AN = @dapan
	WHERE 
		CAUHOI = @IDCauHoi
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Them_CauHoi]    Script Date: 6/17/2023 7:13:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_Them_CauHoi](
	@mamh nchar(5), @trinhdo nchar(1), @noidung ntext, 
	@a ntext, @b ntext, @c ntext, @d ntext, @dapan nchar(1),
	@magv nchar(8))
AS
BEGIN
	INSERT INTO Bode(MAMH, TRINHDO, NOIDUNG, A, B, C, D, DAP_AN, MAGV)
	VALUES (@mamh, @trinhdo, @noidung, @a, @b, @c, @d, @dapan, @magv)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Tim_MACS]    Script Date: 6/17/2023 7:13:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[SP_Tim_MACS]
as
begin
	Select MACS from CoSo
end
GO
