USE [DB_THI_TN]
GO
/****** Object:  StoredProcedure [dbo].[SP_Lay_DS_Lich_Thi_Da_Thi]    Script Date: 6/14/2023 3:20:23 PM ******/
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
	Join (select * from Giaovien where MAGV in (select distinct MAGV from #LocDSDaThi)) GV on gd.MAGV = GV.MAGV
	Join Lop on Lop.MALOP = gd.MALOP
end