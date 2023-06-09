USE [DB_THI_TN]
GO
/****** Object:  UserDefinedFunction [dbo].[FN_Chuyen_So_Thanh_Chu]    Script Date: 6/6/2023 4:19:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[FN_Chuyen_So_Thanh_Chu](
	@SO varchar(1))
RETURNS nvarchar(5)
AS
BEGIN
	RETURN (CASE
		WHEN @SO = '1' THEN N'Một'
		WHEN @SO = '2' THEN N'Hai'
		WHEN @SO = '3' THEN N'Ba'
		WHEN @SO = '4' THEN N'Bốn'
		WHEN @SO = '5' THEN N'Năm'
		WHEN @SO = '6' THEN N'Sáu'
		WHEN @SO = '7' THEN N'Bảy'
		WHEN @SO = '8' THEN N'Tám'
		WHEN @SO = '9' THEN N'Chín'
		ELSE N'Không'
	END)
END
