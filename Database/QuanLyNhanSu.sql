USE [QuanLyNhanSu]
GO
/****** Object:  Table [dbo].[tb_ChucVu]    Script Date: 5/17/2024 4:20:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_ChucVu](
	[MachucVu] [int] IDENTITY(1,1) NOT NULL,
	[Ten_ChucVu] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tb_ChucVu_1] PRIMARY KEY CLUSTERED 
(
	[MachucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_HopDongLaoDong]    Script Date: 5/17/2024 4:20:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_HopDongLaoDong](
	[HopDongLaoDong] [int] IDENTITY(1,1) NOT NULL,
	[LoaiHopDong] [nvarchar](255) NULL,
	[TuNgay] [date] NULL,
	[DenNgay] [date] NULL,
 CONSTRAINT [PK_tb_HopDongLaoDong] PRIMARY KEY CLUSTERED 
(
	[HopDongLaoDong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_NhanVien]    Script Date: 5/17/2024 4:20:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_NhanVien](
	[MaNV] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](255) NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[QueQuan] [nvarchar](255) NULL,
	[NgaySinh] [datetime] NULL,
	[SoDienThoai] [varchar](50) NULL,
	[MachucVu] [int] NOT NULL,
	[MaPB] [int] NOT NULL,
	[TrinhDoHocVan] [nvarchar](255) NULL,
	[PhongBan] [varchar](50) NULL,
	[HopDongLaoDong] [int] NOT NULL,
	[MaTDHV] [int] NOT NULL,
	[ChuyenNganh] [nvarchar](255) NULL,
 CONSTRAINT [PK_tb_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_NhanVien_ChucVu]    Script Date: 5/17/2024 4:20:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_NhanVien_ChucVu](
	[ChucVu_MachucVu] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](250) NULL,
 CONSTRAINT [PK_tb_NhanVien_ChucVu_1] PRIMARY KEY CLUSTERED 
(
	[ChucVu_MachucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_PhongBan]    Script Date: 5/17/2024 4:20:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_PhongBan](
	[MaPB] [int] IDENTITY(1,1) NOT NULL,
	[TenPB] [nvarchar](250) NULL,
	[DiaChi] [nvarchar](250) NULL,
 CONSTRAINT [PK_tb_PhongBan] PRIMARY KEY CLUSTERED 
(
	[MaPB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_QuanLyChamCong]    Script Date: 5/17/2024 4:20:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_QuanLyChamCong](
	[MANV] [int] NOT NULL,
	[HoTen] [nvarchar](255) NULL,
	[NgayChamCong] [date] NULL,
	[Có] [bit] NULL,
	[Vắng] [bit] NULL,
 CONSTRAINT [PK_tb_QuanLyChamCong] PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_QuanLyLuong]    Script Date: 5/17/2024 4:20:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_QuanLyLuong](
	[MANV] [int] NOT NULL,
	[HoTen] [nvarchar](255) NULL,
	[MaChucVu] [int] NULL,
	[ChucVu] [nvarchar](255) NULL,
	[SoTienLuong] [varchar](max) NULL,
	[NgayNhanLuong] [date] NULL,
 CONSTRAINT [PK_tb_QuanLyLuong] PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_TaiKhoan]    Script Date: 5/17/2024 4:20:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_TaiKhoan](
	[MaNV] [int] NOT NULL,
	[TenTaiKhoan] [varchar](50) NULL,
	[MatKhau] [varchar](50) NULL,
 CONSTRAINT [PK_tb_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_TrinhDoHocVan]    Script Date: 5/17/2024 4:20:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_TrinhDoHocVan](
	[MaTDHV] [int] IDENTITY(1,1) NOT NULL,
	[TrinhDoHocVan] [nvarchar](255) NULL,
	[ChuyenNganh] [nvarchar](255) NULL,
 CONSTRAINT [PK_tb_TrinhDoHocVan] PRIMARY KEY CLUSTERED 
(
	[MaTDHV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tb_ChucVu] ON 

INSERT [dbo].[tb_ChucVu] ([MachucVu], [Ten_ChucVu]) VALUES (1, N'Nhân Viên')
INSERT [dbo].[tb_ChucVu] ([MachucVu], [Ten_ChucVu]) VALUES (2, N'Trưởng Phòng')
INSERT [dbo].[tb_ChucVu] ([MachucVu], [Ten_ChucVu]) VALUES (3, N'Trưởng Phòng')
INSERT [dbo].[tb_ChucVu] ([MachucVu], [Ten_ChucVu]) VALUES (4, N'Phó phòng')
INSERT [dbo].[tb_ChucVu] ([MachucVu], [Ten_ChucVu]) VALUES (5, N'Nhân viên')
INSERT [dbo].[tb_ChucVu] ([MachucVu], [Ten_ChucVu]) VALUES (6, N'Kế Toán')
INSERT [dbo].[tb_ChucVu] ([MachucVu], [Ten_ChucVu]) VALUES (7, N'Thủ Kho')
INSERT [dbo].[tb_ChucVu] ([MachucVu], [Ten_ChucVu]) VALUES (8, N'Kỹ Thuật Viên')
INSERT [dbo].[tb_ChucVu] ([MachucVu], [Ten_ChucVu]) VALUES (9, N'Lễ Tân')
INSERT [dbo].[tb_ChucVu] ([MachucVu], [Ten_ChucVu]) VALUES (10, N'Bảo vệ')
INSERT [dbo].[tb_ChucVu] ([MachucVu], [Ten_ChucVu]) VALUES (11, N'Bán hàng')
INSERT [dbo].[tb_ChucVu] ([MachucVu], [Ten_ChucVu]) VALUES (12, N'Marketing')
INSERT [dbo].[tb_ChucVu] ([MachucVu], [Ten_ChucVu]) VALUES (13, N'IT')
INSERT [dbo].[tb_ChucVu] ([MachucVu], [Ten_ChucVu]) VALUES (14, N'Hành chính')
INSERT [dbo].[tb_ChucVu] ([MachucVu], [Ten_ChucVu]) VALUES (15, N'Nhân sự')
INSERT [dbo].[tb_ChucVu] ([MachucVu], [Ten_ChucVu]) VALUES (16, N'Giao Dịch Viên')
INSERT [dbo].[tb_ChucVu] ([MachucVu], [Ten_ChucVu]) VALUES (17, N'Sale')
INSERT [dbo].[tb_ChucVu] ([MachucVu], [Ten_ChucVu]) VALUES (18, N'Mật Vụ')
INSERT [dbo].[tb_ChucVu] ([MachucVu], [Ten_ChucVu]) VALUES (19, N'Bí Thư')
INSERT [dbo].[tb_ChucVu] ([MachucVu], [Ten_ChucVu]) VALUES (20, N'Streammer')
INSERT [dbo].[tb_ChucVu] ([MachucVu], [Ten_ChucVu]) VALUES (21, N'Giám Đốc')
INSERT [dbo].[tb_ChucVu] ([MachucVu], [Ten_ChucVu]) VALUES (22, N'Trưởng Phòng')
INSERT [dbo].[tb_ChucVu] ([MachucVu], [Ten_ChucVu]) VALUES (23, N'Nhân Viên')
INSERT [dbo].[tb_ChucVu] ([MachucVu], [Ten_ChucVu]) VALUES (24, N'Nhân Viên Bảo Mật')
INSERT [dbo].[tb_ChucVu] ([MachucVu], [Ten_ChucVu]) VALUES (25, N'Giáo Viên')
INSERT [dbo].[tb_ChucVu] ([MachucVu], [Ten_ChucVu]) VALUES (26, N'Kỹ Sư')
INSERT [dbo].[tb_ChucVu] ([MachucVu], [Ten_ChucVu]) VALUES (27, N'Saleer')
SET IDENTITY_INSERT [dbo].[tb_ChucVu] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_HopDongLaoDong] ON 

INSERT [dbo].[tb_HopDongLaoDong] ([HopDongLaoDong], [LoaiHopDong], [TuNgay], [DenNgay]) VALUES (6, N'Mua Nhà', CAST(N'2012-01-09' AS Date), CAST(N'2012-02-01' AS Date))
INSERT [dbo].[tb_HopDongLaoDong] ([HopDongLaoDong], [LoaiHopDong], [TuNgay], [DenNgay]) VALUES (7, N'Mua Vàng', CAST(N'2019-01-02' AS Date), CAST(N'2029-09-09' AS Date))
INSERT [dbo].[tb_HopDongLaoDong] ([HopDongLaoDong], [LoaiHopDong], [TuNgay], [DenNgay]) VALUES (10, N'Hợp Đồng Xây NHà', CAST(N'2011-01-01' AS Date), CAST(N'2021-01-01' AS Date))
INSERT [dbo].[tb_HopDongLaoDong] ([HopDongLaoDong], [LoaiHopDong], [TuNgay], [DenNgay]) VALUES (11, N'Hợp Đồng Mua Sim', CAST(N'2022-01-01' AS Date), CAST(N'2032-01-01' AS Date))
INSERT [dbo].[tb_HopDongLaoDong] ([HopDongLaoDong], [LoaiHopDong], [TuNgay], [DenNgay]) VALUES (12, N'Mua Nhà', CAST(N'2023-01-09' AS Date), CAST(N'2023-02-01' AS Date))
INSERT [dbo].[tb_HopDongLaoDong] ([HopDongLaoDong], [LoaiHopDong], [TuNgay], [DenNgay]) VALUES (13, N'Mua Đất', CAST(N'2024-01-02' AS Date), CAST(N'2024-09-09' AS Date))
INSERT [dbo].[tb_HopDongLaoDong] ([HopDongLaoDong], [LoaiHopDong], [TuNgay], [DenNgay]) VALUES (14, N'Thuê Nhà', CAST(N'2025-01-01' AS Date), CAST(N'2026-01-01' AS Date))
INSERT [dbo].[tb_HopDongLaoDong] ([HopDongLaoDong], [LoaiHopDong], [TuNgay], [DenNgay]) VALUES (15, N'Thuê Xe', CAST(N'2026-01-09' AS Date), CAST(N'2026-02-01' AS Date))
INSERT [dbo].[tb_HopDongLaoDong] ([HopDongLaoDong], [LoaiHopDong], [TuNgay], [DenNgay]) VALUES (16, N'Hợp Đồng Cung Cấp Dịch Vụ', CAST(N'2027-01-02' AS Date), CAST(N'2027-09-09' AS Date))
INSERT [dbo].[tb_HopDongLaoDong] ([HopDongLaoDong], [LoaiHopDong], [TuNgay], [DenNgay]) VALUES (17, N'Hợp Đồng Thương Mại', CAST(N'2028-01-01' AS Date), CAST(N'2029-01-01' AS Date))
INSERT [dbo].[tb_HopDongLaoDong] ([HopDongLaoDong], [LoaiHopDong], [TuNgay], [DenNgay]) VALUES (18, N'Hợp Đồng Đầu Tư', CAST(N'2029-01-09' AS Date), CAST(N'2029-02-01' AS Date))
INSERT [dbo].[tb_HopDongLaoDong] ([HopDongLaoDong], [LoaiHopDong], [TuNgay], [DenNgay]) VALUES (19, N'Hợp Đồng Liên Doanh', CAST(N'2030-01-02' AS Date), CAST(N'2030-09-09' AS Date))
INSERT [dbo].[tb_HopDongLaoDong] ([HopDongLaoDong], [LoaiHopDong], [TuNgay], [DenNgay]) VALUES (20, N'Hợp Đồng Hôn Nhân', CAST(N'2031-01-01' AS Date), CAST(N'2032-01-01' AS Date))
INSERT [dbo].[tb_HopDongLaoDong] ([HopDongLaoDong], [LoaiHopDong], [TuNgay], [DenNgay]) VALUES (21, N'Hợp Đồng Bảo Hiểm', CAST(N'2032-01-09' AS Date), CAST(N'2032-02-01' AS Date))
INSERT [dbo].[tb_HopDongLaoDong] ([HopDongLaoDong], [LoaiHopDong], [TuNgay], [DenNgay]) VALUES (22, N'Hợp Đồng Tín Dụng', CAST(N'2033-01-02' AS Date), CAST(N'2033-09-09' AS Date))
INSERT [dbo].[tb_HopDongLaoDong] ([HopDongLaoDong], [LoaiHopDong], [TuNgay], [DenNgay]) VALUES (23, N'Hợp Đồng Ủy Thác', CAST(N'2034-01-01' AS Date), CAST(N'2035-01-01' AS Date))
INSERT [dbo].[tb_HopDongLaoDong] ([HopDongLaoDong], [LoaiHopDong], [TuNgay], [DenNgay]) VALUES (24, N'Hợp Đồng Giải Phóng Tự Do', CAST(N'2035-01-09' AS Date), CAST(N'2035-02-01' AS Date))
INSERT [dbo].[tb_HopDongLaoDong] ([HopDongLaoDong], [LoaiHopDong], [TuNgay], [DenNgay]) VALUES (25, N'Hợp Đồng Thuê Máy Móc', CAST(N'2036-01-02' AS Date), CAST(N'2036-09-09' AS Date))
INSERT [dbo].[tb_HopDongLaoDong] ([HopDongLaoDong], [LoaiHopDong], [TuNgay], [DenNgay]) VALUES (26, N'Mua Xe', CAST(N'2023-02-01' AS Date), CAST(N'2023-06-02' AS Date))
INSERT [dbo].[tb_HopDongLaoDong] ([HopDongLaoDong], [LoaiHopDong], [TuNgay], [DenNgay]) VALUES (27, N'Mua Bitcoin', CAST(N'2023-02-01' AS Date), CAST(N'2023-02-01' AS Date))
INSERT [dbo].[tb_HopDongLaoDong] ([HopDongLaoDong], [LoaiHopDong], [TuNgay], [DenNgay]) VALUES (28, N'Mua Tivi', CAST(N'2024-05-04' AS Date), CAST(N'2024-05-04' AS Date))
INSERT [dbo].[tb_HopDongLaoDong] ([HopDongLaoDong], [LoaiHopDong], [TuNgay], [DenNgay]) VALUES (29, N'Mua Sim Số Đẹp', CAST(N'2024-05-06' AS Date), CAST(N'2024-05-06' AS Date))
INSERT [dbo].[tb_HopDongLaoDong] ([HopDongLaoDong], [LoaiHopDong], [TuNgay], [DenNgay]) VALUES (30, N'Mua Xe Phân Khối Lớn', CAST(N'2027-10-22' AS Date), CAST(N'2027-10-22' AS Date))
INSERT [dbo].[tb_HopDongLaoDong] ([HopDongLaoDong], [LoaiHopDong], [TuNgay], [DenNgay]) VALUES (31, N'Kí Gửi Hàng Hiệu', CAST(N'2028-01-11' AS Date), CAST(N'2028-01-11' AS Date))
INSERT [dbo].[tb_HopDongLaoDong] ([HopDongLaoDong], [LoaiHopDong], [TuNgay], [DenNgay]) VALUES (32, N'Mua Đất', CAST(N'2024-01-11' AS Date), CAST(N'2028-01-11' AS Date))
INSERT [dbo].[tb_HopDongLaoDong] ([HopDongLaoDong], [LoaiHopDong], [TuNgay], [DenNgay]) VALUES (33, N'Mua Sim Số Đẹp', CAST(N'2024-01-11' AS Date), CAST(N'2030-01-11' AS Date))
SET IDENTITY_INSERT [dbo].[tb_HopDongLaoDong] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_NhanVien] ON 

INSERT [dbo].[tb_NhanVien] ([MaNV], [HoTen], [GioiTinh], [QueQuan], [NgaySinh], [SoDienThoai], [MachucVu], [MaPB], [TrinhDoHocVan], [PhongBan], [HopDongLaoDong], [MaTDHV], [ChuyenNganh]) VALUES (1, N'Trần Thị A', N'Nữ', N'Vinh City', CAST(N'2024-05-05T00:00:00.000' AS DateTime), N'0923954046', 2, 906, N'Sơ Cấp I', N'A2b3', 7, 11, N'Kinh tế')
INSERT [dbo].[tb_NhanVien] ([MaNV], [HoTen], [GioiTinh], [QueQuan], [NgaySinh], [SoDienThoai], [MachucVu], [MaPB], [TrinhDoHocVan], [PhongBan], [HopDongLaoDong], [MaTDHV], [ChuyenNganh]) VALUES (2, N'Lê Ánh', N'Nữ', N'Bắc Ninh', CAST(N'2024-05-05T00:00:00.000' AS DateTime), N'0927927927', 3, 907, N'Cao Đẳng', N'A2b3', 6, 12, N'Kế Toán')
INSERT [dbo].[tb_NhanVien] ([MaNV], [HoTen], [GioiTinh], [QueQuan], [NgaySinh], [SoDienThoai], [MachucVu], [MaPB], [TrinhDoHocVan], [PhongBan], [HopDongLaoDong], [MaTDHV], [ChuyenNganh]) VALUES (6, N'Lê Quốc An', N'Nam', N'Sài Gòn', CAST(N'2024-05-05T00:00:00.000' AS DateTime), N'0927927927', 4, 908, N'Cao Đẳng', N'A2b3', 10, 13, N'Dược Sĩ')
INSERT [dbo].[tb_NhanVien] ([MaNV], [HoTen], [GioiTinh], [QueQuan], [NgaySinh], [SoDienThoai], [MachucVu], [MaPB], [TrinhDoHocVan], [PhongBan], [HopDongLaoDong], [MaTDHV], [ChuyenNganh]) VALUES (7, N'Trần Văn Quang', N'Nam', N'Ba Đình Hà Nội', CAST(N'2024-05-05T00:00:00.000' AS DateTime), N'0927927927', 4, 908, N'Cao Đẳng', N'A2b3', 10, 13, N'QPAN')
INSERT [dbo].[tb_NhanVien] ([MaNV], [HoTen], [GioiTinh], [QueQuan], [NgaySinh], [SoDienThoai], [MachucVu], [MaPB], [TrinhDoHocVan], [PhongBan], [HopDongLaoDong], [MaTDHV], [ChuyenNganh]) VALUES (8, N'Anh Đức', N'Nam', N'Nghệ An', CAST(N'2024-05-06T00:00:00.000' AS DateTime), N'0878290704', 5, 909, N'Cao Đẳng', N'B1201', 6, 14, N'Thú y')
INSERT [dbo].[tb_NhanVien] ([MaNV], [HoTen], [GioiTinh], [QueQuan], [NgaySinh], [SoDienThoai], [MachucVu], [MaPB], [TrinhDoHocVan], [PhongBan], [HopDongLaoDong], [MaTDHV], [ChuyenNganh]) VALUES (10, N'Mạnh Quân', N'Nam', N'Đức Thọ Hà Tĩnh', CAST(N'2005-01-01T00:00:00.000' AS DateTime), N'09787878', 6, 910, N'Trung Cấp', N'A2b03', 11, 15, N'Điện Điện Tử')
INSERT [dbo].[tb_NhanVien] ([MaNV], [HoTen], [GioiTinh], [QueQuan], [NgaySinh], [SoDienThoai], [MachucVu], [MaPB], [TrinhDoHocVan], [PhongBan], [HopDongLaoDong], [MaTDHV], [ChuyenNganh]) VALUES (11, N'Đặng Thị Hải Quý', N'Nữ', N'Nghi Xuân Hà Tĩnh', CAST(N'2004-02-03T00:00:00.000' AS DateTime), N'0776258909', 7, 911, N'Đại Học', N'A2102', 12, 16, N'Công Nghệ Thông Tin')
INSERT [dbo].[tb_NhanVien] ([MaNV], [HoTen], [GioiTinh], [QueQuan], [NgaySinh], [SoDienThoai], [MachucVu], [MaPB], [TrinhDoHocVan], [PhongBan], [HopDongLaoDong], [MaTDHV], [ChuyenNganh]) VALUES (12, N'Đặng Thị Hải Lê', N'Nữ', N'Nghi Xuân Hà Tĩnh', CAST(N'1995-01-01T00:00:00.000' AS DateTime), N'0776258909', 8, 912, N'Đại Học', N'A2101', 13, 17, N'Kế Toán')
INSERT [dbo].[tb_NhanVien] ([MaNV], [HoTen], [GioiTinh], [QueQuan], [NgaySinh], [SoDienThoai], [MachucVu], [MaPB], [TrinhDoHocVan], [PhongBan], [HopDongLaoDong], [MaTDHV], [ChuyenNganh]) VALUES (13, N'Lê Ánh Đức', N'Nữ', N'Nghi Xuân Hà Tĩnh', CAST(N'2000-01-01T00:00:00.000' AS DateTime), N'0776258908', 9, 913, N'Đại Học', N'A2101', 14, 18, N'Kế Toán')
INSERT [dbo].[tb_NhanVien] ([MaNV], [HoTen], [GioiTinh], [QueQuan], [NgaySinh], [SoDienThoai], [MachucVu], [MaPB], [TrinhDoHocVan], [PhongBan], [HopDongLaoDong], [MaTDHV], [ChuyenNganh]) VALUES (15, N'Trần Đức', N'Nam', N'Nam Đàn', CAST(N'2019-07-01T00:00:00.000' AS DateTime), N'0923923924', 10, 914, N'Thạc Sĩ', N'B2401', 15, 19, N'Điện Lạnh')
INSERT [dbo].[tb_NhanVien] ([MaNV], [HoTen], [GioiTinh], [QueQuan], [NgaySinh], [SoDienThoai], [MachucVu], [MaPB], [TrinhDoHocVan], [PhongBan], [HopDongLaoDong], [MaTDHV], [ChuyenNganh]) VALUES (16, N'Hoàng Ánh', N'Nữ', N'Con Cuông Nghệ An', CAST(N'2003-02-11T00:00:00.000' AS DateTime), N'0949949949', 11, 915, N'Đại Học', N'B2401', 16, 20, N'Kế Toán')
INSERT [dbo].[tb_NhanVien] ([MaNV], [HoTen], [GioiTinh], [QueQuan], [NgaySinh], [SoDienThoai], [MachucVu], [MaPB], [TrinhDoHocVan], [PhongBan], [HopDongLaoDong], [MaTDHV], [ChuyenNganh]) VALUES (18, N'Lê Anh Bằng', N'Nam', N'Hương Khê Hà Tĩnh', CAST(N'2003-01-10T00:00:00.000' AS DateTime), N'09230923923', 12, 916, N'Sơ Cấp II', N'B2A21', 17, 21, N'Công Nghệ Thông Tin CLC')
INSERT [dbo].[tb_NhanVien] ([MaNV], [HoTen], [GioiTinh], [QueQuan], [NgaySinh], [SoDienThoai], [MachucVu], [MaPB], [TrinhDoHocVan], [PhongBan], [HopDongLaoDong], [MaTDHV], [ChuyenNganh]) VALUES (19, N'Ánh Ngọc', N'Nữ', N'Hà Tĩnh', CAST(N'2000-01-01T00:00:00.000' AS DateTime), N'0949542004', 13, 917, N'Cao Đẳng', N'B2301', 18, 22, N'Kế Toán ')
INSERT [dbo].[tb_NhanVien] ([MaNV], [HoTen], [GioiTinh], [QueQuan], [NgaySinh], [SoDienThoai], [MachucVu], [MaPB], [TrinhDoHocVan], [PhongBan], [HopDongLaoDong], [MaTDHV], [ChuyenNganh]) VALUES (20, N'Hưng Nguyễn', N'Nam', N'Hưng Đông Nghệ An', CAST(N'1992-06-28T00:00:00.000' AS DateTime), N'0978787878', 14, 918, N'Thạc Sĩ', N'A3403', 19, 23, N'Điện Dân Dụng')
INSERT [dbo].[tb_NhanVien] ([MaNV], [HoTen], [GioiTinh], [QueQuan], [NgaySinh], [SoDienThoai], [MachucVu], [MaPB], [TrinhDoHocVan], [PhongBan], [HopDongLaoDong], [MaTDHV], [ChuyenNganh]) VALUES (21, N'Trần Văn D', N'Nam', N'Ba Đình Hà Nội', CAST(N'2004-01-05T00:00:00.000' AS DateTime), N'0927927927', 15, 919, N'Đại Học', N'A1b3', 20, 24, N'kỹ Thuật Phần Mềm')
INSERT [dbo].[tb_NhanVien] ([MaNV], [HoTen], [GioiTinh], [QueQuan], [NgaySinh], [SoDienThoai], [MachucVu], [MaPB], [TrinhDoHocVan], [PhongBan], [HopDongLaoDong], [MaTDHV], [ChuyenNganh]) VALUES (22, N'Lê Ánh', N'Nữ', N'Quảng Nam', CAST(N'2005-01-05T00:00:00.000' AS DateTime), N'0962626262', 16, 920, N'Cao Đẳng', N'A2b3', 21, 25, N'Kế Toán')
INSERT [dbo].[tb_NhanVien] ([MaNV], [HoTen], [GioiTinh], [QueQuan], [NgaySinh], [SoDienThoai], [MachucVu], [MaPB], [TrinhDoHocVan], [PhongBan], [HopDongLaoDong], [MaTDHV], [ChuyenNganh]) VALUES (24, N'Hoàng An', N'Nữ', N'Diễn Châu Nghệ An', CAST(N'1997-01-05T00:00:00.000' AS DateTime), N'0923954046', 17, 922, N'Tiến Sĩ', N'A2b21', 22, 26, N'Digital Maketting')
INSERT [dbo].[tb_NhanVien] ([MaNV], [HoTen], [GioiTinh], [QueQuan], [NgaySinh], [SoDienThoai], [MachucVu], [MaPB], [TrinhDoHocVan], [PhongBan], [HopDongLaoDong], [MaTDHV], [ChuyenNganh]) VALUES (1024, N'Lê Ánh Đức', N'Nam', N'Vinh Nghệ An', CAST(N'1992-01-15T00:00:00.000' AS DateTime), N'0923456789', 18, 923, N'Thạc Sĩ', N'A2b01', 23, 29, N'Ngân Hàng')
SET IDENTITY_INSERT [dbo].[tb_NhanVien] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_NhanVien_ChucVu] ON 

INSERT [dbo].[tb_NhanVien_ChucVu] ([ChucVu_MachucVu], [HoTen]) VALUES (1, N'Phan Văn Đức')
INSERT [dbo].[tb_NhanVien_ChucVu] ([ChucVu_MachucVu], [HoTen]) VALUES (2, N'Lê Mạnh Huy')
INSERT [dbo].[tb_NhanVien_ChucVu] ([ChucVu_MachucVu], [HoTen]) VALUES (3, N'Trần Mạnh')
INSERT [dbo].[tb_NhanVien_ChucVu] ([ChucVu_MachucVu], [HoTen]) VALUES (4, N'Trần Linh')
INSERT [dbo].[tb_NhanVien_ChucVu] ([ChucVu_MachucVu], [HoTen]) VALUES (5, N'Đức Tiến')
INSERT [dbo].[tb_NhanVien_ChucVu] ([ChucVu_MachucVu], [HoTen]) VALUES (6, N'Quang Hải')
INSERT [dbo].[tb_NhanVien_ChucVu] ([ChucVu_MachucVu], [HoTen]) VALUES (7, N'Lê Bình')
INSERT [dbo].[tb_NhanVien_ChucVu] ([ChucVu_MachucVu], [HoTen]) VALUES (8, N'Lê Minh Tiến')
INSERT [dbo].[tb_NhanVien_ChucVu] ([ChucVu_MachucVu], [HoTen]) VALUES (9, N'Hải Lý')
INSERT [dbo].[tb_NhanVien_ChucVu] ([ChucVu_MachucVu], [HoTen]) VALUES (10, N'Đặng Hải Lê')
INSERT [dbo].[tb_NhanVien_ChucVu] ([ChucVu_MachucVu], [HoTen]) VALUES (11, N'Đặng Hải Quý')
INSERT [dbo].[tb_NhanVien_ChucVu] ([ChucVu_MachucVu], [HoTen]) VALUES (12, N'Bảo Quốc')
INSERT [dbo].[tb_NhanVien_ChucVu] ([ChucVu_MachucVu], [HoTen]) VALUES (13, N'Bình Mạnh')
INSERT [dbo].[tb_NhanVien_ChucVu] ([ChucVu_MachucVu], [HoTen]) VALUES (14, N'Thiện Đức')
INSERT [dbo].[tb_NhanVien_ChucVu] ([ChucVu_MachucVu], [HoTen]) VALUES (15, N'Bảo Hoàn')
INSERT [dbo].[tb_NhanVien_ChucVu] ([ChucVu_MachucVu], [HoTen]) VALUES (16, N'Phan Văn Anh')
INSERT [dbo].[tb_NhanVien_ChucVu] ([ChucVu_MachucVu], [HoTen]) VALUES (17, N'Đặng Thị Hải Quý')
INSERT [dbo].[tb_NhanVien_ChucVu] ([ChucVu_MachucVu], [HoTen]) VALUES (18, N'Ninh NQ')
INSERT [dbo].[tb_NhanVien_ChucVu] ([ChucVu_MachucVu], [HoTen]) VALUES (19, N'Lê Bảo')
INSERT [dbo].[tb_NhanVien_ChucVu] ([ChucVu_MachucVu], [HoTen]) VALUES (20, N'Lê Đức Anh')
INSERT [dbo].[tb_NhanVien_ChucVu] ([ChucVu_MachucVu], [HoTen]) VALUES (21, N'Hải Ánh')
INSERT [dbo].[tb_NhanVien_ChucVu] ([ChucVu_MachucVu], [HoTen]) VALUES (22, N'Lê Văn Bằng')
INSERT [dbo].[tb_NhanVien_ChucVu] ([ChucVu_MachucVu], [HoTen]) VALUES (23, N'Lê Văn Ánh')
INSERT [dbo].[tb_NhanVien_ChucVu] ([ChucVu_MachucVu], [HoTen]) VALUES (24, N'Quang Đạt')
INSERT [dbo].[tb_NhanVien_ChucVu] ([ChucVu_MachucVu], [HoTen]) VALUES (26, N'Hải Anh')
SET IDENTITY_INSERT [dbo].[tb_NhanVien_ChucVu] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_PhongBan] ON 

INSERT [dbo].[tb_PhongBan] ([MaPB], [TenPB], [DiaChi]) VALUES (901, N'Phòng họp', N'Đại Học Vinh')
INSERT [dbo].[tb_PhongBan] ([MaPB], [TenPB], [DiaChi]) VALUES (902, N'Nhà Hát', N'Đại Học Vinh')
INSERT [dbo].[tb_PhongBan] ([MaPB], [TenPB], [DiaChi]) VALUES (903, N'Phòng Đa Năng', N'Cao Đẳng Y Nghệ An')
INSERT [dbo].[tb_PhongBan] ([MaPB], [TenPB], [DiaChi]) VALUES (904, N'Phòng Phát Triển Phần Mềm', N'Đại Học Vinh')
INSERT [dbo].[tb_PhongBan] ([MaPB], [TenPB], [DiaChi]) VALUES (905, N'Phòng Thiết Kế', N'Đại Học Vinh')
INSERT [dbo].[tb_PhongBan] ([MaPB], [TenPB], [DiaChi]) VALUES (906, N'Phòng Marketing', N'Đại Học Vinh')
INSERT [dbo].[tb_PhongBan] ([MaPB], [TenPB], [DiaChi]) VALUES (907, N'Phòng B2', N'Đại Học Vinh')
INSERT [dbo].[tb_PhongBan] ([MaPB], [TenPB], [DiaChi]) VALUES (908, N'Phòng Tài Chính Kế Toán', N'Đại Học Vinh')
INSERT [dbo].[tb_PhongBan] ([MaPB], [TenPB], [DiaChi]) VALUES (909, N'Phòng Hành Chính', N'Đại Học Vinh')
INSERT [dbo].[tb_PhongBan] ([MaPB], [TenPB], [DiaChi]) VALUES (910, N'Phòng Bảo Vệ', N'Đại Học Vinh')
INSERT [dbo].[tb_PhongBan] ([MaPB], [TenPB], [DiaChi]) VALUES (911, N'Phòng Y Tế', N'Đại Học Vinh')
INSERT [dbo].[tb_PhongBan] ([MaPB], [TenPB], [DiaChi]) VALUES (912, N'Phòng Thư Viện', N'Đại Học Vinh')
INSERT [dbo].[tb_PhongBan] ([MaPB], [TenPB], [DiaChi]) VALUES (913, N'Phòng Giảng Viên', N'Đại Học Vinh')
INSERT [dbo].[tb_PhongBan] ([MaPB], [TenPB], [DiaChi]) VALUES (914, N'Phòng Sinh Viên', N'Đại Học Vinh')
INSERT [dbo].[tb_PhongBan] ([MaPB], [TenPB], [DiaChi]) VALUES (915, N'Phòng Nghiên Cứu', N'Đại Học Vinh')
INSERT [dbo].[tb_PhongBan] ([MaPB], [TenPB], [DiaChi]) VALUES (916, N'Phòng Hợp Tác Quốc Tế', N'Đại Học Vinh')
INSERT [dbo].[tb_PhongBan] ([MaPB], [TenPB], [DiaChi]) VALUES (917, N'Phòng Công Tác Sinh Viên', N'Đại Học Vinh')
INSERT [dbo].[tb_PhongBan] ([MaPB], [TenPB], [DiaChi]) VALUES (918, N'Phòng Tuyển Sinh', N'Đại Học Vinh')
INSERT [dbo].[tb_PhongBan] ([MaPB], [TenPB], [DiaChi]) VALUES (919, N'Sân Bóng ', N'Nghề Số 4')
INSERT [dbo].[tb_PhongBan] ([MaPB], [TenPB], [DiaChi]) VALUES (920, N'Sân Số 1', N'Kĩ Thuật 3')
INSERT [dbo].[tb_PhongBan] ([MaPB], [TenPB], [DiaChi]) VALUES (922, N'KTCN 502', N'Toà KTCN Đại Học Vinh')
INSERT [dbo].[tb_PhongBan] ([MaPB], [TenPB], [DiaChi]) VALUES (923, N'Sảnh B2', N'Đại Học Vinh')
INSERT [dbo].[tb_PhongBan] ([MaPB], [TenPB], [DiaChi]) VALUES (924, N'Sảnh A0', N'Đại Học Vinh')
INSERT [dbo].[tb_PhongBan] ([MaPB], [TenPB], [DiaChi]) VALUES (925, N'Phòng Cố Vấn Học Tập', N'Đại Học Vinh')
INSERT [dbo].[tb_PhongBan] ([MaPB], [TenPB], [DiaChi]) VALUES (926, N'B', N'đại học vinh')
INSERT [dbo].[tb_PhongBan] ([MaPB], [TenPB], [DiaChi]) VALUES (927, N'H', N'trường kinh tế')
INSERT [dbo].[tb_PhongBan] ([MaPB], [TenPB], [DiaChi]) VALUES (928, N'b2302', N'ktcn đại học vinh')
INSERT [dbo].[tb_PhongBan] ([MaPB], [TenPB], [DiaChi]) VALUES (929, N'hhaha', N'thpt hà huy tập')
SET IDENTITY_INSERT [dbo].[tb_PhongBan] OFF
GO
INSERT [dbo].[tb_QuanLyChamCong] ([MANV], [HoTen], [NgayChamCong], [Có], [Vắng]) VALUES (1, N'Phan Văn Tiến', CAST(N'2024-09-08' AS Date), NULL, NULL)
INSERT [dbo].[tb_QuanLyChamCong] ([MANV], [HoTen], [NgayChamCong], [Có], [Vắng]) VALUES (2, N'Đức Huy', CAST(N'2024-06-05' AS Date), NULL, NULL)
INSERT [dbo].[tb_QuanLyChamCong] ([MANV], [HoTen], [NgayChamCong], [Có], [Vắng]) VALUES (6, N'Anh Tài', CAST(N'2004-01-09' AS Date), NULL, NULL)
INSERT [dbo].[tb_QuanLyChamCong] ([MANV], [HoTen], [NgayChamCong], [Có], [Vắng]) VALUES (7, N'Mạnh Đạt', CAST(N'2024-06-05' AS Date), NULL, NULL)
INSERT [dbo].[tb_QuanLyChamCong] ([MANV], [HoTen], [NgayChamCong], [Có], [Vắng]) VALUES (8, N'Lê Anh Tài', CAST(N'2024-06-05' AS Date), 1, 0)
INSERT [dbo].[tb_QuanLyChamCong] ([MANV], [HoTen], [NgayChamCong], [Có], [Vắng]) VALUES (10, N'Mạnh Quân', CAST(N'2024-05-06' AS Date), 1, 0)
INSERT [dbo].[tb_QuanLyChamCong] ([MANV], [HoTen], [NgayChamCong], [Có], [Vắng]) VALUES (11, N'Đặng Thị Hải Quý', CAST(N'2024-05-06' AS Date), 0, 1)
INSERT [dbo].[tb_QuanLyChamCong] ([MANV], [HoTen], [NgayChamCong], [Có], [Vắng]) VALUES (12, N'Phan Văn Tiến', CAST(N'2024-05-06' AS Date), 1, 0)
INSERT [dbo].[tb_QuanLyChamCong] ([MANV], [HoTen], [NgayChamCong], [Có], [Vắng]) VALUES (13, N'Lê Mạnh Hải', CAST(N'2024-05-07' AS Date), 1, 0)
INSERT [dbo].[tb_QuanLyChamCong] ([MANV], [HoTen], [NgayChamCong], [Có], [Vắng]) VALUES (15, N'Anh Tuan', CAST(N'2024-05-08' AS Date), 1, 0)
INSERT [dbo].[tb_QuanLyChamCong] ([MANV], [HoTen], [NgayChamCong], [Có], [Vắng]) VALUES (16, N'Văn An', CAST(N'2024-05-10' AS Date), 1, 0)
INSERT [dbo].[tb_QuanLyChamCong] ([MANV], [HoTen], [NgayChamCong], [Có], [Vắng]) VALUES (18, N'Lê Anh Hải', CAST(N'2024-05-15' AS Date), 1, 0)
GO
INSERT [dbo].[tb_QuanLyLuong] ([MANV], [HoTen], [MaChucVu], [ChucVu], [SoTienLuong], [NgayNhanLuong]) VALUES (1, N'Hoài Anh', 2, N'Nhân Viên', N'8,500000', CAST(N'2024-09-09' AS Date))
INSERT [dbo].[tb_QuanLyLuong] ([MANV], [HoTen], [MaChucVu], [ChucVu], [SoTienLuong], [NgayNhanLuong]) VALUES (3, N'Phan Văn Tiến', 1, N'Trưởng Phòng', N'9,000,000', CAST(N'2024-05-05' AS Date))
INSERT [dbo].[tb_QuanLyLuong] ([MANV], [HoTen], [MaChucVu], [ChucVu], [SoTienLuong], [NgayNhanLuong]) VALUES (4, N'Phạm Anh Quốc', 5, N'Sếp', N'15,000,000', CAST(N'2024-05-07' AS Date))
INSERT [dbo].[tb_QuanLyLuong] ([MANV], [HoTen], [MaChucVu], [ChucVu], [SoTienLuong], [NgayNhanLuong]) VALUES (6, N'Lê Quốc Anh', 7, N'Nhân Viên', N'20,000,000', CAST(N'2024-05-11' AS Date))
INSERT [dbo].[tb_QuanLyLuong] ([MANV], [HoTen], [MaChucVu], [ChucVu], [SoTienLuong], [NgayNhanLuong]) VALUES (7, N'Quang Hải', 8, N'Sale', N'8,000,000', CAST(N'2024-05-15' AS Date))
GO
INSERT [dbo].[tb_TaiKhoan] ([MaNV], [TenTaiKhoan], [MatKhau]) VALUES (1, N'admin', N'1234')
INSERT [dbo].[tb_TaiKhoan] ([MaNV], [TenTaiKhoan], [MatKhau]) VALUES (2, N'tiendeptrai', N'1234')
INSERT [dbo].[tb_TaiKhoan] ([MaNV], [TenTaiKhoan], [MatKhau]) VALUES (6, N'hello', N'1234')
INSERT [dbo].[tb_TaiKhoan] ([MaNV], [TenTaiKhoan], [MatKhau]) VALUES (7, N'tranhuy', N'20042010tG@')
INSERT [dbo].[tb_TaiKhoan] ([MaNV], [TenTaiKhoan], [MatKhau]) VALUES (8, N'phanvantien297', N'Phanvantien2907@')
INSERT [dbo].[tb_TaiKhoan] ([MaNV], [TenTaiKhoan], [MatKhau]) VALUES (10, N'huyenngok', N'huyen1234')
INSERT [dbo].[tb_TaiKhoan] ([MaNV], [TenTaiKhoan], [MatKhau]) VALUES (11, N'admin1', N'12345')
INSERT [dbo].[tb_TaiKhoan] ([MaNV], [TenTaiKhoan], [MatKhau]) VALUES (12, N'quyanlon', N'12345')
INSERT [dbo].[tb_TaiKhoan] ([MaNV], [TenTaiKhoan], [MatKhau]) VALUES (13, N'quyancut', N'12345')
INSERT [dbo].[tb_TaiKhoan] ([MaNV], [TenTaiKhoan], [MatKhau]) VALUES (15, N'quyngaoda', N'1234')
INSERT [dbo].[tb_TaiKhoan] ([MaNV], [TenTaiKhoan], [MatKhau]) VALUES (16, N'hello1', N'2345')
INSERT [dbo].[tb_TaiKhoan] ([MaNV], [TenTaiKhoan], [MatKhau]) VALUES (18, N'anhquan', N'2345')
INSERT [dbo].[tb_TaiKhoan] ([MaNV], [TenTaiKhoan], [MatKhau]) VALUES (19, N'customer', N'1234')
INSERT [dbo].[tb_TaiKhoan] ([MaNV], [TenTaiKhoan], [MatKhau]) VALUES (20, N'locked', N'tyui')
INSERT [dbo].[tb_TaiKhoan] ([MaNV], [TenTaiKhoan], [MatKhau]) VALUES (21, N'locked1', N'1234')
INSERT [dbo].[tb_TaiKhoan] ([MaNV], [TenTaiKhoan], [MatKhau]) VALUES (22, N'hoanganhle', N'pHanvantien2907@')
GO
SET IDENTITY_INSERT [dbo].[tb_TrinhDoHocVan] ON 

INSERT [dbo].[tb_TrinhDoHocVan] ([MaTDHV], [TrinhDoHocVan], [ChuyenNganh]) VALUES (11, N'Kế Toán', N'Cử Nhân')
INSERT [dbo].[tb_TrinhDoHocVan] ([MaTDHV], [TrinhDoHocVan], [ChuyenNganh]) VALUES (12, N'Thú y', N'Đại Học')
INSERT [dbo].[tb_TrinhDoHocVan] ([MaTDHV], [TrinhDoHocVan], [ChuyenNganh]) VALUES (13, N'Cao Học', N'Công Nghệ Thông Tin')
INSERT [dbo].[tb_TrinhDoHocVan] ([MaTDHV], [TrinhDoHocVan], [ChuyenNganh]) VALUES (14, N'Cao Học', N'Kinh Tế')
INSERT [dbo].[tb_TrinhDoHocVan] ([MaTDHV], [TrinhDoHocVan], [ChuyenNganh]) VALUES (15, N'Luật', N'Đại Học')
INSERT [dbo].[tb_TrinhDoHocVan] ([MaTDHV], [TrinhDoHocVan], [ChuyenNganh]) VALUES (16, N'Cao Học', N'Quản Trị Kinh Doanh')
INSERT [dbo].[tb_TrinhDoHocVan] ([MaTDHV], [TrinhDoHocVan], [ChuyenNganh]) VALUES (17, N'Cao Học', N'Sư Phạm')
INSERT [dbo].[tb_TrinhDoHocVan] ([MaTDHV], [TrinhDoHocVan], [ChuyenNganh]) VALUES (18, N'Đại Học', N'Tin Học')
INSERT [dbo].[tb_TrinhDoHocVan] ([MaTDHV], [TrinhDoHocVan], [ChuyenNganh]) VALUES (19, N'Cao Học', N'Ngoại Ngữ')
INSERT [dbo].[tb_TrinhDoHocVan] ([MaTDHV], [TrinhDoHocVan], [ChuyenNganh]) VALUES (20, N'Cao Học', N'Y khoa')
INSERT [dbo].[tb_TrinhDoHocVan] ([MaTDHV], [TrinhDoHocVan], [ChuyenNganh]) VALUES (21, N'Cao Đẳng', N'Kỹ Thuật')
INSERT [dbo].[tb_TrinhDoHocVan] ([MaTDHV], [TrinhDoHocVan], [ChuyenNganh]) VALUES (22, N'Trung Cấp', N'Nông Nghiệp')
INSERT [dbo].[tb_TrinhDoHocVan] ([MaTDHV], [TrinhDoHocVan], [ChuyenNganh]) VALUES (23, N'Cao Học', N'Ngôn Ngữ Học')
INSERT [dbo].[tb_TrinhDoHocVan] ([MaTDHV], [TrinhDoHocVan], [ChuyenNganh]) VALUES (24, N'Giao Dịch Viên', N'Tiến Sĩ')
INSERT [dbo].[tb_TrinhDoHocVan] ([MaTDHV], [TrinhDoHocVan], [ChuyenNganh]) VALUES (25, N'Điện Lạnh', N'Trung Cấp')
INSERT [dbo].[tb_TrinhDoHocVan] ([MaTDHV], [TrinhDoHocVan], [ChuyenNganh]) VALUES (26, N'Trung Cấp', N'Điện Lạnh')
INSERT [dbo].[tb_TrinhDoHocVan] ([MaTDHV], [TrinhDoHocVan], [ChuyenNganh]) VALUES (29, N'Điện Tử Viễn Thông', N'Đại Học')
INSERT [dbo].[tb_TrinhDoHocVan] ([MaTDHV], [TrinhDoHocVan], [ChuyenNganh]) VALUES (30, N'Sư Phạm Anh', N'Cao Học')
INSERT [dbo].[tb_TrinhDoHocVan] ([MaTDHV], [TrinhDoHocVan], [ChuyenNganh]) VALUES (31, N'Đại Học', N'Ngôn Ngữ Anh')
INSERT [dbo].[tb_TrinhDoHocVan] ([MaTDHV], [TrinhDoHocVan], [ChuyenNganh]) VALUES (32, N'Chăn Nuôi', N'Đại Học')
INSERT [dbo].[tb_TrinhDoHocVan] ([MaTDHV], [TrinhDoHocVan], [ChuyenNganh]) VALUES (33, N'Sư Phạm Hóa', N'Đại Học')
INSERT [dbo].[tb_TrinhDoHocVan] ([MaTDHV], [TrinhDoHocVan], [ChuyenNganh]) VALUES (34, N'Quản Trị Kinh Doanh', N'Đại Học')
INSERT [dbo].[tb_TrinhDoHocVan] ([MaTDHV], [TrinhDoHocVan], [ChuyenNganh]) VALUES (35, N'Điện Lạnh', N'Cao Học')
INSERT [dbo].[tb_TrinhDoHocVan] ([MaTDHV], [TrinhDoHocVan], [ChuyenNganh]) VALUES (37, N'Thú Y', N'Đại Học')
SET IDENTITY_INSERT [dbo].[tb_TrinhDoHocVan] OFF
GO
ALTER TABLE [dbo].[tb_NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_tb_NhanVien_tb_HopDongLaoDong] FOREIGN KEY([HopDongLaoDong])
REFERENCES [dbo].[tb_HopDongLaoDong] ([HopDongLaoDong])
GO
ALTER TABLE [dbo].[tb_NhanVien] CHECK CONSTRAINT [FK_tb_NhanVien_tb_HopDongLaoDong]
GO
ALTER TABLE [dbo].[tb_NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_tb_NhanVien_tb_NhanVien_ChucVu] FOREIGN KEY([MachucVu])
REFERENCES [dbo].[tb_NhanVien_ChucVu] ([ChucVu_MachucVu])
GO
ALTER TABLE [dbo].[tb_NhanVien] CHECK CONSTRAINT [FK_tb_NhanVien_tb_NhanVien_ChucVu]
GO
ALTER TABLE [dbo].[tb_NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_tb_NhanVien_tb_PhongBan] FOREIGN KEY([MaPB])
REFERENCES [dbo].[tb_PhongBan] ([MaPB])
GO
ALTER TABLE [dbo].[tb_NhanVien] CHECK CONSTRAINT [FK_tb_NhanVien_tb_PhongBan]
GO
ALTER TABLE [dbo].[tb_NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_tb_NhanVien_tb_TrinhDoHocVan] FOREIGN KEY([MaTDHV])
REFERENCES [dbo].[tb_TrinhDoHocVan] ([MaTDHV])
GO
ALTER TABLE [dbo].[tb_NhanVien] CHECK CONSTRAINT [FK_tb_NhanVien_tb_TrinhDoHocVan]
GO
ALTER TABLE [dbo].[tb_NhanVien_ChucVu]  WITH CHECK ADD  CONSTRAINT [FK_tb_NhanVien_ChucVu_tb_ChucVu] FOREIGN KEY([ChucVu_MachucVu])
REFERENCES [dbo].[tb_ChucVu] ([MachucVu])
GO
ALTER TABLE [dbo].[tb_NhanVien_ChucVu] CHECK CONSTRAINT [FK_tb_NhanVien_ChucVu_tb_ChucVu]
GO
ALTER TABLE [dbo].[tb_QuanLyChamCong]  WITH CHECK ADD  CONSTRAINT [FK_tb_QuanLyChamCong_tb_NhanVien] FOREIGN KEY([MANV])
REFERENCES [dbo].[tb_NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[tb_QuanLyChamCong] CHECK CONSTRAINT [FK_tb_QuanLyChamCong_tb_NhanVien]
GO
ALTER TABLE [dbo].[tb_QuanLyLuong]  WITH CHECK ADD  CONSTRAINT [FK_tb_QuanLyLuong_tb_ChucVu] FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[tb_ChucVu] ([MachucVu])
GO
ALTER TABLE [dbo].[tb_QuanLyLuong] CHECK CONSTRAINT [FK_tb_QuanLyLuong_tb_ChucVu]
GO
ALTER TABLE [dbo].[tb_TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_tb_TaiKhoan_tb_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tb_NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[tb_TaiKhoan] CHECK CONSTRAINT [FK_tb_TaiKhoan_tb_NhanVien]
GO
