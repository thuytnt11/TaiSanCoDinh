--drop Database TSCD
USE [master]
GO
/****** Object:  Database [TSCD]    Script Date: 19-Dec-16 1:34:19 PM ******/
CREATE DATABASE [TSCD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TSCD', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\TSCD.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TSCD_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\TSCD_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TSCD] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TSCD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TSCD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TSCD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TSCD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TSCD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TSCD] SET ARITHABORT OFF 
GO
ALTER DATABASE [TSCD] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TSCD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TSCD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TSCD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TSCD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TSCD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TSCD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TSCD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TSCD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TSCD] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TSCD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TSCD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TSCD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TSCD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TSCD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TSCD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TSCD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TSCD] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TSCD] SET  MULTI_USER 
GO
ALTER DATABASE [TSCD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TSCD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TSCD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TSCD] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
--ALTER DATABASE [TSCD] SET DELAYED_DURABILITY = DISABLED 
--GO
USE [TSCD]
GO
/****** Object:  Table [dbo].[CHITIETPHIEUGIAO]    Script Date: 19-Dec-16 1:34:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUGIAO](
	[mathietbi] [int] NOT NULL,
	[maphieugiao] [int] NOT NULL,
	[soluong] [int] NULL,
 CONSTRAINT [PK_CHITIETPHIEUGIAO] PRIMARY KEY CLUSTERED 
(
	[mathietbi] ASC,
	[maphieugiao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DONVI]    Script Date: 19-Dec-16 1:34:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DONVI](
	[madonvi] [int] IDENTITY(1,1) NOT NULL,
	[tendonvi] [nvarchar](50) NULL,
	[ghichu] [nvarchar](200) NULL,
 CONSTRAINT [PK_DONVI] PRIMARY KEY CLUSTERED 
(
	[madonvi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DONVITINH]    Script Date: 19-Dec-16 1:34:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DONVITINH](
	[madonvitinh] [int] IDENTITY(1,1) NOT NULL,
	[tendonvitinh] [nvarchar](50) NULL,
 CONSTRAINT [PK_DONVITINH] PRIMARY KEY CLUSTERED 
(
	[madonvitinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOAITHIETBI]    Script Date: 19-Dec-16 1:34:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAITHIETBI](
	[maloai] [int] IDENTITY(1,1) NOT NULL,
	[tenloai] [nvarchar](50) NULL,
 CONSTRAINT [PK_LOAITHIETBI] PRIMARY KEY CLUSTERED 
(
	[maloai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 19-Dec-16 1:34:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[manhacungcap] [int] IDENTITY(1,1) NOT NULL,
	[tennhacungcap] [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
	[sdt] [nvarchar](11) NULL,
 CONSTRAINT [PK_NHACUNGCAP] PRIMARY KEY CLUSTERED 
(
	[manhacungcap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUGIAO]    Script Date: 19-Dec-16 1:34:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUGIAO](
	[maphieugiao] [int] IDENTITY(1,1) NOT NULL,
	[ngaygiao] [datetime] NULL,
	[daky] [int] NULL,
	[tinhtrang] [nvarchar](50) NULL,
	[maphongquantri] [int] NULL,
	[madonvi] [int] NULL,
 CONSTRAINT [PK_PHIEUGIAO] PRIMARY KEY CLUSTERED 
(
	[maphieugiao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 19-Dec-16 1:34:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[maphieunhap] [int] IDENTITY(1,1) NOT NULL,
	[ngaynhap] [datetime] NULL,
	[manhacungcap] [int] NULL,
	[mathietbi] [int] NOT NULL,
	[soluong] [int] NULL,
	[madonvi] [int] null
 CONSTRAINT [PK_PHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[maphieunhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHONGQUANTRI]    Script Date: 19-Dec-16 1:34:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONGQUANTRI](
	[maphongquantri] [int] IDENTITY(1,1) NOT NULL,
	[tenphongquantri] [nvarchar](50) NULL,
 CONSTRAINT [PK_PHONGQUANTRITHIETBI] PRIMARY KEY CLUSTERED 
(
	[maphongquantri] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[THIETBI]    Script Date: 19-Dec-16 1:34:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THIETBI](
	[mathietbi] [int] IDENTITY(1,1) NOT NULL,
	[tenthietbi] [nvarchar](100) NULL,
	[dongia] [int] NULL,
	[thongsokythuat] [nvarchar](500) NULL,
	[ngaysanxuat] [datetime] NULL,
	[ngayduavaosudung] [datetime] NULL,
	[ngaycapnhat] [datetime] NULL,
	[soluong] [int] NULL,
	[madonvitinh] [int] NULL,
	[maloai] [int] NULL,
	[maphongquantri] [int] NULL,
	[matinhtrang] [int] NULL,
 CONSTRAINT [PK_THIETBI] PRIMARY KEY CLUSTERED 
(
	[mathietbi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TINHTRANG]    Script Date: 19-Dec-16 1:34:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TINHTRANG](
	[matinhtrang] [int] IDENTITY(1,1) NOT NULL,
	[tentinhtrang] [nvarchar](100) NULL,
 CONSTRAINT [PK_TINHTRANG] PRIMARY KEY CLUSTERED 
(
	[matinhtrang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[CHITIETPHIEUGIAO] ([mathietbi], [maphieugiao], [soluong]) VALUES (2, 1, 2)
INSERT [dbo].[CHITIETPHIEUGIAO] ([mathietbi], [maphieugiao], [soluong]) VALUES (2, 2, 2)
SET IDENTITY_INSERT [dbo].[DONVI] ON 

INSERT [dbo].[DONVI] ([madonvi], [tendonvi], [ghichu]) VALUES (1, N'Khoa CNTT', N'Công Nghệ Thông Tin')
INSERT [dbo].[DONVI] ([madonvi], [tendonvi], [ghichu]) VALUES (2, N'Khoa Điện Tử', N'Điện Tử Viễn Thông')
INSERT [dbo].[DONVI] ([madonvi], [tendonvi], [ghichu]) VALUES (3, N'Khoa Du lịch', N'Du lịch ')
INSERT [dbo].[DONVI] ([madonvi], [tendonvi], [ghichu]) VALUES (4, N'Khoa Kinh Tế', N'Kinh Tế ')
INSERT [dbo].[DONVI] ([madonvi], [tendonvi], [ghichu]) VALUES (5, N'Khoa Mỹ Thuật', N'Mỹ Thuật')
INSERT [dbo].[DONVI] ([madonvi], [tendonvi], [ghichu]) VALUES (6, N'Khoa Nội Trợ', N'Nội Trợ Đảm Đang')
INSERT [dbo].[DONVI] ([madonvi], [tendonvi], [ghichu]) VALUES (7, N'Khoa Bình Tĩnh', N'Bình Tĩnh')
INSERT [dbo].[DONVI] ([madonvi], [tendonvi], [ghichu]) VALUES (8, N'Khoa Hồi Sức', N'Hồi Sức')
INSERT [dbo].[DONVI] ([madonvi], [tendonvi], [ghichu]) VALUES (9, N'Khoa Dưỡng Lão', N'Dưỡng Lão')
INSERT [dbo].[DONVI] ([madonvi], [tendonvi], [ghichu]) VALUES (10, N'Khoa Thể Thao', N'Thể Thao')
INSERT [dbo].[DONVI] ([madonvi], [tendonvi], [ghichu]) VALUES (11, N'Khoa Mầm Già', N'Mầm Già')
SET IDENTITY_INSERT [dbo].[DONVI] OFF
SET IDENTITY_INSERT [dbo].[DONVITINH] ON 

INSERT [dbo].[DONVITINH] ([madonvitinh], [tendonvitinh]) VALUES (1, N'cm')
INSERT [dbo].[DONVITINH] ([madonvitinh], [tendonvitinh]) VALUES (2, N'kg')
INSERT [dbo].[DONVITINH] ([madonvitinh], [tendonvitinh]) VALUES (3, N'm3')
SET IDENTITY_INSERT [dbo].[DONVITINH] OFF
SET IDENTITY_INSERT [dbo].[LOAITHIETBI] ON 

INSERT [dbo].[LOAITHIETBI] ([maloai], [tenloai]) VALUES (1, N'IT')
INSERT [dbo].[LOAITHIETBI] ([maloai], [tenloai]) VALUES (2, N'Âm thanh')
INSERT [dbo].[LOAITHIETBI] ([maloai], [tenloai]) VALUES (3, N'Hình ảnh')
SET IDENTITY_INSERT [dbo].[LOAITHIETBI] OFF
SET IDENTITY_INSERT [dbo].[NHACUNGCAP] ON 

INSERT [dbo].[NHACUNGCAP] ([manhacungcap], [tennhacungcap], [diachi], [sdt]) VALUES (1, N'Tân Hiệp Phát', N'Quảng Ngãi', N'01662637397')
INSERT [dbo].[NHACUNGCAP] ([manhacungcap], [tennhacungcap], [diachi], [sdt]) VALUES (2, N'Hiệp Thành', N'Sài Gòn', N'01662637397')
INSERT [dbo].[NHACUNGCAP] ([manhacungcap], [tennhacungcap], [diachi], [sdt]) VALUES (3, N'Trà Vinh', N'Tây Ninh', N'01662637397')
INSERT [dbo].[NHACUNGCAP] ([manhacungcap], [tennhacungcap], [diachi], [sdt]) VALUES (4, N'Siêu Thị BigC', N'Sài Gòn', N'01662637397')
INSERT [dbo].[NHACUNGCAP] ([manhacungcap], [tennhacungcap], [diachi], [sdt]) VALUES (5, N'Lạc Hồng', N'Âu Cơ', N'01662637397')
INSERT [dbo].[NHACUNGCAP] ([manhacungcap], [tennhacungcap], [diachi], [sdt]) VALUES (6, N'Mắt Nai', N'Bình Tĩnh', N'01662638484')
INSERT [dbo].[NHACUNGCAP] ([manhacungcap], [tennhacungcap], [diachi], [sdt]) VALUES (7, N'Trại Giam', N'Đồng Nai', N'01726266634')
INSERT [dbo].[NHACUNGCAP] ([manhacungcap], [tennhacungcap], [diachi], [sdt]) VALUES (8, N'Sting Dâu', N'Cần Thơ', N'01237444833')
INSERT [dbo].[NHACUNGCAP] ([manhacungcap], [tennhacungcap], [diachi], [sdt]) VALUES (9, N'Bí Đỏ', N'Sài Gòn', N'01123444553')
INSERT [dbo].[NHACUNGCAP] ([manhacungcap], [tennhacungcap], [diachi], [sdt]) VALUES (10, N'Dâu Tây', N'Bình Hưng Hòa', N'01444433337')
INSERT [dbo].[NHACUNGCAP] ([manhacungcap], [tennhacungcap], [diachi], [sdt]) VALUES (11, N'Điện máy Xanh', N'Sài Gòn', N'01223456677')
SET IDENTITY_INSERT [dbo].[NHACUNGCAP] OFF
SET IDENTITY_INSERT [dbo].[PHIEUGIAO] ON 

INSERT [dbo].[PHIEUGIAO] ([maphieugiao], [ngaygiao], [daky], [tinhtrang], [maphongquantri], [madonvi]) VALUES (1, CAST(N'2016-11-28 00:00:00.000' AS DateTime), 1, N'1', 1, NULL)
INSERT [dbo].[PHIEUGIAO] ([maphieugiao], [ngaygiao], [daky], [tinhtrang], [maphongquantri], [madonvi]) VALUES (2, CAST(N'2016-11-30 00:00:00.000' AS DateTime), 1, N'1', 1, NULL)
SET IDENTITY_INSERT [dbo].[PHIEUGIAO] OFF
SET IDENTITY_INSERT [dbo].[PHIEUNHAP] ON 

INSERT [dbo].[PHIEUNHAP] ([maphieunhap], [ngaynhap], [manhacungcap], [mathietbi], [soluong], [madonvi] ) VALUES (1, CAST(N'2016-11-25 00:00:00.000' AS DateTime), 1, 2, 10, 1)
SET IDENTITY_INSERT [dbo].[PHIEUNHAP] OFF
SET IDENTITY_INSERT [dbo].[PHONGQUANTRI] ON 

INSERT [dbo].[PHONGQUANTRI] ([maphongquantri], [tenphongquantri]) VALUES (1, N'phòng vi tính')
INSERT [dbo].[PHONGQUANTRI] ([maphongquantri], [tenphongquantri]) VALUES (2, N'phòng âm thanh')
INSERT [dbo].[PHONGQUANTRI] ([maphongquantri], [tenphongquantri]) VALUES (3, N'phòng ánh sáng')
SET IDENTITY_INSERT [dbo].[PHONGQUANTRI] OFF
SET IDENTITY_INSERT [dbo].[THIETBI] ON 

INSERT [dbo].[THIETBI] ([mathietbi], [tenthietbi], [dongia], [thongsokythuat], [ngaysanxuat], [ngayduavaosudung], [ngaycapnhat], [soluong], [madonvitinh], [maloai], [maphongquantri], [matinhtrang]) VALUES (2, N'Màn hình LCD', 200000, N'tjjgkeirh', CAST(N'2004-10-10 00:00:00.000' AS DateTime), CAST(N'2014-10-11 00:00:00.000' AS DateTime), CAST(N'2016-12-13 00:00:00.000' AS DateTime), 6, 1, 1, 1, 2)
INSERT [dbo].[THIETBI] ([mathietbi], [tenthietbi], [dongia], [thongsokythuat], [ngaysanxuat], [ngayduavaosudung], [ngaycapnhat], [soluong], [madonvitinh], [maloai], [maphongquantri], [matinhtrang]) VALUES (3, N'thuyt', 12, N'áđâs', CAST(N'1994-10-10 00:00:00.000' AS DateTime), CAST(N'2015-10-10 00:00:00.000' AS DateTime), CAST(N'2016-12-13 20:35:34.320' AS DateTime), 1, 1, 1, 1, 1)
INSERT [dbo].[THIETBI] ([mathietbi], [tenthietbi], [dongia], [thongsokythuat], [ngaysanxuat], [ngayduavaosudung], [ngaycapnhat], [soluong], [madonvitinh], [maloai], [maphongquantri], [matinhtrang]) VALUES (4, N'a', 12, N'1ăđasdá', CAST(N'2016-06-13 00:00:00.000' AS DateTime), CAST(N'2016-12-13 00:00:00.000' AS DateTime), CAST(N'2016-12-15 00:00:00.000' AS DateTime), 1, 1, 1, 1, 3)
INSERT [dbo].[THIETBI] ([mathietbi], [tenthietbi], [dongia], [thongsokythuat], [ngaysanxuat], [ngayduavaosudung], [ngaycapnhat], [soluong], [madonvitinh], [maloai], [maphongquantri], [matinhtrang]) VALUES (5, N'411', 1231, N'1áđâsdá', CAST(N'2010-06-17 00:00:00.000' AS DateTime), CAST(N'2016-12-13 00:00:00.000' AS DateTime), CAST(N'2016-12-13 20:51:11.463' AS DateTime), 122, 1, 2, 1, 2)
INSERT [dbo].[THIETBI] ([mathietbi], [tenthietbi], [dongia], [thongsokythuat], [ngaysanxuat], [ngayduavaosudung], [ngaycapnhat], [soluong], [madonvitinh], [maloai], [maphongquantri], [matinhtrang]) VALUES (6, N'sdá', 122, N'áđâs', CAST(N'2010-03-10 00:00:00.000' AS DateTime), CAST(N'2016-12-07 00:00:00.000' AS DateTime), CAST(N'2016-12-13 20:51:43.697' AS DateTime), 121, 1, 3, 3, 2)
INSERT [dbo].[THIETBI] ([mathietbi], [tenthietbi], [dongia], [thongsokythuat], [ngaysanxuat], [ngayduavaosudung], [ngaycapnhat], [soluong], [madonvitinh], [maloai], [maphongquantri], [matinhtrang]) VALUES (7, N'4412', 111, N'áđâsđá', CAST(N'2010-06-15 00:00:00.000' AS DateTime), CAST(N'2016-12-13 00:00:00.000' AS DateTime), CAST(N'2016-12-15 00:00:00.000' AS DateTime), 11, 3, 2, 1, 1)
INSERT [dbo].[THIETBI] ([mathietbi], [tenthietbi], [dongia], [thongsokythuat], [ngaysanxuat], [ngayduavaosudung], [ngaycapnhat], [soluong], [madonvitinh], [maloai], [maphongquantri], [matinhtrang]) VALUES (8, N'4412', 111, N'áđâsđá', CAST(N'2010-06-15 00:00:00.000' AS DateTime), CAST(N'2016-12-13 00:00:00.000' AS DateTime), CAST(N'2016-12-13 20:52:16.943' AS DateTime), 11, 3, 2, 1, 2)
INSERT [dbo].[THIETBI] ([mathietbi], [tenthietbi], [dongia], [thongsokythuat], [ngaysanxuat], [ngayduavaosudung], [ngaycapnhat], [soluong], [madonvitinh], [maloai], [maphongquantri], [matinhtrang]) VALUES (9, N'444', 11, N'áđâs', CAST(N'2014-06-03 00:00:00.000' AS DateTime), CAST(N'2016-12-13 00:00:00.000' AS DateTime), CAST(N'2016-12-13 20:59:41.050' AS DateTime), 1, 1, 1, 1, 1)
SET IDENTITY_INSERT [dbo].[THIETBI] OFF
SET IDENTITY_INSERT [dbo].[TINHTRANG] ON 

INSERT [dbo].[TINHTRANG] ([matinhtrang], [tentinhtrang]) VALUES (1, N'mới')
INSERT [dbo].[TINHTRANG] ([matinhtrang], [tentinhtrang]) VALUES (2, N'đã qua sử dụng')
INSERT [dbo].[TINHTRANG] ([matinhtrang], [tentinhtrang]) VALUES (3, N'gì đó')
SET IDENTITY_INSERT [dbo].[TINHTRANG] OFF
ALTER TABLE [dbo].[CHITIETPHIEUGIAO]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUGIAO_PHIEUGIAO] FOREIGN KEY([maphieugiao])
REFERENCES [dbo].[PHIEUGIAO] ([maphieugiao])
GO
ALTER TABLE [dbo].[CHITIETPHIEUGIAO] CHECK CONSTRAINT [FK_CHITIETPHIEUGIAO_PHIEUGIAO]
GO
ALTER TABLE [dbo].[CHITIETPHIEUGIAO]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUGIAO_THIETBI] FOREIGN KEY([mathietbi])
REFERENCES [dbo].[THIETBI] ([mathietbi])
GO
ALTER TABLE [dbo].[CHITIETPHIEUGIAO] CHECK CONSTRAINT [FK_CHITIETPHIEUGIAO_THIETBI]
GO
ALTER TABLE [dbo].[PHIEUGIAO]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUGIAO_DONVI] FOREIGN KEY([madonvi])
REFERENCES [dbo].[DONVI] ([madonvi])
GO
ALTER TABLE [dbo].[PHIEUGIAO] CHECK CONSTRAINT [FK_PHIEUGIAO_DONVI]
GO
ALTER TABLE [dbo].[PHIEUGIAO]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUGIAO_PHONGQUANTRITHIETBI] FOREIGN KEY([maphongquantri])
REFERENCES [dbo].[PHONGQUANTRI] ([maphongquantri])
GO
ALTER TABLE [dbo].[PHIEUGIAO] CHECK CONSTRAINT [FK_PHIEUGIAO_PHONGQUANTRITHIETBI]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_NHACUNGCAP] FOREIGN KEY([manhacungcap])
REFERENCES [dbo].[NHACUNGCAP] ([manhacungcap])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_NHACUNGCAP]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_THIETBI] FOREIGN KEY([mathietbi])
REFERENCES [dbo].[THIETBI] ([mathietbi])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_THIETBI]
GO
ALTER TABLE [dbo].[THIETBI]  WITH CHECK ADD  CONSTRAINT [FK_THIETBI_DONVITINH] FOREIGN KEY([madonvitinh])
REFERENCES [dbo].[DONVITINH] ([madonvitinh])
GO
ALTER TABLE [dbo].[THIETBI] CHECK CONSTRAINT [FK_THIETBI_DONVITINH]
GO
ALTER TABLE [dbo].[THIETBI]  WITH CHECK ADD  CONSTRAINT [FK_THIETBI_LOAITHIETBI] FOREIGN KEY([maloai])
REFERENCES [dbo].[LOAITHIETBI] ([maloai])
GO
ALTER TABLE [dbo].[THIETBI] CHECK CONSTRAINT [FK_THIETBI_LOAITHIETBI]
GO
ALTER TABLE [dbo].[THIETBI]  WITH CHECK ADD  CONSTRAINT [FK_THIETBI_PHONGQUANTRITHIETBI] FOREIGN KEY([maphongquantri])
REFERENCES [dbo].[PHONGQUANTRI] ([maphongquantri])
GO
ALTER TABLE [dbo].[THIETBI] CHECK CONSTRAINT [FK_THIETBI_PHONGQUANTRITHIETBI]
GO
ALTER TABLE [dbo].[THIETBI]  WITH CHECK ADD  CONSTRAINT [FK_THIETBI_TINHTRANG] FOREIGN KEY([matinhtrang])
REFERENCES [dbo].[TINHTRANG] ([matinhtrang])
GO
ALTER TABLE [dbo].[THIETBI] CHECK CONSTRAINT [FK_THIETBI_TINHTRANG]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_DONVI] FOREIGN KEY([madonvi])
REFERENCES [dbo].[DONVI] ([madonvi])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_DONVI]
GO
/****** Object:  StoredProcedure [dbo].[dsthietbi]    Script Date: 19-Dec-16 1:34:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[dsthietbi]
as

begin
	select * from THIETBI
end
GO
/****** Object:  StoredProcedure [dbo].[themthietbi]    Script Date: 19-Dec-16 1:34:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--CREATE proc [dbo].[themthietbi]
--@mathietbi int,
--@tenthietbi nvarchar(100),
--@dongia int,
--@thongsokythuat nvarchar(500),
--@ngaysanxuat datetime,
--@ngayduavaosudung datetime,
--@soluong int,
--@madonvitinh int,
--@maloai int,
--@maphongquantri int
--as
--begin
--	insert into THIETBI values (@tenthietbi, @dongia, @thongsokythuat, @ngaysanxuat, @ngayduavaosudung, @soluong, @madonvitinh, @maloai, @maphongquantri)
--	set @mathietbi = @@IDENTITY
--end
GO
USE [master]
GO
ALTER DATABASE [TSCD] SET  READ_WRITE 
GO
