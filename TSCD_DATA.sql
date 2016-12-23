USE [TSCD]
GO
/****** Object:  StoredProcedure [dbo].[dsthietbi]    Script Date: 23/12/2016 2:40:37 CH ******/
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
/****** Object:  Table [dbo].[CHITIETPHIEUGIAO]    Script Date: 23/12/2016 2:40:37 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUGIAO](
	[mathietbi] [int] NOT NULL,
	[maphieugiao] [int] NOT NULL,
	[soluong] [int] NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_CHITIETPHIEUGIAO] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DONVI]    Script Date: 23/12/2016 2:40:37 CH ******/
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
/****** Object:  Table [dbo].[DONVITINH]    Script Date: 23/12/2016 2:40:37 CH ******/
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
/****** Object:  Table [dbo].[LOAITHIETBI]    Script Date: 23/12/2016 2:40:37 CH ******/
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
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 23/12/2016 2:40:37 CH ******/
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
/****** Object:  Table [dbo].[PHIEUGIAO]    Script Date: 23/12/2016 2:40:37 CH ******/
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
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 23/12/2016 2:40:37 CH ******/
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
	[madonvi] [int] NULL,
 CONSTRAINT [PK_PHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[maphieunhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHONGQUANTRI]    Script Date: 23/12/2016 2:40:37 CH ******/
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
/****** Object:  Table [dbo].[THIETBI]    Script Date: 23/12/2016 2:40:37 CH ******/
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
/****** Object:  Table [dbo].[TINHTRANG]    Script Date: 23/12/2016 2:40:37 CH ******/
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
SET IDENTITY_INSERT [dbo].[CHITIETPHIEUGIAO] ON 

INSERT [dbo].[CHITIETPHIEUGIAO] ([mathietbi], [maphieugiao], [soluong], [ID]) VALUES (2, 5, 1, 3)
INSERT [dbo].[CHITIETPHIEUGIAO] ([mathietbi], [maphieugiao], [soluong], [ID]) VALUES (2, 5, 2, 4)
INSERT [dbo].[CHITIETPHIEUGIAO] ([mathietbi], [maphieugiao], [soluong], [ID]) VALUES (2, 1003, 3, 1003)
INSERT [dbo].[CHITIETPHIEUGIAO] ([mathietbi], [maphieugiao], [soluong], [ID]) VALUES (4, 1003, 5, 1004)
SET IDENTITY_INSERT [dbo].[CHITIETPHIEUGIAO] OFF
SET IDENTITY_INSERT [dbo].[DONVI] ON 

INSERT [dbo].[DONVI] ([madonvi], [tendonvi], [ghichu]) VALUES (1, N'Khoa CNTT', N'Công Nghệ Thông Tin')
INSERT [dbo].[DONVI] ([madonvi], [tendonvi], [ghichu]) VALUES (2, N'Khoa Điện Tử', N'Điện Tử Viễn Thông')
INSERT [dbo].[DONVI] ([madonvi], [tendonvi], [ghichu]) VALUES (3, N'Khoa Quan hệ Quốc Tế', N'Du lịch ')
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
INSERT [dbo].[DONVITINH] ([madonvitinh], [tendonvitinh]) VALUES (4, N'cái')
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

INSERT [dbo].[PHIEUGIAO] ([maphieugiao], [ngaygiao], [daky], [tinhtrang], [maphongquantri], [madonvi]) VALUES (4, CAST(0x0000A6E400000000 AS DateTime), 1, N'1', 1, 6)
INSERT [dbo].[PHIEUGIAO] ([maphieugiao], [ngaygiao], [daky], [tinhtrang], [maphongquantri], [madonvi]) VALUES (5, CAST(0x0000A6E400000000 AS DateTime), 1, N'1', 1, 3)
INSERT [dbo].[PHIEUGIAO] ([maphieugiao], [ngaygiao], [daky], [tinhtrang], [maphongquantri], [madonvi]) VALUES (1003, CAST(0x0000A6E400000000 AS DateTime), 1, N'1', 1, 1)
INSERT [dbo].[PHIEUGIAO] ([maphieugiao], [ngaygiao], [daky], [tinhtrang], [maphongquantri], [madonvi]) VALUES (1004, CAST(0x0000A6E500000000 AS DateTime), 1, N'1', 1, 3)
SET IDENTITY_INSERT [dbo].[PHIEUGIAO] OFF
SET IDENTITY_INSERT [dbo].[PHIEUNHAP] ON 

INSERT [dbo].[PHIEUNHAP] ([maphieunhap], [ngaynhap], [manhacungcap], [mathietbi], [soluong], [madonvi]) VALUES (4, CAST(0x0000A6D000000000 AS DateTime), NULL, 2, 2, 1)
INSERT [dbo].[PHIEUNHAP] ([maphieunhap], [ngaynhap], [manhacungcap], [mathietbi], [soluong], [madonvi]) VALUES (5, CAST(0x0000A6D600000000 AS DateTime), NULL, 2, 1, 1)
INSERT [dbo].[PHIEUNHAP] ([maphieunhap], [ngaynhap], [manhacungcap], [mathietbi], [soluong], [madonvi]) VALUES (6, CAST(0x0000A6DE00000000 AS DateTime), 8, 3, 22, NULL)
INSERT [dbo].[PHIEUNHAP] ([maphieunhap], [ngaynhap], [manhacungcap], [mathietbi], [soluong], [madonvi]) VALUES (1002, CAST(0x0000A6E800000000 AS DateTime), 2, 5, 3, NULL)
SET IDENTITY_INSERT [dbo].[PHIEUNHAP] OFF
SET IDENTITY_INSERT [dbo].[PHONGQUANTRI] ON 

INSERT [dbo].[PHONGQUANTRI] ([maphongquantri], [tenphongquantri]) VALUES (1, N'Phòng Vi Tính')
INSERT [dbo].[PHONGQUANTRI] ([maphongquantri], [tenphongquantri]) VALUES (2, N'Phòng Âm Thanh')
INSERT [dbo].[PHONGQUANTRI] ([maphongquantri], [tenphongquantri]) VALUES (3, N'Phòng Ánh Sáng')
SET IDENTITY_INSERT [dbo].[PHONGQUANTRI] OFF
SET IDENTITY_INSERT [dbo].[THIETBI] ON 

INSERT [dbo].[THIETBI] ([mathietbi], [tenthietbi], [dongia], [thongsokythuat], [ngaysanxuat], [ngayduavaosudung], [ngaycapnhat], [soluong], [madonvitinh], [maloai], [maphongquantri], [matinhtrang]) VALUES (2, N'Màn hình LCD', 2000000, N'Màn Hình', CAST(0x0000957C00000000 AS DateTime), CAST(0x0000A3C100000000 AS DateTime), CAST(0x0000A6DB00000000 AS DateTime), 28, 4, 1, 1, 2)
INSERT [dbo].[THIETBI] ([mathietbi], [tenthietbi], [dongia], [thongsokythuat], [ngaysanxuat], [ngayduavaosudung], [ngaycapnhat], [soluong], [madonvitinh], [maloai], [maphongquantri], [matinhtrang]) VALUES (3, N'Bàn Phím', 500000, N'Bàn Phím', CAST(0x0000873700000000 AS DateTime), CAST(0x0000A52D00000000 AS DateTime), CAST(0x0000A6DB01535C28 AS DateTime), 23, 4, 1, 1, 1)
INSERT [dbo].[THIETBI] ([mathietbi], [tenthietbi], [dongia], [thongsokythuat], [ngaysanxuat], [ngayduavaosudung], [ngaycapnhat], [soluong], [madonvitinh], [maloai], [maphongquantri], [matinhtrang]) VALUES (4, N'Chuột', 100000, N'Chuột', CAST(0x0000A62400000000 AS DateTime), CAST(0x0000A6DB00000000 AS DateTime), CAST(0x0000A6DD00000000 AS DateTime), 1, 4, 1, 1, 3)
INSERT [dbo].[THIETBI] ([mathietbi], [tenthietbi], [dongia], [thongsokythuat], [ngaysanxuat], [ngayduavaosudung], [ngaycapnhat], [soluong], [madonvitinh], [maloai], [maphongquantri], [matinhtrang]) VALUES (5, N'Máy Chiếu', 3000000, N'Máy Chiếu', CAST(0x00009D9800000000 AS DateTime), CAST(0x0000A6DB00000000 AS DateTime), CAST(0x0000A6DB0157A65F AS DateTime), 125, 4, 2, 1, 2)
INSERT [dbo].[THIETBI] ([mathietbi], [tenthietbi], [dongia], [thongsokythuat], [ngaysanxuat], [ngayduavaosudung], [ngaycapnhat], [soluong], [madonvitinh], [maloai], [maphongquantri], [matinhtrang]) VALUES (6, N'Thùng Máy', 5000000, N'Thùng Máy Tính', CAST(0x00009D3500000000 AS DateTime), CAST(0x0000A6D500000000 AS DateTime), CAST(0x0000A6DB0157CC25 AS DateTime), 121, 4, 3, 3, 2)
INSERT [dbo].[THIETBI] ([mathietbi], [tenthietbi], [dongia], [thongsokythuat], [ngaysanxuat], [ngayduavaosudung], [ngaycapnhat], [soluong], [madonvitinh], [maloai], [maphongquantri], [matinhtrang]) VALUES (7, N'Máy Lạnh', 5500000, N'Máy Lạnh', CAST(0x00009D9600000000 AS DateTime), CAST(0x0000A6DB00000000 AS DateTime), CAST(0x0000A6DD00000000 AS DateTime), 11, 4, 2, 1, 1)
INSERT [dbo].[THIETBI] ([mathietbi], [tenthietbi], [dongia], [thongsokythuat], [ngaysanxuat], [ngayduavaosudung], [ngaycapnhat], [soluong], [madonvitinh], [maloai], [maphongquantri], [matinhtrang]) VALUES (8, N'Tivi', 7000000, N'Tivi', CAST(0x00009D9600000000 AS DateTime), CAST(0x0000A6DB00000000 AS DateTime), CAST(0x0000A6DB0157F31B AS DateTime), 11, 4, 2, 1, 2)
INSERT [dbo].[THIETBI] ([mathietbi], [tenthietbi], [dongia], [thongsokythuat], [ngaysanxuat], [ngayduavaosudung], [ngaycapnhat], [soluong], [madonvitinh], [maloai], [maphongquantri], [matinhtrang]) VALUES (9, N'Màn Chiếu', 1200000, N'Màn Máy Chiếu', CAST(0x0000A33F00000000 AS DateTime), CAST(0x0000A6DB00000000 AS DateTime), CAST(0x0000A6DB0159FB8B AS DateTime), 1, 4, 1, 1, 1)
INSERT [dbo].[THIETBI] ([mathietbi], [tenthietbi], [dongia], [thongsokythuat], [ngaysanxuat], [ngayduavaosudung], [ngaycapnhat], [soluong], [madonvitinh], [maloai], [maphongquantri], [matinhtrang]) VALUES (10, N'Máy Casset', 500000, N'Máy Nghe Tiếng Anh', CAST(0x0000A33F00000000 AS DateTime), CAST(0x0000A6DB00000000 AS DateTime), CAST(0x0000A6DB0159FB8B AS DateTime), 2, 4, 1, 2, 1)
SET IDENTITY_INSERT [dbo].[THIETBI] OFF
SET IDENTITY_INSERT [dbo].[TINHTRANG] ON 

INSERT [dbo].[TINHTRANG] ([matinhtrang], [tentinhtrang]) VALUES (1, N'Mới')
INSERT [dbo].[TINHTRANG] ([matinhtrang], [tentinhtrang]) VALUES (2, N'Đã Qua Sử Dụng (99%)')
INSERT [dbo].[TINHTRANG] ([matinhtrang], [tentinhtrang]) VALUES (3, N'Đã Qua Sử Dụng (50%)')
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
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_DONVI] FOREIGN KEY([madonvi])
REFERENCES [dbo].[DONVI] ([madonvi])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_DONVI]
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
