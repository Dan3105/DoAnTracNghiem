﻿USE [DB_THI_TN]
GO

/****** Object:  StoredProcedure [dbo].[SP_Lay_Cau_Thi]    Script Date: 29/05/2023 9:27:52 SA ******/
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


