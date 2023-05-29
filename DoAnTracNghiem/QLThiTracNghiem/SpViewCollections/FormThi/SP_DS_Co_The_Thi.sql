USE [DB_THI_TN]
GO

/****** Object:  StoredProcedure [dbo].[SP_DS_Co_The_Thi]    Script Date: 29/05/2023 9:27:32 SA ******/
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


