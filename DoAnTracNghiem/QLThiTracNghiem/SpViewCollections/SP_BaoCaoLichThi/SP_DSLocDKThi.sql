USE [DB_THI_TN]
GO

/****** Object:  StoredProcedure [dbo].[SP_DS_Loc_DK_Thi]    Script Date: 11/06/2023 9:40:08 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE Proc [dbo].[SP_DS_Loc_DK_Thi]
@tuNgay Date,
@denNgay Date
as
begin
	
Declare @cosohientai nvarchar(10)
Select @cosohientai = TENCS from CoSo 

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
CONCAT(N'Lần Thi: ', Lan) + N' Trình độ:' + TRINHDO as GHICHU,
TENCS = @cosohientai
from #LocDate gd 
Join Monhoc on gd.MAMH = Monhoc.MAMH
Join Giaovien gv on gd.MAGV = gv.MAGV
Join Lop on Lop.MALOP = gd.MALOP
end
GO


