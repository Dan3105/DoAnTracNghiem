﻿USE [DB_THI_TN]
GO

/****** Object:  StoredProcedure [dbo].[SP_Cham_Thi]    Script Date: 29/05/2023 9:26:02 SA ******/
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


