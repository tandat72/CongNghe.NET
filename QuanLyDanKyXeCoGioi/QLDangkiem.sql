create database DANGKIEM
go
USE [DANGKIEM]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 02/05/2024 2:00:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [varchar](10) NOT NULL,
	[Hoten] [nvarchar](50) NULL,
	[Ngaysinh] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUDK]    Script Date: 02/05/2024 2:00:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUDK](
	[SoPhieu] [int] IDENTITY(1,1) NOT NULL,
	[MaKH] [varchar](10) NULL,
	[Bienso] [varchar](10) NULL,
	[Ngaydk] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[SoPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[XE]    Script Date: 02/05/2024 2:00:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[XE](
	[Bienso] [varchar](10) NOT NULL,
	[Ngayhethan] [date] NULL,
	[MaKH] [varchar](10) NULL,
	[Hinh] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Bienso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[KHACHHANG] ([MaKH], [Hoten], [Ngaysinh]) VALUES (N'039245678', N'Trần Anh Huy', CAST(N'2023-08-03' AS Date))
INSERT [dbo].[KHACHHANG] ([MaKH], [Hoten], [Ngaysinh]) VALUES (N'090456178', N'Nguyễn Ngọc Minh Hải', CAST(N'2023-10-03' AS Date))
INSERT [dbo].[KHACHHANG] ([MaKH], [Hoten], [Ngaysinh]) VALUES (N'0989297790', N'Huỳnh Thế Lân', CAST(N'2023-12-03' AS Date))
SET IDENTITY_INSERT [dbo].[PHIEUDK] ON 

INSERT [dbo].[PHIEUDK] ([SoPhieu], [MaKH], [Bienso], [Ngaydk]) VALUES (1, N'090456178', N'63K-08410', CAST(N'2023-12-05' AS Date))
INSERT [dbo].[PHIEUDK] ([SoPhieu], [MaKH], [Bienso], [Ngaydk]) VALUES (2, N'090456178', N'63K-04820', CAST(N'2023-12-05' AS Date))
INSERT [dbo].[PHIEUDK] ([SoPhieu], [MaKH], [Bienso], [Ngaydk]) VALUES (3, N'090456178', N'63K-16543', CAST(N'2023-12-05' AS Date))
INSERT [dbo].[PHIEUDK] ([SoPhieu], [MaKH], [Bienso], [Ngaydk]) VALUES (4, N'0989297790', N'63K-04789', CAST(N'2023-12-05' AS Date))
INSERT [dbo].[PHIEUDK] ([SoPhieu], [MaKH], [Bienso], [Ngaydk]) VALUES (5, N'0989297790', N'63K-04654', CAST(N'2023-12-05' AS Date))
INSERT [dbo].[PHIEUDK] ([SoPhieu], [MaKH], [Bienso], [Ngaydk]) VALUES (6, N'090456178', N'63K-08410', CAST(N'2023-12-05' AS Date))
INSERT [dbo].[PHIEUDK] ([SoPhieu], [MaKH], [Bienso], [Ngaydk]) VALUES (7, N'090456178', N'63K-08410', CAST(N'2023-12-05' AS Date))
INSERT [dbo].[PHIEUDK] ([SoPhieu], [MaKH], [Bienso], [Ngaydk]) VALUES (8, N'090456178', N'63K-08410', CAST(N'2023-12-05' AS Date))
SET IDENTITY_INSERT [dbo].[PHIEUDK] OFF
INSERT [dbo].[XE] ([Bienso], [Ngayhethan], [MaKH], [Hinh]) VALUES (N'63K-04654', CAST(N'2023-04-08' AS Date), N'0989297790', NULL)
INSERT [dbo].[XE] ([Bienso], [Ngayhethan], [MaKH], [Hinh]) VALUES (N'63K-04789', CAST(N'2023-06-08' AS Date), N'0989297790', NULL)
INSERT [dbo].[XE] ([Bienso], [Ngayhethan], [MaKH], [Hinh]) VALUES (N'63K-04820', CAST(N'2023-05-08' AS Date), N'090456178', NULL)
INSERT [dbo].[XE] ([Bienso], [Ngayhethan], [MaKH], [Hinh]) VALUES (N'63K-08410', CAST(N'2023-05-08' AS Date), N'090456178', NULL)
INSERT [dbo].[XE] ([Bienso], [Ngayhethan], [MaKH], [Hinh]) VALUES (N'63K-16543', CAST(N'2023-05-08' AS Date), N'090456178', NULL)
INSERT [dbo].[XE] ([Bienso], [Ngayhethan], [MaKH], [Hinh]) VALUES (N'63K-23456', CAST(N'2023-07-08' AS Date), N'0989297790', NULL)
INSERT [dbo].[XE] ([Bienso], [Ngayhethan], [MaKH], [Hinh]) VALUES (N'63K-45423', CAST(N'2023-05-08' AS Date), N'039245678', NULL)
INSERT [dbo].[XE] ([Bienso], [Ngayhethan], [MaKH], [Hinh]) VALUES (N'63K-45520', CAST(N'2023-05-08' AS Date), N'039245678', NULL)
ALTER TABLE [dbo].[PHIEUDK]  WITH CHECK ADD FOREIGN KEY([Bienso])
REFERENCES [dbo].[XE] ([Bienso])
GO
ALTER TABLE [dbo].[PHIEUDK]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[XE]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
select * FROM XE
select Bienso, Ngayhethan, MaKH from Xe
select P.SoPhieu, H.Hoten, H.MaKH, P.Ngaydk FROM PHIEUDK P, KHACHHANG H where P.MaKH = H.MaKH and Bienso like'63K-16543%' 
Delete From XE where Bienso='63K-04654'
Update XE set Ngayhethan='04/12/2025',MaKH='0989297790'
where Bienso='63K-08410'