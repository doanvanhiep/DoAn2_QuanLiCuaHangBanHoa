USE [master]
GO
/****** Object:  Database [FlowersShop]    Script Date: 5/19/2019 11:16:38 PM ******/
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
/****** Object:  UserDefinedFunction [dbo].[checkAccount]    Script Date: 5/19/2019 11:16:39 PM ******/
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
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 5/19/2019 11:16:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[IDHoaDon] [int] NOT NULL,
	[IDSP] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [real] NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[IDHoaDon] ASC,
	[IDSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 5/19/2019 11:16:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[IDHoaDon] [int] NOT NULL,
	[NgayThanhToan] [datetime] NULL,
	[IDNV] [int] NULL,
	[TongTien] [real] NULL,
	[TrangThai] [nvarchar](50) NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[IDHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhoHang]    Script Date: 5/19/2019 11:16:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhoHang](
	[STT] [int] NOT NULL,
	[IDSP] [int] NOT NULL,
	[IDNV] [int] NULL,
	[NgayNhap] [datetime] NOT NULL,
	[NgayHetHan] [datetime] NULL,
	[SoLuong] [int] NULL,
	[GiaNhap] [real] NULL,
 CONSTRAINT [PK_KhoHang] PRIMARY KEY CLUSTERED 
(
	[STT] ASC,
	[IDSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiNhanVien]    Script Date: 5/19/2019 11:16:39 PM ******/
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
/****** Object:  Table [dbo].[NhanVien]    Script Date: 5/19/2019 11:16:39 PM ******/
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
/****** Object:  Table [dbo].[SanPham]    Script Date: 5/19/2019 11:16:39 PM ******/
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
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (1, 1, 4, 60000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (1, 2, 2, 300000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (1, 3, 3, 20000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (2, 1, 2, 60000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (2, 2, 3, 300000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (3, 2, 2, 300000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (3, 3, 1, 20000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (4, 1, 3, 60000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (4, 3, 1, 20000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (5, 2, 2, 300000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (6, 1, 3, 60000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (6, 2, 2, 300000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (6, 4, 2, 150000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (7, 1, 3, 60000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (8, 2, 3, 300000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (8, 3, 1, 20000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (9, 4, 2, 150000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (11, 1, 2, 60000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (12, 1, 49, 60000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (12, 3, 2, 20000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (13, 1, 3, 60000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (14, 1, 3, 60000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (15, 2, 2, 300000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (16, 2, 1, 300000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (17, 2, 5, 300000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (18, 1, 3, 60000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (19, 2, 3, 300000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (20, 1, 3, 60000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (20, 3, 2, 20000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (21, 2, 1, 300000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (22, 4, 1, 150000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (23, 4, 2, 150000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (24, 1, 1, 60000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (25, 2, 2, 300000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (26, 1, 2, 60000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (27, 1, 1, 60000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (27, 2, 1, 300000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (28, 2, 1, 300000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (28, 4, 2, 150000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (29, 2, 2, 300000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (29, 3, 1, 20000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (30, 1, 1, 60000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (30, 2, 1, 300000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (31, 1, 1, 60000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (31, 2, 2, 300000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (32, 3, 1, 20000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (32, 4, 1, 150000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (33, 1, 2, 60000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (33, 3, 1, 20000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (34, 1, 2, 60000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (34, 3, 1, 20000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (35, 1, 10, 60000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (36, 1, 2, 60000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (37, 4, 4, 150000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (38, 2, 10, 300000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDSP], [SoLuong], [DonGia]) VALUES (39, 4, 10, 150000)
INSERT [dbo].[HoaDon] ([IDHoaDon], [NgayThanhToan], [IDNV], [TongTien], [TrangThai]) VALUES (1, CAST(N'2019-04-12T00:00:00.000' AS DateTime), 2, 380000, N'Đã thanh toán')
INSERT [dbo].[HoaDon] ([IDHoaDon], [NgayThanhToan], [IDNV], [TongTien], [TrangThai]) VALUES (2, CAST(N'2019-04-12T00:00:00.000' AS DateTime), 2, 360000, N'Đã hủy')
INSERT [dbo].[HoaDon] ([IDHoaDon], [NgayThanhToan], [IDNV], [TongTien], [TrangThai]) VALUES (3, CAST(N'2019-04-12T00:00:00.000' AS DateTime), 2, 320000, N'Đã thanh toán')
INSERT [dbo].[HoaDon] ([IDHoaDon], [NgayThanhToan], [IDNV], [TongTien], [TrangThai]) VALUES (4, CAST(N'2019-04-17T00:00:00.000' AS DateTime), 2, 80000, N'Đã thanh toán')
INSERT [dbo].[HoaDon] ([IDHoaDon], [NgayThanhToan], [IDNV], [TongTien], [TrangThai]) VALUES (5, CAST(N'2019-04-17T00:00:00.000' AS DateTime), 2, 300000, N'Đã hủy')
INSERT [dbo].[HoaDon] ([IDHoaDon], [NgayThanhToan], [IDNV], [TongTien], [TrangThai]) VALUES (6, CAST(N'2019-04-17T00:00:00.000' AS DateTime), 2, 510000, N'Đã thanh toán')
INSERT [dbo].[HoaDon] ([IDHoaDon], [NgayThanhToan], [IDNV], [TongTien], [TrangThai]) VALUES (7, CAST(N'2019-03-17T00:00:00.000' AS DateTime), 2, 60000, N'Đã thanh toán')
INSERT [dbo].[HoaDon] ([IDHoaDon], [NgayThanhToan], [IDNV], [TongTien], [TrangThai]) VALUES (8, CAST(N'2019-04-16T00:00:00.000' AS DateTime), 2, 320000, N'Đã thanh toán')
INSERT [dbo].[HoaDon] ([IDHoaDon], [NgayThanhToan], [IDNV], [TongTien], [TrangThai]) VALUES (9, CAST(N'2019-01-18T00:00:00.000' AS DateTime), 2, 150000, N'Đã thanh toán')
INSERT [dbo].[HoaDon] ([IDHoaDon], [NgayThanhToan], [IDNV], [TongTien], [TrangThai]) VALUES (10, CAST(N'2019-04-27T21:59:39.483' AS DateTime), 1, 100000, N'Ðã Thanh Toán')
INSERT [dbo].[HoaDon] ([IDHoaDon], [NgayThanhToan], [IDNV], [TongTien], [TrangThai]) VALUES (11, CAST(N'2019-04-28T00:00:00.000' AS DateTime), 2, 60000, N'Đã Thanh Toán')
INSERT [dbo].[HoaDon] ([IDHoaDon], [NgayThanhToan], [IDNV], [TongTien], [TrangThai]) VALUES (12, CAST(N'2019-05-06T00:00:00.000' AS DateTime), 2, 80000, N'Đã Thanh Toán')
INSERT [dbo].[HoaDon] ([IDHoaDon], [NgayThanhToan], [IDNV], [TongTien], [TrangThai]) VALUES (13, CAST(N'2019-05-07T00:00:00.000' AS DateTime), 2, 60000, N'Đã Thanh Toán')
INSERT [dbo].[HoaDon] ([IDHoaDon], [NgayThanhToan], [IDNV], [TongTien], [TrangThai]) VALUES (14, CAST(N'2019-05-08T00:00:00.000' AS DateTime), 2, 60000, N'Đã Thanh Toán')
INSERT [dbo].[HoaDon] ([IDHoaDon], [NgayThanhToan], [IDNV], [TongTien], [TrangThai]) VALUES (15, CAST(N'2019-05-08T00:00:00.000' AS DateTime), 2, 300000, N'Đã Thanh Toán')
INSERT [dbo].[HoaDon] ([IDHoaDon], [NgayThanhToan], [IDNV], [TongTien], [TrangThai]) VALUES (16, CAST(N'2019-05-08T00:00:00.000' AS DateTime), 2, 300000, N'Đã Thanh Toán')
INSERT [dbo].[HoaDon] ([IDHoaDon], [NgayThanhToan], [IDNV], [TongTien], [TrangThai]) VALUES (17, CAST(N'2019-05-08T00:00:00.000' AS DateTime), 2, 300000, N'Đã Thanh Toán')
INSERT [dbo].[HoaDon] ([IDHoaDon], [NgayThanhToan], [IDNV], [TongTien], [TrangThai]) VALUES (18, CAST(N'2019-05-08T00:00:00.000' AS DateTime), 2, 60000, N'Đã Thanh Toán')
INSERT [dbo].[HoaDon] ([IDHoaDon], [NgayThanhToan], [IDNV], [TongTien], [TrangThai]) VALUES (19, CAST(N'2019-05-09T00:00:00.000' AS DateTime), 1, 300000, N'Đã Thanh Toán')
INSERT [dbo].[HoaDon] ([IDHoaDon], [NgayThanhToan], [IDNV], [TongTien], [TrangThai]) VALUES (20, CAST(N'2019-05-15T00:00:00.000' AS DateTime), 1, 80000, N'Đã Thanh Toán')
INSERT [dbo].[HoaDon] ([IDHoaDon], [NgayThanhToan], [IDNV], [TongTien], [TrangThai]) VALUES (21, CAST(N'2019-05-15T00:00:00.000' AS DateTime), 1, 300000, N'Đã Thanh Toán')
INSERT [dbo].[HoaDon] ([IDHoaDon], [NgayThanhToan], [IDNV], [TongTien], [TrangThai]) VALUES (22, CAST(N'2019-05-15T00:00:00.000' AS DateTime), 1, 150000, N'Đã Thanh Toán')
INSERT [dbo].[HoaDon] ([IDHoaDon], [NgayThanhToan], [IDNV], [TongTien], [TrangThai]) VALUES (23, CAST(N'2019-05-15T00:00:00.000' AS DateTime), 2, 150000, N'Đã Thanh Toán')
INSERT [dbo].[HoaDon] ([IDHoaDon], [NgayThanhToan], [IDNV], [TongTien], [TrangThai]) VALUES (24, CAST(N'2019-05-15T00:00:00.000' AS DateTime), 2, 60000, N'Đã Thanh Toán')
INSERT [dbo].[HoaDon] ([IDHoaDon], [NgayThanhToan], [IDNV], [TongTien], [TrangThai]) VALUES (25, CAST(N'2019-05-15T00:00:00.000' AS DateTime), 2, 300000, N'Đã Thanh Toán')
INSERT [dbo].[HoaDon] ([IDHoaDon], [NgayThanhToan], [IDNV], [TongTien], [TrangThai]) VALUES (26, CAST(N'2019-05-15T00:00:00.000' AS DateTime), 2, 60000, N'Đã Thanh Toán')
INSERT [dbo].[HoaDon] ([IDHoaDon], [NgayThanhToan], [IDNV], [TongTien], [TrangThai]) VALUES (27, CAST(N'2019-05-15T00:00:00.000' AS DateTime), 2, 360000, N'Đã Thanh Toán')
INSERT [dbo].[HoaDon] ([IDHoaDon], [NgayThanhToan], [IDNV], [TongTien], [TrangThai]) VALUES (28, CAST(N'2019-05-15T00:00:00.000' AS DateTime), 1, 450000, N'Đã Thanh Toán')
INSERT [dbo].[HoaDon] ([IDHoaDon], [NgayThanhToan], [IDNV], [TongTien], [TrangThai]) VALUES (29, CAST(N'2019-05-15T00:00:00.000' AS DateTime), 1, 320000, N'Đã Thanh Toán')
INSERT [dbo].[HoaDon] ([IDHoaDon], [NgayThanhToan], [IDNV], [TongTien], [TrangThai]) VALUES (30, CAST(N'2019-05-15T00:00:00.000' AS DateTime), 2, 360000, N'Đã Thanh Toán')
INSERT [dbo].[HoaDon] ([IDHoaDon], [NgayThanhToan], [IDNV], [TongTien], [TrangThai]) VALUES (31, CAST(N'2019-05-15T00:00:00.000' AS DateTime), 1, 360000, N'Đã Thanh Toán')
INSERT [dbo].[HoaDon] ([IDHoaDon], [NgayThanhToan], [IDNV], [TongTien], [TrangThai]) VALUES (32, CAST(N'2019-05-15T00:00:00.000' AS DateTime), 1, 170000, N'Đã Thanh Toán')
INSERT [dbo].[HoaDon] ([IDHoaDon], [NgayThanhToan], [IDNV], [TongTien], [TrangThai]) VALUES (33, CAST(N'2019-05-15T00:00:00.000' AS DateTime), 1, 80000, N'Đã Thanh Toán')
INSERT [dbo].[HoaDon] ([IDHoaDon], [NgayThanhToan], [IDNV], [TongTien], [TrangThai]) VALUES (34, CAST(N'2019-05-15T00:00:00.000' AS DateTime), 2, 80000, N'Đã Thanh Toán')
INSERT [dbo].[HoaDon] ([IDHoaDon], [NgayThanhToan], [IDNV], [TongTien], [TrangThai]) VALUES (35, CAST(N'2019-05-15T00:00:00.000' AS DateTime), 2, 60000, N'Đã Thanh Toán')
INSERT [dbo].[HoaDon] ([IDHoaDon], [NgayThanhToan], [IDNV], [TongTien], [TrangThai]) VALUES (36, CAST(N'2019-05-15T00:00:00.000' AS DateTime), 1, 60000, N'Đã Thanh Toán')
INSERT [dbo].[HoaDon] ([IDHoaDon], [NgayThanhToan], [IDNV], [TongTien], [TrangThai]) VALUES (37, CAST(N'2019-05-16T00:00:00.000' AS DateTime), 1, 150000, N'Đã Thanh Toán')
INSERT [dbo].[HoaDon] ([IDHoaDon], [NgayThanhToan], [IDNV], [TongTien], [TrangThai]) VALUES (38, CAST(N'2019-05-16T00:00:00.000' AS DateTime), 1, 300000, N'Đã Thanh Toán')
INSERT [dbo].[HoaDon] ([IDHoaDon], [NgayThanhToan], [IDNV], [TongTien], [TrangThai]) VALUES (39, CAST(N'2019-05-17T00:00:00.000' AS DateTime), 1, 150000, N'Đã Thanh Toán')
INSERT [dbo].[KhoHang] ([STT], [IDSP], [IDNV], [NgayNhap], [NgayHetHan], [SoLuong], [GiaNhap]) VALUES (1, 2, 1, CAST(N'2019-12-12T00:00:00.000' AS DateTime), CAST(N'2019-04-29T00:00:00.000' AS DateTime), 12, 12)
INSERT [dbo].[KhoHang] ([STT], [IDSP], [IDNV], [NgayNhap], [NgayHetHan], [SoLuong], [GiaNhap]) VALUES (3, 2, 3, CAST(N'2019-03-12T00:00:00.000' AS DateTime), CAST(N'2019-04-12T00:00:00.000' AS DateTime), 25, 1000000)
INSERT [dbo].[KhoHang] ([STT], [IDSP], [IDNV], [NgayNhap], [NgayHetHan], [SoLuong], [GiaNhap]) VALUES (4, 3, 3, CAST(N'2019-02-12T00:00:00.000' AS DateTime), CAST(N'2019-04-12T00:00:00.000' AS DateTime), 55, 1000000)
INSERT [dbo].[KhoHang] ([STT], [IDSP], [IDNV], [NgayNhap], [NgayHetHan], [SoLuong], [GiaNhap]) VALUES (5, 2, 3, CAST(N'1992-12-03T00:00:00.000' AS DateTime), CAST(N'1992-12-02T00:00:00.000' AS DateTime), 1, 1000000)
INSERT [dbo].[KhoHang] ([STT], [IDSP], [IDNV], [NgayNhap], [NgayHetHan], [SoLuong], [GiaNhap]) VALUES (6, 1, 1, CAST(N'2019-04-27T00:00:00.000' AS DateTime), CAST(N'2020-04-28T00:00:00.000' AS DateTime), 0, 100000)
INSERT [dbo].[KhoHang] ([STT], [IDSP], [IDNV], [NgayNhap], [NgayHetHan], [SoLuong], [GiaNhap]) VALUES (8, 1, 1, CAST(N'2019-12-12T00:00:00.000' AS DateTime), CAST(N'2019-04-26T00:00:00.000' AS DateTime), 12, 12)
INSERT [dbo].[KhoHang] ([STT], [IDSP], [IDNV], [NgayNhap], [NgayHetHan], [SoLuong], [GiaNhap]) VALUES (9, 1, 1, CAST(N'2019-04-30T00:00:00.000' AS DateTime), CAST(N'2019-04-30T00:00:00.000' AS DateTime), 12, 12)
INSERT [dbo].[KhoHang] ([STT], [IDSP], [IDNV], [NgayNhap], [NgayHetHan], [SoLuong], [GiaNhap]) VALUES (10, 2, 3, CAST(N'2019-05-05T00:00:00.000' AS DateTime), CAST(N'2019-06-06T00:00:00.000' AS DateTime), 0, 300000)
INSERT [dbo].[KhoHang] ([STT], [IDSP], [IDNV], [NgayNhap], [NgayHetHan], [SoLuong], [GiaNhap]) VALUES (11, 4, 3, CAST(N'2019-05-04T00:00:00.000' AS DateTime), CAST(N'2019-09-05T00:00:00.000' AS DateTime), 180, 2000000)
INSERT [dbo].[KhoHang] ([STT], [IDSP], [IDNV], [NgayNhap], [NgayHetHan], [SoLuong], [GiaNhap]) VALUES (12, 1, 3, CAST(N'2018-11-11T00:00:00.000' AS DateTime), CAST(N'2019-05-16T00:00:00.000' AS DateTime), 178, 1000000)
INSERT [dbo].[LoaiNhanVien] ([IDLoaiNV], [LoaiNV]) VALUES (1, N'Quản lý')
INSERT [dbo].[LoaiNhanVien] ([IDLoaiNV], [LoaiNV]) VALUES (2, N'Thu ngân')
INSERT [dbo].[LoaiNhanVien] ([IDLoaiNV], [LoaiNV]) VALUES (3, N'Thủ kho')
INSERT [dbo].[NhanVien] ([IDNV], [TenNV], [TuoiNV], [UserID], [UserPassword], [IDLoaiNV]) VALUES (1, N'Hoàng', N'20', N'hoang', N'123', 1)
INSERT [dbo].[NhanVien] ([IDNV], [TenNV], [TuoiNV], [UserID], [UserPassword], [IDLoaiNV]) VALUES (2, N'Hiệp', N'20', N'hiep', N'123', 2)
INSERT [dbo].[NhanVien] ([IDNV], [TenNV], [TuoiNV], [UserID], [UserPassword], [IDLoaiNV]) VALUES (3, N'Trí', N'20', N'tri', N'123', 3)
INSERT [dbo].[NhanVien] ([IDNV], [TenNV], [TuoiNV], [UserID], [UserPassword], [IDLoaiNV]) VALUES (5, N'Vinh', N'20', N'vinh', N'123', 2)
INSERT [dbo].[NhanVien] ([IDNV], [TenNV], [TuoiNV], [UserID], [UserPassword], [IDLoaiNV]) VALUES (6, N'Thành', N'20', N'thanh', N'123', 2)
INSERT [dbo].[NhanVien] ([IDNV], [TenNV], [TuoiNV], [UserID], [UserPassword], [IDLoaiNV]) VALUES (7, N'hoang1', N'20', N'14325325', N'22', 1)
INSERT [dbo].[SanPham] ([IDSP], [TenSP], [Gia], [MoTa]) VALUES (1, N'Hoa Cúc', 30000, N'Hoa cúc')
INSERT [dbo].[SanPham] ([IDSP], [TenSP], [Gia], [MoTa]) VALUES (2, N'Hoa Mai', 30000, N'Hoa Mai')
INSERT [dbo].[SanPham] ([IDSP], [TenSP], [Gia], [MoTa]) VALUES (3, N'Hoa Sen', 20000, N'Chưa rõ')
INSERT [dbo].[SanPham] ([IDSP], [TenSP], [Gia], [MoTa]) VALUES (4, N'Hoa Đào', 15000, N'Hoa dao')
INSERT [dbo].[SanPham] ([IDSP], [TenSP], [Gia], [MoTa]) VALUES (5, N'Hoa Hồng', 50000, N'Hoa Hồng')
ALTER TABLE [dbo].[HoaDon] ADD  CONSTRAINT [DF_HoaDon_TrangThai]  DEFAULT (N'Đã Thanh Toán') FOR [TrangThai]
GO
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
ALTER TABLE [dbo].[KhoHang]  WITH CHECK ADD  CONSTRAINT [FK_KhoHang_NhanVien] FOREIGN KEY([IDNV])
REFERENCES [dbo].[NhanVien] ([IDNV])
GO
ALTER TABLE [dbo].[KhoHang] CHECK CONSTRAINT [FK_KhoHang_NhanVien]
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
/****** Object:  StoredProcedure [dbo].[sp_DeleteKhoHang]    Script Date: 5/19/2019 11:16:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_DeleteKhoHang] @stt int
as
delete from KhoHang where STT=@stt 



GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteNhanVien]    Script Date: 5/19/2019 11:16:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_DeleteNhanVien] @IDNV int
as
delete from NhanVien where IDNV=@IDNV;



GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteSanPham]    Script Date: 5/19/2019 11:16:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[sp_DeleteSanPham] @idsp int
as
delete from SanPham where IDSP=@idsp;



GO
/****** Object:  StoredProcedure [dbo].[sp_getGiaSanPhamByID]    Script Date: 5/19/2019 11:16:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_getGiaSanPhamByID]
@id  int
AS
BEGIN
	select Gia from SanPham where IDSP=@id
END

exec sp_getNhanVienByID 1

GO
/****** Object:  StoredProcedure [dbo].[sp_getIDSPByName]    Script Date: 5/19/2019 11:16:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_getIDSPByName]
@TenSP nvarchar(50)
as
Select IDSP from SanPham where TenSP=@TenSP

GO
/****** Object:  StoredProcedure [dbo].[sp_getNhanVienByID]    Script Date: 5/19/2019 11:16:39 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_getSumSanPhamByID]    Script Date: 5/19/2019 11:16:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_getSumSanPhamByID]
@IDSP int
as
select Sum(SoLuong) as N'SumSP'from KhoHang where IDSP=@IDSP

exec sp_getSumSanPhamByID 1

GO
/****** Object:  StoredProcedure [dbo].[sp_insertHoaDon]    Script Date: 5/19/2019 11:16:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_insertHoaDon]
 @NgayThanhToan datetime,
 @IDNV int,
 @TongTien real,
 @TrangThai nvarchar(50)
as
declare @id int
select @id= max(IDHoaDon) 
from HoaDon
set @id=@id+1
insert into HoaDon values(@id,@NgayThanhToan,@IDNV,@TongTien,@TrangThai)

GO
/****** Object:  StoredProcedure [dbo].[sp_insertHoaDonChiTiet]    Script Date: 5/19/2019 11:16:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_insertHoaDonChiTiet]
 @IDHoaDon int,
 @IDSP int,
 @SoLuong int,
 @DonGia real
as
insert into ChiTietHoaDon values(@IDHoaDon,@IDSP,@SoLuong,@DonGia)

GO
/****** Object:  StoredProcedure [dbo].[sp_insertKhoHang]    Script Date: 5/19/2019 11:16:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_insertKhoHang] @idsp int,@idnv int,@NgayNhap nvarchar(50),@NgayHetHan nvarchar(50),@Soluong int,@gianhap real
as
declare @id int
select @id= max(STT) 
from KhoHang
set @id=@id+1
insert into KhoHang values(@id,@idsp,@idnv,@NgayNhap,@NgayHetHan,@Soluong,@gianhap)






GO
/****** Object:  StoredProcedure [dbo].[sp_insertNhanVien]    Script Date: 5/19/2019 11:16:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_insertNhanVien] @TenNv nvarchar(50),@Tuoi nvarchar(50),@userid nvarchar(50),@userpassword nvarchar(50),@idloainv int
as
declare @id int
select @id= max(IDNV) 
from NhanVien
set @id=@id+1
insert into NhanVien values(@id,@TenNv,@Tuoi,@userid,@userpassword,@idloainv)



GO
/****** Object:  StoredProcedure [dbo].[sp_insertSanPham]    Script Date: 5/19/2019 11:16:39 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_LoadDoanhThuNam]    Script Date: 5/19/2019 11:16:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[sp_LoadDoanhThuNam]
AS
BEGIN
select hd.IDHoaDon,SoLuong,Gia
from (HoaDon hd join ChiTietHoaDon ct on hd.IDHoaDon=ct.IDHoaDon) join SanPham sp on ct.IDSP=sp.IDSP
where datediff(day,NgayThanhToan,GETDATE())<=365 and TrangThai=N'Đã thanh toán'
END

GO
/****** Object:  StoredProcedure [dbo].[sp_LoadDoanhThuNamTruoc]    Script Date: 5/19/2019 11:16:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[sp_LoadDoanhThuNamTruoc]
AS
BEGIN
select hd.IDHoaDon,SoLuong,Gia
from (HoaDon hd join ChiTietHoaDon ct on hd.IDHoaDon=ct.IDHoaDon) join SanPham sp on ct.IDSP=sp.IDSP
where datediff(day,NgayThanhToan,GETDATE())>365 and datediff(day,NgayThanhToan,GETDATE())<=730 and TrangThai=N'Đã thanh toán'
END
GO
/****** Object:  StoredProcedure [dbo].[sp_LoadDoanhThuThang]    Script Date: 5/19/2019 11:16:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_LoadDoanhThuThang]
AS
BEGIN
select hd.IDHoaDon,SoLuong,Gia
from (HoaDon hd join ChiTietHoaDon ct on hd.IDHoaDon=ct.IDHoaDon) join SanPham sp on ct.IDSP=sp.IDSP
where datediff(day,NgayThanhToan,GETDATE())<=30 and TrangThai=N'Đã thanh toán'
END



GO
/****** Object:  StoredProcedure [dbo].[sp_LoadDoanhThuThangByCount]    Script Date: 5/19/2019 11:16:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_LoadDoanhThuThangByCount] @count int 
AS
BEGIN
select hd.IDHoaDon,SoLuong,Gia
from (HoaDon hd join ChiTietHoaDon ct on hd.IDHoaDon=ct.IDHoaDon) join SanPham sp on ct.IDSP=sp.IDSP
where datediff(day,NgayThanhToan,GETDATE())<=30*@count and TrangThai=N'Đã thanh toán'
END
GO
/****** Object:  StoredProcedure [dbo].[sp_LoadDoanhThuThangTruoc]    Script Date: 5/19/2019 11:16:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_LoadDoanhThuThangTruoc]
AS
BEGIN
select hd.IDHoaDon,SoLuong,Gia
from (HoaDon hd join ChiTietHoaDon ct on hd.IDHoaDon=ct.IDHoaDon) join SanPham sp on ct.IDSP=sp.IDSP
where datediff(day,NgayThanhToan,GETDATE())>30 and datediff(day,NgayThanhToan,GETDATE())<=60 and TrangThai=N'Đã thanh toán'
END



GO
/****** Object:  StoredProcedure [dbo].[sp_LoadDoanhThuTuan]    Script Date: 5/19/2019 11:16:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[sp_LoadDoanhThuTuan]
AS
BEGIN
select hd.IDHoaDon,SoLuong,Gia
from (HoaDon hd join ChiTietHoaDon ct on hd.IDHoaDon=ct.IDHoaDon) join SanPham sp on ct.IDSP=sp.IDSP
where datediff(day,NgayThanhToan,GETDATE())<=7 and TrangThai=N'Đã thanh toán'
END
GO
/****** Object:  StoredProcedure [dbo].[sp_LoadDoanhThuTuanTruoc]    Script Date: 5/19/2019 11:16:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[sp_LoadDoanhThuTuanTruoc]
AS
BEGIN
select hd.IDHoaDon,SoLuong,Gia
from (HoaDon hd join ChiTietHoaDon ct on hd.IDHoaDon=ct.IDHoaDon) join SanPham sp on ct.IDSP=sp.IDSP
where datediff(day,NgayThanhToan,GETDATE())>7 and datediff(day,NgayThanhToan,GETDATE())<=14 and TrangThai=N'Đã thanh toán'
END


GO
/****** Object:  StoredProcedure [dbo].[sp_LoadDSHetHan]    Script Date: 5/19/2019 11:16:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_LoadDSHetHan]
AS
BEGIN
select KhoHang.STT,SanPham.TenSP,KhoHang.NgayHetHan,KhoHang.SoLuong from KhoHang,SanPham
 where KhoHang.IDSP=SanPham.IDSP and KhoHang.SoLuong>0 and (KhoHang.NgayHetHan-GETDATE()<=3) and (KhoHang.NgayHetHan-GETDATE()>=0)
END


GO
/****** Object:  StoredProcedure [dbo].[sp_LoadGiaHoaDon]    Script Date: 5/19/2019 11:16:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_LoadGiaHoaDon]
AS
BEGIN
select hd.IDHoaDon,SoLuong,Gia
from (HoaDon hd join ChiTietHoaDon ct on hd.IDHoaDon=ct.IDHoaDon) join SanPham sp on ct.IDSP=sp.IDSP
where DATEPART(YEAR,NgayThanhToan)=YEAR(getdate()) and DATEPART(MONTH,NgayThanhToan)=month(getdate()) and DATEPART(day,NgayThanhToan)=day(getdate()) and TrangThai=N'Đã thanh toán'
END



GO
/****** Object:  StoredProcedure [dbo].[sp_LoadHoaDon]    Script Date: 5/19/2019 11:16:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_LoadHoaDon]
as
select HoaDon.IDHoaDon as N'STT',HoaDon.NgayThanhToan,NhanVien.TenNV,HoaDon.TongTien,HoaDon.TrangThai
 from NhanVien,HoaDon where HoaDon.IDNV=NhanVien.IDNV

GO
/****** Object:  StoredProcedure [dbo].[sp_LoadHoaDonChiTietbyIDHoaDon]    Script Date: 5/19/2019 11:16:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_LoadHoaDonChiTietbyIDHoaDon]
 @IDHoaDon int
as
select SanPham.TenSP,SoLuong,DonGia as N'ThanhTien' from ChiTietHoaDon,SanPham
 where ChiTietHoaDon.IDSP=SanPham.IDSP and ChiTietHoaDon.IDHoaDon=@IDHoaDon

GO
/****** Object:  StoredProcedure [dbo].[sp_LoadHoaDonHuy]    Script Date: 5/19/2019 11:16:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_LoadHoaDonHuy]
AS
BEGIN
select count(hd.IDHoaDon) as sl
from HoaDon hd 
where DATEPART(YEAR,NgayThanhToan)=YEAR(getdate()) and DATEPART(MONTH,NgayThanhToan)=month(getdate()) and DATEPART(day,NgayThanhToan)=day(getdate())and TrangThai=N'Đã hủy'
group by TrangThai
END


GO
/****** Object:  StoredProcedure [dbo].[sp_LoadHoaDonNgayTruoc]    Script Date: 5/19/2019 11:16:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_LoadHoaDonNgayTruoc]
AS
BEGIN
select hd.IDHoaDon,SoLuong,Gia
from (HoaDon hd join ChiTietHoaDon ct on hd.IDHoaDon=ct.IDHoaDon) join SanPham sp on ct.IDSP=sp.IDSP
where DATEPART(YEAR,NgayThanhToan)=YEAR(getdate()) and DATEPART(MONTH,NgayThanhToan)=month(getdate()) and DATEPART(day,NgayThanhToan)=day((getdate())-1) and TrangThai=N'Đã thanh toán'
END



GO
/****** Object:  StoredProcedure [dbo].[sp_LoadKhoHang]    Script Date: 5/19/2019 11:16:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_LoadKhoHang]
AS
BEGIN
select  sp.IDSP,TenSP,Gia,MoTa,STT,nv.IDNV,TenNV,NgayNhap,NgayHetHan,SoLuong,GiaNhap
from (SanPham sp join KhoHang kh on sp.IDSP=kh.IDSP )join NhanVien nv on kh.IDNV=nv.IDNV
order by STT,sp.IDSP
END


GO
/****** Object:  StoredProcedure [dbo].[sp_LoadNhanVien]    Script Date: 5/19/2019 11:16:39 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_LoadNhanVienByType]    Script Date: 5/19/2019 11:16:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_LoadNhanVienByType] @idloainv int,@tennv nvarchar(50)
AS
BEGIN
select  IDNV,TenNV,TuoiNV,UserID,UserPassword,nv.IDLoaiNV,LoaiNV
from NhanVien nv join LoaiNhanVien lnv on nv.IDLoaiNV=lnv.IDLoaiNV
where nv.IDLoaiNV=@idloainv or TenNV like @tennv
END
GO
/****** Object:  StoredProcedure [dbo].[sp_LoadSanPham]    Script Date: 5/19/2019 11:16:39 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_LoadSanPhamBanChayNhat]    Script Date: 5/19/2019 11:16:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_LoadSanPhamBanChayNhat]
AS
BEGIN
select TenSP,SUM(SoLuong)as Max
from ChiTietHoaDon ct join SanPham sp on ct.IDSP=sp.IDSP
Group by TenSP
order by Max 
end


GO
/****** Object:  StoredProcedure [dbo].[sp_LoadSanPhamBanTeNhat]    Script Date: 5/19/2019 11:16:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[sp_LoadSanPhamBanTeNhat]
AS
BEGIN
select TenSP,SUM(SoLuong)as Max
from ChiTietHoaDon ct join SanPham sp on ct.IDSP=sp.IDSP
Group by TenSP 
order by Max desc
end
GO
/****** Object:  StoredProcedure [dbo].[sp_LoadSanPhamByID]    Script Date: 5/19/2019 11:16:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_LoadSanPhamByID] @idsp int
AS
BEGIN
select  *
from SanPham 
where IDSP = @idsp
END
GO
/****** Object:  StoredProcedure [dbo].[sp_LoadSanPhamByName]    Script Date: 5/19/2019 11:16:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_LoadSanPhamByName] @tensp nvarchar(50)
AS
BEGIN
select  *
from SanPham 
where TenSP like @tensp
END



GO
/****** Object:  StoredProcedure [dbo].[sp_MaxHoaDon]    Script Date: 5/19/2019 11:16:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[sp_MaxHoaDon]
as
select max(IDHoaDon) as MaxIDHoaDon from HoaDon 

GO
/****** Object:  StoredProcedure [dbo].[sp_updateKhoHang]    Script Date: 5/19/2019 11:16:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[sp_updateKhoHang] 
@STT int,@idsp int,@idnv int,@NgayNhap  nvarchar(50),@NgayHetHan  nvarchar(50),@Soluong int,@GiaNhap real
as
update  KhoHang set
IDNV=@idnv,
NgayNhap=@NgayNhap,
NgayHetHan=@NgayHetHan,
SoLuong=@Soluong,
GiaNhap=@GiaNhap
where STT=@STT and IDSP=@idsp



GO
/****** Object:  StoredProcedure [dbo].[sp_updateNhanVien]    Script Date: 5/19/2019 11:16:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_updateNhanVien] 
@idnv int,@TenNv nvarchar(50),@Tuoi nvarchar(50),@userid nvarchar(50),@userpassword nvarchar(50),@idloainv int
as
update  NhanVien set
TenNV=@TenNv,
TuoiNV=@Tuoi,
UserID=@userid,
UserPassword=@userpassword,
IDLoaiNV=@idloainv

where IDNV=@idnv


GO
/****** Object:  StoredProcedure [dbo].[sp_updatePasswordNhanVien]    Script Date: 5/19/2019 11:16:39 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_updateSanPham]    Script Date: 5/19/2019 11:16:39 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_updateSLKhoHang]    Script Date: 5/19/2019 11:16:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_updateSLKhoHang] 
@STT int,
@Soluong int
as
update  KhoHang set
SoLuong=@Soluong
where STT=@STT 

GO
/****** Object:  Trigger [dbo].[Insert_Update_GiaChiTietHD]    Script Date: 5/19/2019 11:16:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 Create trigger [dbo].[Insert_Update_GiaChiTietHD]
    on [dbo].[ChiTietHoaDon]
    for insert, update
    as
    if update(soluong)
    begin
    	update 
    		ChiTietHoaDon
    	set 
    		DonGia = I.soluong * SP.Gia
    	from 
    		inserted I,
    		SanPham SP, 
    		ChiTietHoaDon CTHD
    	where 
    		(SP.IDSP = I.IDSP)
    		and (SP.IDSP = CTHD.IDSP)
    end


GO
ALTER TABLE [dbo].[ChiTietHoaDon] ENABLE TRIGGER [Insert_Update_GiaChiTietHD]
GO
/****** Object:  Trigger [dbo].[Insert_Update_TongGiaHD]    Script Date: 5/19/2019 11:16:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 Create trigger [dbo].[Insert_Update_TongGiaHD]
    on [dbo].[ChiTietHoaDon]
    for insert, update
    as
    if update(DonGia)
    begin
    	update 
    		HoaDon
    	set 
    		TongTien = (select sum(DonGia)
						from ChiTietHoaDon ct
						where  ct.IDHoaDon=i.IDHoaDon
						group by IDHoaDon)
    	from 
    		inserted I,
    		HoaDon HD, 
    		ChiTietHoaDon CTHD
    	where 
    		(HD.IDHoaDon = I.IDHoaDon)
    		and (HD.IDHoaDon = CTHD.IDHoaDon)
		
    end


GO
ALTER TABLE [dbo].[ChiTietHoaDon] ENABLE TRIGGER [Insert_Update_TongGiaHD]
GO
USE [master]
GO
ALTER DATABASE [FlowersShop] SET  READ_WRITE 
GO
