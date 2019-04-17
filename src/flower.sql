USE [master]
GO
/****** Object:  Database [FlowersShop]    Script Date: 4/17/2019 10:06:16 AM ******/
CREATE DATABASE [FlowersShop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FlowersShop', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\FlowersShop.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FlowersShop_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\FlowersShop_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [FlowersShop] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FlowersShop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FlowersShop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FlowersShop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FlowersShop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FlowersShop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FlowersShop] SET ARITHABORT OFF 
GO
ALTER DATABASE [FlowersShop] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FlowersShop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FlowersShop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FlowersShop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FlowersShop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FlowersShop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FlowersShop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FlowersShop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FlowersShop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FlowersShop] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FlowersShop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FlowersShop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FlowersShop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FlowersShop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FlowersShop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FlowersShop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FlowersShop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FlowersShop] SET RECOVERY FULL 
GO
ALTER DATABASE [FlowersShop] SET  MULTI_USER 
GO
ALTER DATABASE [FlowersShop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FlowersShop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FlowersShop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FlowersShop] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FlowersShop] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'FlowersShop', N'ON'
GO
ALTER DATABASE [FlowersShop] SET QUERY_STORE = OFF
GO
USE [FlowersShop]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [FlowersShop]
GO
/****** Object:  UserDefinedFunction [dbo].[checkAccount]    Script Date: 4/17/2019 10:06:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[checkAccount] (@userID nvarchar(50),@pass nvarchar(100))
returns int
as begin
declare @check nvarchar(100)
select @check=userpassword from NhanVien where UserID=@userID

if(@pass = @check)
	return 1
return 0
end

GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 4/17/2019 10:06:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[IDHoaDon] [int] NOT NULL,
	[IDSP] [int] NOT NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[IDHoaDon] ASC,
	[IDSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 4/17/2019 10:06:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[IDHoaDon] [int] NOT NULL,
	[NgayThanhToan] [datetime] NULL,
	[IDNV] [int] NULL,
	[TrangThai] [nvarchar](50) NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[IDHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhoHang]    Script Date: 4/17/2019 10:06:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhoHang](
	[STT] [int] NOT NULL,
	[IDSP] [int] NOT NULL,
	[NgayNhap] [date] NULL,
	[NgayHetHan] [date] NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_KhoHang] PRIMARY KEY CLUSTERED 
(
	[STT] ASC,
	[IDSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiNhanVien]    Script Date: 4/17/2019 10:06:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiNhanVien](
	[IDLoaiNV] [int] NOT NULL,
	[LoaiNV] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiNhanVien] PRIMARY KEY CLUSTERED 
(
	[IDLoaiNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 4/17/2019 10:06:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[IDNV] [int] NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[TuoiNV] [nvarchar](50) NULL,
	[UserID] [nvarchar](50) NULL,
	[UserPassword] [nvarchar](50) NULL,
	[IDLoaiNV] [int] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[IDNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhapHang]    Script Date: 4/17/2019 10:06:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhapHang](
	[IDNhap] [int] NOT NULL,
	[TenNguonNhap] [nvarchar](50) NULL,
	[TongTienNhap] [int] NULL,
	[IDNV] [int] NULL,
 CONSTRAINT [PK_NhapHang] PRIMARY KEY CLUSTERED 
(
	[IDNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 4/17/2019 10:06:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[IDSP] [int] NOT NULL,
	[TenSP] [nvarchar](50) NULL,
	[Gia] [int] NULL,
	[MoTa] [nvarchar](50) NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[IDSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong]) VALUES (1, 1, 2)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong]) VALUES (1, 2, 1)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong]) VALUES (1, 3, 2)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong]) VALUES (2, 1, 4)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong]) VALUES (3, 2, 1)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong]) VALUES (3, 3, 2)
INSERT [dbo].[HoaDon] ([IDHoaDon], [NgayThanhToan], [IDNV], [TrangThai]) VALUES (1, CAST(N'2019-04-12T00:00:00.000' AS DateTime), 2, N'Đã thanh toán')
INSERT [dbo].[HoaDon] ([IDHoaDon], [NgayThanhToan], [IDNV], [TrangThai]) VALUES (2, CAST(N'2019-04-12T00:00:00.000' AS DateTime), 2, N'Đã hủy')
INSERT [dbo].[HoaDon] ([IDHoaDon], [NgayThanhToan], [IDNV], [TrangThai]) VALUES (3, CAST(N'2019-04-12T00:00:00.000' AS DateTime), 2, N'Đã thanh toán')
INSERT [dbo].[KhoHang] ([STT], [IDSP], [NgayNhap], [NgayHetHan], [SoLuong]) VALUES (1, 1, CAST(N'2019-03-12' AS Date), CAST(N'2019-04-12' AS Date), 100)
INSERT [dbo].[KhoHang] ([STT], [IDSP], [NgayNhap], [NgayHetHan], [SoLuong]) VALUES (2, 1, CAST(N'2019-03-29' AS Date), CAST(N'2019-04-29' AS Date), 50)
INSERT [dbo].[KhoHang] ([STT], [IDSP], [NgayNhap], [NgayHetHan], [SoLuong]) VALUES (3, 2, CAST(N'2019-03-12' AS Date), CAST(N'2019-04-12' AS Date), 25)
INSERT [dbo].[KhoHang] ([STT], [IDSP], [NgayNhap], [NgayHetHan], [SoLuong]) VALUES (4, 3, CAST(N'2019-02-12' AS Date), CAST(N'2019-04-12' AS Date), 55)
INSERT [dbo].[KhoHang] ([STT], [IDSP], [NgayNhap], [NgayHetHan], [SoLuong]) VALUES (5, 2, CAST(N'1992-12-03' AS Date), CAST(N'1992-12-02' AS Date), 1)
INSERT [dbo].[LoaiNhanVien] ([IDLoaiNV], [LoaiNV]) VALUES (1, N'Quản lý')
INSERT [dbo].[LoaiNhanVien] ([IDLoaiNV], [LoaiNV]) VALUES (2, N'Thu ngân')
INSERT [dbo].[LoaiNhanVien] ([IDLoaiNV], [LoaiNV]) VALUES (3, N'Thủ kho')
INSERT [dbo].[NhanVien] ([IDNV], [TenNV], [TuoiNV], [UserID], [UserPassword], [IDLoaiNV]) VALUES (1, N'Hoàng', N'20', N'hoang', N'123', 1)
INSERT [dbo].[NhanVien] ([IDNV], [TenNV], [TuoiNV], [UserID], [UserPassword], [IDLoaiNV]) VALUES (2, N'Hiệp', N'20', N'hiep', N'123', 2)
INSERT [dbo].[NhanVien] ([IDNV], [TenNV], [TuoiNV], [UserID], [UserPassword], [IDLoaiNV]) VALUES (3, N'Trí', N'20', N'tri', N'123', 3)
INSERT [dbo].[NhanVien] ([IDNV], [TenNV], [TuoiNV], [UserID], [UserPassword], [IDLoaiNV]) VALUES (4, N'Hào', N'20', N'hao', N'123', 2)
INSERT [dbo].[NhanVien] ([IDNV], [TenNV], [TuoiNV], [UserID], [UserPassword], [IDLoaiNV]) VALUES (5, N'Vinh', N'20', N'vinh', N'123', 2)
INSERT [dbo].[NhapHang] ([IDNhap], [TenNguonNhap], [TongTienNhap], [IDNV]) VALUES (1, N'Đà Lạt Farm', 1200000, 3)
INSERT [dbo].[NhapHang] ([IDNhap], [TenNguonNhap], [TongTienNhap], [IDNV]) VALUES (2, N'Đà Lạt Flowers', 3000000, 3)
INSERT [dbo].[SanPham] ([IDSP], [TenSP], [Gia], [MoTa]) VALUES (1, N'Hoa Cúc', 30000, N'Hoa cúc')
INSERT [dbo].[SanPham] ([IDSP], [TenSP], [Gia], [MoTa]) VALUES (2, N'Hoa Mai', 12000, N'Chưa rõ')
INSERT [dbo].[SanPham] ([IDSP], [TenSP], [Gia], [MoTa]) VALUES (3, N'Hoa Sen', 20000, N'Chưa rõ')
INSERT [dbo].[SanPham] ([IDSP], [TenSP], [Gia], [MoTa]) VALUES (4, N'Hoa Đào', 15000, N'Chưa rõ')
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([IDHoaDon])
REFERENCES [dbo].[HoaDon] ([IDHoaDon])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_SanPham] FOREIGN KEY([IDSP])
REFERENCES [dbo].[SanPham] ([IDSP])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_SanPham]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([IDNV])
REFERENCES [dbo].[NhanVien] ([IDNV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [dbo].[KhoHang]  WITH CHECK ADD  CONSTRAINT [FK_KhoHang_SanPham] FOREIGN KEY([IDSP])
REFERENCES [dbo].[SanPham] ([IDSP])
GO
ALTER TABLE [dbo].[KhoHang] CHECK CONSTRAINT [FK_KhoHang_SanPham]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_LoaiNhanVien] FOREIGN KEY([IDLoaiNV])
REFERENCES [dbo].[LoaiNhanVien] ([IDLoaiNV])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_LoaiNhanVien]
GO
ALTER TABLE [dbo].[NhapHang]  WITH CHECK ADD  CONSTRAINT [FK_NhapHang_NhanVien] FOREIGN KEY([IDNV])
REFERENCES [dbo].[NhanVien] ([IDNV])
GO
ALTER TABLE [dbo].[NhapHang] CHECK CONSTRAINT [FK_NhapHang_NhanVien]
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteKhoHang]    Script Date: 4/17/2019 10:06:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_DeleteKhoHang] @stt int
as
delete from KhoHang where STT=@stt 

GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteNhanVien]    Script Date: 4/17/2019 10:06:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_DeleteNhanVien] @IDNV int
as
delete from NhanVien where IDNV=@IDNV;

GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteSanPham]    Script Date: 4/17/2019 10:06:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[sp_DeleteSanPham] @idsp int
as
delete from SanPham where IDSP=@idsp;

GO
/****** Object:  StoredProcedure [dbo].[sp_getNhanVienByID]    Script Date: 4/17/2019 10:06:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


Create PROCEDURE [dbo].[sp_getNhanVienByID]
@id  int
AS
BEGIN
	select TenNV,lnv.LoaiNV from NhanVien nv join LoaiNhanVien lnv on nv.IDLoaiNV=lnv.IDLoaiNV  where IDNV=@id
END

GO
/****** Object:  StoredProcedure [dbo].[sp_insertKhoHang]    Script Date: 4/17/2019 10:06:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[sp_insertKhoHang] @idsp int,@NgayNhap nvarchar(50),@NgayHetHan nvarchar(50),@Soluong int
as
declare @id int
select @id= max(STT) 
from KhoHang
set @id=@id+1
insert into KhoHang values(@id,@idsp,@NgayNhap,@NgayHetHan,@Soluong)




GO
/****** Object:  StoredProcedure [dbo].[sp_insertNhanVien]    Script Date: 4/17/2019 10:06:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_insertNhanVien] @TenNv nvarchar(50),@Tuoi int,@userid nvarchar(50),@userpassword nvarchar(50),@idloainv int
as
declare @id int
select @id= max(IDNV) 
from NhanVien
set @id=@id+1
insert into NhanVien values(@id,@TenNv,@Tuoi,@userid,@userpassword,@idloainv)




GO
/****** Object:  StoredProcedure [dbo].[sp_insertSanPham]    Script Date: 4/17/2019 10:06:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[sp_insertSanPham] @Tensp nvarchar(50),@gia int,@mota nvarchar(50)
as
declare @id int
select @id= max(IDSP) 
from SanPham
set @id=@id+1
insert into SanPham values(@id,@Tensp,@gia,@mota)




GO
/****** Object:  StoredProcedure [dbo].[sp_LoadKhoHang]    Script Date: 4/17/2019 10:06:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_LoadKhoHang]
AS
BEGIN
select  sp.IDSP,TenSP,Gia,MoTa,STT,NgayNhap,NgayHetHan,SoLuong
from SanPham sp join KhoHang kh on sp.IDSP=kh.IDSP
order by STT,sp.IDSP
END

GO
/****** Object:  StoredProcedure [dbo].[sp_LoadNhanVien]    Script Date: 4/17/2019 10:06:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_LoadNhanVien]
AS
BEGIN
select  IDNV,TenNV,TuoiNV,UserID,UserPassword,nv.IDLoaiNV,LoaiNV
from NhanVien nv join LoaiNhanVien lnv on nv.IDLoaiNV=lnv.IDLoaiNV
END

GO
/****** Object:  StoredProcedure [dbo].[sp_LoadSanPham]    Script Date: 4/17/2019 10:06:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[sp_LoadSanPham]
AS
BEGIN
select  *
from SanPham 
END

GO
/****** Object:  StoredProcedure [dbo].[sp_updateKhoHang]    Script Date: 4/17/2019 10:06:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[sp_updateKhoHang] 
@STT int,@idsp int,@NgayNhap  nvarchar(50),@NgayHetHan  nvarchar(50),@Soluong int
as
update  KhoHang set
NgayNhap=@NgayNhap,
NgayHetHan=@NgayHetHan,
SoLuong=@Soluong
where STT=@STT and IDSP=@idsp

GO
/****** Object:  StoredProcedure [dbo].[sp_updateNhanVien]    Script Date: 4/17/2019 10:06:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_updateNhanVien] 
@idnv int,@TenNv nvarchar(50),@Tuoi int,@userid nvarchar(50),@userpassword nvarchar(50),@idloainv int
as
update  NhanVien set
TenNV=@TenNv,
TuoiNV=@Tuoi,
UserID=@userid,
UserPassword=@userpassword,
IDLoaiNV=@idloainv

where IDNV=@idnv

GO
/****** Object:  StoredProcedure [dbo].[sp_updatePasswordNhanVien]    Script Date: 4/17/2019 10:06:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[sp_updatePasswordNhanVien] 
@idnv int,@userpassword nvarchar(50)
as
update  NhanVien set
UserPassword=@userpassword
where IDNV=@idnv

GO
/****** Object:  StoredProcedure [dbo].[sp_updateSanPham]    Script Date: 4/17/2019 10:06:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


Create proc [dbo].[sp_updateSanPham] 
@idsp int,@Tensp nvarchar(50),@gia int,@mota nvarchar(50)
as
update  SanPham set
TenSP=@Tensp,
Gia=@gia,
MoTa=@mota
where IDSP=@idsp

GO
USE [master]
GO
ALTER DATABASE [FlowersShop] SET  READ_WRITE 
GO
