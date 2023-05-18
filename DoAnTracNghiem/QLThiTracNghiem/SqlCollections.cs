using DevExpress.CodeParser;
using DevExpress.CodeParser.Diagnostics;
using DevExpress.XtraDiagram.Bars;
using QLThiTracNghiem;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLThiTracNghiem
{
    internal class SqlCollections
    {
        /*SELECT PUBS.description AS TenCS, SUBS.subscriber_server AS MaCS
FROM     dbo.sysmergepublications AS PUBS INNER JOIN
                  dbo.sysmergesubscriptions AS SUBS ON PUBS.pubid = SUBS.pubid AND PUBS.publisher <> SUBS.subscriber_server
WHERE  (PUBS.description <> 'TraCuu')*/
        public readonly static String Get_V_Subscribers = "Select * From V_DS_PhanManh";
      
        /*d*/
        public static String Sp_Get_User_Info()
        {
            return $"EXEC SP_Get_User_Info '{Program.mlogin}'";
        }

        public static String Sp_DN_Cho_SV(String username, String password)
        {
            return $"Exec SP_Dang_Nhap_Cho_SV {username}, {password}";
        }
    }
}

/*USE [DB_TracNghiem]
GO
*//****** Object:  StoredProcedure [dbo].[SP_Dang_Nhap_Cho_SV]    Script Date: 08/05/2023 10:11:43 SA ******//*
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[SP_Dang_Nhap_Cho_SV]
@Username nvarchar(15),
@Password nvarchar(50)
as
begin

    Select MASV,
    HOTEN = HO + ' ' + TEN,
    TenNhom = (select CoSo = name from sys.sysusers where uid = (
select groupuid from sys.sysmembers where memberuid = 
(select uid from sys.sysusers where sid = SUSER_SID('SV'))))
	from LINK2.DB_TracNghiem.DBO.SinhVien as dbtt
    where dbtt.MASV = @Username and dbtt.MATKHAU = @Password
end
*/

/*USE[DB_TracNghiem]
GO
*//****** Object:  StoredProcedure [dbo].[SP_Get_User_Info]    Script Date: 08/05/2023 10:12:07 SA ******//*
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SP_Get_User_Info] @Loginname nvarchar(50)
AS
Declare @Username nvarchar(50)
Select @Username = Name from sys.sysusers where sid = SUSER_SID(@Loginname)
Begin
Select MaNV = @Username,
        HoTen = (Select HO + ' ' + TEN from GIANGVIEN where MAGV = @Username),
		TenNhom = Name from sys.sysusers
where uid = (select GroupUID
from sys.sysmembers
where memberuid = (select uid from sys.sysusers where name = @Username))
end*/

/*USE[DB_TracNghiem]
GO
*//****** Object:  StoredProcedure [dbo].[SP_Kiem_Tra_Khoa]    Script Date: 08/05/2023 10:12:18 SA ******//*
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[SP_Kiem_Tra_Khoa]
@MaKhoa nvarchar(15)
as
begin
if exists(Select MAKHOA from KHOA where KHOA.MAKHOA = @MaKhoa)
return 1;
else
if exists(Select MAKHOA from LINK0.DB_TracNghiem.DBO.KHOA as dbtt where dbtt.MAKHOA = @MaKhoa)
return 1;
else
    return 0;
end*/

/*USE[DB_TracNghiem]
GO
*//****** Object:  StoredProcedure [dbo].[SP_Kiem_Tra_Lop]    Script Date: 08/05/2023 10:12:31 SA ******//*
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[SP_Kiem_Tra_Lop]
@MaLop nvarchar(15)
as
begin
if exists(Select MALOP from LOP where LOP.MALOP = @MaLop)
return 1;
else
if exists(Select MALOP from LINK2.DB_TracNghiem.DBO.LOP as dbtt where dbtt.MALOP = @MaLop)
return 1;
else
    return 0;
end*/
/*
USE[DB_TracNghiem]
GO
*//****** Object:  StoredProcedure [dbo].[SP_Kiem_Tra_MonHoc]    Script Date: 08/05/2023 10:12:43 SA ******//*
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[SP_Kiem_Tra_MonHoc]
@MaMH nvarchar(15)
as
begin
if (exists(Select MAMH from MONHOC where MAMH = @MaMH))
    return 1;
else
    return 0;
end*/
/*
USE[DB_TracNghiem]
GO
*//****** Object:  StoredProcedure [dbo].[SP_Tim_MACS]    Script Date: 08/05/2023 10:12:54 SA ******//*
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Proc [dbo].[SP_Tim_MACS]
as
begin

    Select MACS from COSO
end
*/