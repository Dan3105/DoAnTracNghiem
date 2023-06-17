USE [DB_THI_TN]
GO
/****** Object:  UserDefinedFunction [dbo].[FN_Chuyen_Diem_Thanh_Chu]    Script Date: 6/6/2023 4:19:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[FN_Chuyen_Diem_Thanh_Chu](
	@DIEM FLOAT)
RETURNS NVARCHAR(16)
AS
BEGIN
	DECLARE @DIEM_STR NVARCHAR(3)
	SET @DIEM_STR = LTRIM(STR(@DIEM, 3, 1))
	IF(LEN(@DIEM_STR) = 2) RETURN N'Mười'
	DECLARE @DIEM_CHU NVARCHAR(14)
	SELECT @DIEM_CHU = DBO.FN_Chuyen_So_Thanh_Chu(SUBSTRING(@DIEM_STR, 1, 1))
	IF(SUBSTRING(@DIEM_STR, 3, 1) = '0') RETURN @DIEM_CHU
	SET @DIEM_CHU = @DIEM_CHU + N' Chấm '
	return @DIEM_CHU + DBO.FN_Chuyen_So_Thanh_Chu(SUBSTRING(@DIEM_STR, 3, 1))
END

