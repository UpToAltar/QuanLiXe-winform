USE [QuanLiXe]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 7/8/2024 10:28:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](100) NOT NULL,
	[DisplayName] [nvarchar](100) NULL,
	[Password] [nvarchar](100) NULL,
	[Role] [nvarchar](100) NULL,
	[Image] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Manufactures]    Script Date: 7/8/2024 10:28:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manufactures](
	[ManufacturesId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Icon] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[ManufacturesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Owners]    Script Date: 7/8/2024 10:28:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Owners](
	[OwnerId] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](100) NOT NULL,
	[Address] [nvarchar](200) NULL,
	[Email] [nvarchar](100) NOT NULL,
	[PhoneNumber] [nvarchar](12) NULL,
PRIMARY KEY CLUSTERED 
(
	[OwnerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Specifications]    Script Date: 7/8/2024 10:28:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Specifications](
	[SpecificationsId] [int] IDENTITY(1,1) NOT NULL,
	[EngineType] [nvarchar](100) NULL,
	[FuelType] [nvarchar](100) NULL,
	[Weigth] [float] NULL,
	[TopSpeed] [float] NULL,
	[Acceleration] [float] NULL,
	[EngineDisplacement] [nvarchar](100) NULL,
	[VehiclesId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[SpecificationsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehicles]    Script Date: 7/8/2024 10:28:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehicles](
	[VehiclesId] [int] IDENTITY(1,1) NOT NULL,
	[LiscensePlate] [nvarchar](20) NOT NULL,
	[VehicleName] [nvarchar](200) NOT NULL,
	[ManufacturesId] [int] NOT NULL,
	[OwnerId] [int] NULL,
	[SpecificationsId] [int] NOT NULL,
	[Color] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[VehiclesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (1, N'John Martinez', N'John Martinez', N'12345', N'Nhân viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (2, N'Alex Smith', N'Alex Smith', N'12345', N'Nhân viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (3, N'James Smith', N'James Smith', N'12345', N'Quản trị viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (4, N'John Davis', N'John Davis', N'12345', N'Nhân viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (5, N'William Smith', N'William Smith', N'12345', N'Nhân viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (6, N'John Garcia', N'John Garcia', N'12345', N'Nhân viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (7, N'Michael Williams', N'Michael Williams', N'12345', N'Nhân viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (8, N'Robert Rodriguez', N'Robert Rodriguez', N'12345', N'Nhân viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (9, N'William Martinez', N'William Martinez', N'12345', N'Nhân viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (10, N'Richard Williams', N'Richard Williams', N'12345', N'Nhân viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (11, N'Michael Smith', N'Michael Smith', N'12345', N'Nhân viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (12, N'Robert Smith', N'Robert Smith', N'12345', N'Quản trị viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (13, N'Richard Brown', N'Richard Brown', N'12345', N'Quản trị viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (14, N'James Brown', N'James Brown', N'12345', N'Nhân viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (15, N'Robert Jones', N'Robert Jones', N'12345', N'Nhân viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (16, N'David Miller', N'David Miller', N'12345', N'Quản trị viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (17, N'James Jones', N'James Jones', N'12345', N'Quản trị viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (18, N'Charles Martinez', N'Charles Martinez', N'12345', N'Quản trị viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (19, N'Charles Johnson', N'Charles Johnson', N'12345', N'Nhân viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (20, N'Richard Jones', N'Richard Jones', N'12345', N'Nhân viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (21, N'James Miller', N'James Miller', N'12345', N'Nhân viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (22, N'Richard Davis', N'Richard Davis', N'12345', N'Nhân viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (23, N'William Jones', N'William Jones', N'12345', N'Nhân viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (24, N'William Garcia', N'William Garcia', N'12345', N'Quản trị viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (25, N'Joseph Garcia', N'Joseph Garcia', N'12345', N'Quản trị viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (26, N'David Smith', N'David Smith', N'12345', N'Nhân viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (27, N'Michael Miller', N'Michael Miller', N'12345', N'Quản trị viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (28, N'Robert Williams', N'Robert Williams', N'12345', N'Quản trị viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (29, N'David Johnson', N'David Johnson', N'12345', N'Quản trị viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (30, N'Joseph Rodriguez', N'Joseph Rodriguez', N'12345', N'Nhân viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (31, N'Michael Johnson', N'Michael Johnson', N'12345', N'Nhân viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (32, N'William Davis', N'William Davis', N'12345', N'Quản trị viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (33, N'James Martinez', N'James Martinez', N'12345', N'Quản trị viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (34, N'Joseph Smith', N'Joseph Smith', N'12345', N'Quản trị viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (35, N'David Brown', N'David Brown', N'12345', N'Quản trị viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (36, N'Robert Garcia', N'Robert Garcia', N'12345', N'Quản trị viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (37, N'John Johnson', N'John Johnson', N'12345', N'Nhân viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (38, N'David Davis', N'David Davis', N'12345', N'Nhân viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (39, N'William Brown', N'William Brown', N'12345', N'Nhân viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (40, N'Charles Jones', N'Charles Jones', N'12345', N'Quản trị viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (41, N'Charles Garcia', N'Charles Garcia', N'12345', N'Nhân viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (42, N'Alex Rodriguez', N'Alex Rodriguez', N'12345', N'Quản trị viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (43, N'Charles Smith', N'Charles Smith', N'12345', N'Nhân viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (44, N'John Williams', N'John Williams', N'12345', N'Nhân viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (45, N'Joseph Williams', N'Joseph Williams', N'12345', N'Quản trị viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (46, N'Richard Martinez', N'Richard Martinez', N'12345', N'Quản trị viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (47, N'Michael Jones', N'Michael Jones', N'12345', N'Nhân viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (48, N'John Miller', N'John Miller', N'12345', N'Nhân viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (49, N'James Johnson', N'James Johnson', N'12345', N'Quản trị viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (50, N'Robert Davis', N'Robert Davis', N'12345', N'Quản trị viên', NULL)
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (51, N'QuanDao', N'QuanDao', N'1111111', N'Quản trị viên', N'555')
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (58, N'Quản trị viên', N'aa', N'1111111', N'Quản trị viên', N'acv')
INSERT [dbo].[Account] ([ID], [UserName], [DisplayName], [Password], [Role], [Image]) VALUES (68, N'q', N'q333344', N'1', N'Quản trị viên', N'https://img.lovepik.com/free-png/20211130/lovepik-cartoon-avatar-png-image_401205251_wh1200.png')
SET IDENTITY_INSERT [dbo].[Account] OFF
GO
SET IDENTITY_INSERT [dbo].[Manufactures] ON 

INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (1, N'Toyota1', N'1')
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (2, N'Volkswagen', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (3, N'Ford', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (4, N'Honda', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (5, N'Chevrolet', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (6, N'Nissan', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (7, N'BMW', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (8, N'Mercedes-Benz', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (9, N'Hyundai', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (10, N'Audi', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (11, N'Kia', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (12, N'Lexus', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (13, N'Mazda', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (14, N'Subaru', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (15, N'Jaguar', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (16, N'Land Rover', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (17, N'Porsche', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (18, N'Tesla', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (19, N'Volvo', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (20, N'Mitsubishi', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (21, N'Buick', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (22, N'Cadillac', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (23, N'Chrysler', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (24, N'Dodge', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (25, N'GMC', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (26, N'Jeep', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (27, N'Lincoln', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (28, N'Ram', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (29, N'Acura', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (30, N'Infiniti', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (31, N'Genesis', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (32, N'Alfa Romeo', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (33, N'Fiat', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (34, N'Mini', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (35, N'Maserati', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (36, N'Ferrari', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (37, N'Lamborghini', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (38, N'Bentley', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (39, N'Rolls-Royce', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (40, N'Aston Martin', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (41, N'McLaren', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (42, N'Bugatti', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (43, N'Pagani', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (44, N'Koenigsegg', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (45, N'Rivian', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (46, N'Lucid', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (47, N'Peugeot', NULL)
INSERT [dbo].[Manufactures] ([ManufacturesId], [Name], [Icon]) VALUES (48, N'Citroen', NULL)
SET IDENTITY_INSERT [dbo].[Manufactures] OFF
GO
SET IDENTITY_INSERT [dbo].[Owners] ON 

INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (9, N'Alex', N'New York', N'Alex@gmail.com', N'123-456-7890')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (10, N'Brian', N'Los Angeles', N'Brian@gmail.com', N'234-567-8901')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (11, N'Charlie', N'Chicago', N'Charlie@gmail.com', N'345-678-9012')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (12, N'David', N'Houston', N'David@gmail.com', N'456-789-0123')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (13, N'Ethan', N'Phoenix', N'Ethan@gmail.com', N'567-890-1234')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (14, N'Frank', N'Philadelphia', N'Frank@gmail.com', N'678-901-2345')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (15, N'George', N'San Antonio', N'George@gmail.com', N'789-012-3456')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (16, N'Henry', N'San Diego', N'Henry@gmail.com', N'890-123-4567')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (17, N'Isaac', N'Dallas', N'Isaac@gmail.com', N'901-234-5678')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (18, N'Jack', N'San Jose', N'Jack@gmail.com', N'012-345-6789')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (19, N'Kevin', N'Austin', N'Kevin@gmail.com', N'123-456-7891')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (20, N'Liam', N'Jacksonville', N'Liam@gmail.com', N'234-567-8902')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (21, N'Michael', N'Fort Worth', N'Michael@gmail.com', N'345-678-9013')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (22, N'Nathan', N'Columbus', N'Nathan@gmail.com', N'456-789-0124')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (23, N'Owen', N'Charlotte', N'Owen@gmail.com', N'567-890-1235')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (24, N'Paul', N'San Francisco', N'Paul@gmail.com', N'678-901-2346')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (25, N'Quincy', N'Indianapolis', N'Quincy@gmail.com', N'789-012-3457')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (26, N'Ryan', N'Seattle', N'Ryan@gmail.com', N'890-123-4568')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (27, N'Steve', N'Denver', N'Steve@gmail.com', N'901-234-5679')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (28, N'Thomas', N'Washington', N'Thomas@gmail.com', N'012-345-6790')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (29, N'Ulysses', N'Boston', N'Ulysses@gmail.com', N'123-456-7892')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (30, N'Victor', N'El Paso', N'Victor@gmail.com', N'234-567-8903')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (31, N'William', N'Nashville', N'William@gmail.com', N'345-678-9014')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (32, N'Xander', N'Detroit', N'Xander@gmail.com', N'456-789-0125')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (33, N'Yale', N'Memphis', N'Yale@gmail.com', N'567-890-1236')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (34, N'Zachary', N'Louisville', N'Zachary@gmail.com', N'678-901-2347')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (35, N'Aaron', N'Baltimore', N'Aaron@gmail.com', N'789-012-3458')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (36, N'Blake', N'Milwaukee', N'Blake@gmail.com', N'890-123-4569')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (37, N'Caleb', N'Albuquerque', N'Caleb@gmail.com', N'901-234-5680')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (38, N'Dylan', N'Tucson', N'Dylan@gmail.com', N'012-345-6791')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (39, N'Evan', N'Fresno', N'Evan@gmail.com', N'123-456-7893')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (40, N'Gavin', N'Sacramento', N'Gavin@gmail.com', N'234-567-8904')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (41, N'Hunter', N'Mesa', N'Hunter@gmail.com', N'345-678-9015')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (42, N'Ian', N'Kansas City', N'Ian@gmail.com', N'456-789-0126')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (43, N'Jason', N'Atlanta', N'Jason@gmail.com', N'567-890-1237')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (44, N'Kyle', N'Omaha', N'Kyle@gmail.com', N'678-901-2348')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (45, N'Lucas', N'Miami', N'Lucas@gmail.com', N'789-012-3459')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (46, N'Mason', N'Tulsa', N'Mason@gmail.com', N'890-123-4570')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (47, N'Noah', N'Minneapolis', N'Noah@gmail.com', N'901-234-5681')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (48, N'Omar', N'Cleveland', N'Omar@gmail.com', N'012-345-6792')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (49, N'Parker', N'Wichita', N'Parker@gmail.com', N'123-456-7894')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (50, N'Quinn', N'Arlington', N'Quinn@gmail.com', N'234-567-8905')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (51, N'Riley', N'Bakersfield', N'Riley@gmail.com', N'345-678-9016')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (52, N'Sam', N'Aurora', N'Sam@gmail.com', N'456-789-0127')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (53, N'Tyler', N'Tampa', N'Tyler@gmail.com', N'567-890-1238')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (54, N'Umar', N'Honolulu', N'Umar@gmail.com', N'678-901-2349')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (55, N'Vincent', N'Anaheim', N'Vincent@gmail.com', N'789-012-3460')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (56, N'Wesley', N'Santa Ana', N'Wesley@gmail.com', N'890-123-4571')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (57, N'Xavier', N'Corpus Christi', N'Xavier@gmail.com', N'901-234-5682')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (58, N'Yusuf', N'Riverside', N'Yusuf@gmail.com', N'012-345-6793')
INSERT [dbo].[Owners] ([OwnerId], [FullName], [Address], [Email], [PhoneNumber]) VALUES (59, N'Zane', N'Lexington', N'Zane@gmail.com', N'123-456-7895')
SET IDENTITY_INSERT [dbo].[Owners] OFF
GO
SET IDENTITY_INSERT [dbo].[Specifications] ON 

INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (1, N'V8', N'Petrol', 1500.5, 220.5, 6.8, N'4.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (2, N'V6', N'Diesel', 1600, 210, 7.2, N'3.5L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (3, N'Electric', N'Electric', 1200, 250, 5.5, N'N/A', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (4, N'V12', N'Petrol', 1800, 300, 4.5, N'6.5L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (5, N'Inline-4', N'Petrol', 1400, 200, 8, N'2.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (6, N'V8', N'Diesel', 1700, 240, 6, N'5.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (7, N'V10', N'Petrol', 1900, 280, 4.8, N'5.2L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (8, N'Inline-6', N'Petrol', 1550, 220, 7.5, N'3.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (9, N'Electric', N'Electric', 1300, 260, 5, N'N/A', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (10, N'V8', N'Petrol', 1500.5, 230, 6.3, N'4.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (11, N'V8', N'Petrol', 1500.5, 220.5, 6.8, N'4.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (12, N'V6', N'Diesel', 1600, 210, 7.2, N'3.5L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (13, N'Electric', N'Electric', 1200, 250, 5.5, N'N/A', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (14, N'V12', N'Petrol', 1800, 300, 4.5, N'6.5L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (15, N'Inline-4', N'Petrol', 1400, 200, 8, N'2.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (16, N'V8', N'Diesel', 1700, 240, 6, N'5.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (17, N'V10', N'Petrol', 1900, 280, 4.8, N'5.2L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (18, N'Inline-6', N'Petrol', 1550, 220, 7.5, N'3.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (19, N'Electric', N'Electric', 1300, 260, 5, N'N/A', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (20, N'V8', N'Petrol', 1500.5, 230, 6.3, N'4.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (21, N'V8', N'Petrol', 1500.5, 220.5, 6.8, N'4.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (22, N'V6', N'Diesel', 1600, 210, 7.2, N'3.5L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (23, N'Electric', N'Electric', 1200, 250, 5.5, N'N/A', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (24, N'V12', N'Petrol', 1800, 300, 4.5, N'6.5L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (25, N'Inline-4', N'Petrol', 1400, 200, 8, N'2.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (26, N'V8', N'Diesel', 1700, 240, 6, N'5.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (27, N'V10', N'Petrol', 1900, 280, 4.8, N'5.2L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (28, N'Inline-6', N'Petrol', 1550, 220, 7.5, N'3.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (29, N'Electric', N'Electric', 1300, 260, 5, N'N/A', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (30, N'V8', N'Petrol', 1500.5, 230, 6.3, N'4.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (31, N'V8', N'Petrol', 1500.5, 220.5, 6.8, N'4.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (32, N'V6', N'Diesel', 1600, 210, 7.2, N'3.5L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (33, N'Electric', N'Electric', 1200, 250, 5.5, N'N/A', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (34, N'V12', N'Petrol', 1800, 300, 4.5, N'6.5L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (35, N'Inline-4', N'Petrol', 1400, 200, 8, N'2.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (36, N'V8', N'Diesel', 1700, 240, 6, N'5.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (37, N'V10', N'Petrol', 1900, 280, 4.8, N'5.2L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (38, N'Inline-6', N'Petrol', 1550, 220, 7.5, N'3.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (39, N'Electric', N'Electric', 1300, 260, 5, N'N/A', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (40, N'V8', N'Petrol', 1500.5, 230, 6.3, N'4.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (41, N'V8', N'Petrol', 1500.5, 220.5, 6.8, N'4.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (42, N'V6', N'Diesel', 1600, 210, 7.2, N'3.5L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (43, N'Electric', N'Electric', 1200, 250, 5.5, N'N/A', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (44, N'V12', N'Petrol', 1800, 300, 4.5, N'6.5L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (45, N'Inline-4', N'Petrol', 1400, 200, 8, N'2.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (46, N'V8', N'Diesel', 1700, 240, 6, N'5.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (47, N'V10', N'Petrol', 1900, 280, 4.8, N'5.2L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (48, N'Inline-6', N'Petrol', 1550, 220, 7.5, N'3.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (49, N'Electric', N'Electric', 1300, 260, 5, N'N/A', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (50, N'V8', N'Petrol', 1500.5, 230, 6.3, N'4.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (51, N'V8', N'Petrol', 1500.5, 220.5, 6.8, N'4.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (52, N'V6', N'Diesel', 1600, 210, 7.2, N'3.5L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (53, N'Electric', N'Electric', 1200, 250, 5.5, N'N/A', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (54, N'V12', N'Petrol', 1800, 300, 4.5, N'6.5L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (55, N'Inline-4', N'Petrol', 1400, 200, 8, N'2.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (56, N'V8', N'Diesel', 1700, 240, 6, N'5.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (57, N'V10', N'Petrol', 1900, 280, 4.8, N'5.2L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (58, N'Inline-6', N'Petrol', 1550, 220, 7.5, N'3.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (59, N'Electric', N'Electric', 1300, 260, 5, N'N/A', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (60, N'V8', N'Petrol', 1500.5, 230, 6.3, N'4.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (61, N'V8', N'Petrol', 1500.5, 220.5, 6.8, N'4.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (62, N'V6', N'Diesel', 1600, 210, 7.2, N'3.5L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (63, N'Electric', N'Electric', 1200, 250, 5.5, N'N/A', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (64, N'V12', N'Petrol', 1800, 300, 4.5, N'6.5L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (65, N'Inline-4', N'Petrol', 1400, 200, 8, N'2.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (66, N'V8', N'Diesel', 1700, 240, 6, N'5.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (67, N'V10', N'Petrol', 1900, 280, 4.8, N'5.2L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (68, N'Inline-6', N'Petrol', 1550, 220, 7.5, N'3.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (69, N'Electric', N'Electric', 1300, 260, 5, N'N/A', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (70, N'V8', N'Petrol', 1500.5, 230, 6.3, N'4.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (71, N'V8', N'Petrol', 1500.5, 220.5, 6.8, N'4.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (72, N'V6', N'Diesel', 1600, 210, 7.2, N'3.5L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (73, N'Electric', N'Electric', 1200, 250, 5.5, N'N/A', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (74, N'V12', N'Petrol', 1800, 300, 4.5, N'6.5L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (75, N'Inline-4', N'Petrol', 1400, 200, 8, N'2.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (76, N'V8', N'Diesel', 1700, 240, 6, N'5.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (77, N'V10', N'Petrol', 1900, 280, 4.8, N'5.2L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (78, N'Inline-6', N'Petrol', 1550, 220, 7.5, N'3.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (79, N'Electric', N'Electric', 1300, 260, 5, N'N/A', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (80, N'V8', N'Petrol', 1500.5, 230, 6.3, N'4.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (81, N'V8', N'Petrol', 1500.5, 220.5, 6.8, N'4.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (82, N'V6', N'Diesel', 1600, 210, 7.2, N'3.5L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (83, N'Electric', N'Electric', 1200, 250, 5.5, N'N/A', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (84, N'V12', N'Petrol', 1800, 300, 4.5, N'6.5L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (85, N'Inline-4', N'Petrol', 1400, 200, 8, N'2.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (86, N'V8', N'Diesel', 1700, 240, 6, N'5.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (87, N'V10', N'Petrol', 1900, 280, 4.8, N'5.2L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (88, N'Inline-6', N'Petrol', 1550, 220, 7.5, N'3.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (89, N'Electric', N'Electric', 1300, 260, 5, N'N/A', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (90, N'V8', N'Petrol', 1500.5, 230, 6.3, N'4.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (91, N'V8', N'Petrol', 1500.5, 220.5, 6.8, N'4.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (92, N'V6', N'Diesel', 1600, 210, 7.2, N'3.5L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (93, N'Electric', N'Electric', 1200, 250, 5.5, N'N/A', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (94, N'V12', N'Petrol', 1800, 300, 4.5, N'6.5L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (95, N'Inline-4', N'Petrol', 1400, 200, 8, N'2.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (96, N'V8', N'Diesel', 1700, 240, 6, N'5.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (97, N'V10', N'Petrol', 1900, 280, 4.8, N'5.2L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (98, N'Inline-6', N'Petrol', 1550, 220, 7.5, N'3.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (99, N'Electric', N'Electric', 1300, 260, 5, N'N/A', NULL)
GO
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (100, N'V8', N'Petrol', 1500.5, 230, 6.3, N'4.0L', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (109, N't', N't', 0, 0, 0, N't', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (110, N'âa1', N'aa1', 1, 1, 1, N'aa1', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (111, N't', N'tt', 0, 0, 0, N't', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (112, N'x', N'xx', 0, 0, 0, N'x', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (113, N'12', N'12', 1, 1, 1, N'12', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (114, N'e', N'e', 0, 0, 0, N'e', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (115, N'e', N'e55555555', 5, 5, 5, N'5', NULL)
INSERT [dbo].[Specifications] ([SpecificationsId], [EngineType], [FuelType], [Weigth], [TopSpeed], [Acceleration], [EngineDisplacement], [VehiclesId]) VALUES (116, N't', N't', 0, 0, 0, N't', NULL)
SET IDENTITY_INSERT [dbo].[Specifications] OFF
GO
SET IDENTITY_INSERT [dbo].[Vehicles] ON 

INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (41, N'ABC1230', N'Honda', 25, 13, 1, N'Red')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (42, N'ABC1231', N'Yamaha', 24, 17, 2, N'Blue')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (43, N'ABC1232', N'Suzuki', 26, 31, 3, N'Green')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (44, N'ABC1233', N'Kawasaki', 18, 28, 4, N'Yellow')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (45, N'ABC1234', N'Ducati', 46, 20, 5, N'Red')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (46, N'ABC1235', N'BMW', 42, 35, 6, N'Blue')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (47, N'ABC1236', N'Harley-Davidson', 2, 46, 7, N'Green')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (48, N'ABC1237', N'Triumph', 11, 18, 8, N'Yellow')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (49, N'ABC1238', N'Aprilia', 33, 55, 9, N'Red')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (50, N'ABC1239', N'KTM', 17, 21, 10, N'Blue')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (51, N'ABC1240', N'MV Agusta', 28, 12, 11, N'Green')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (52, N'ABC1241', N'Royal Enfield', 34, 52, 12, N'Yellow')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (53, N'ABC1242', N'Moto Guzzi', 5, 44, 13, N'Red')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (54, N'ABC1243', N'Benelli', 35, 55, 14, N'Blue')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (55, N'ABC1244', N'Husqvarna', 42, 59, 15, N'Green')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (56, N'ABC1245', N'Indian', 14, 30, 16, N'Yellow')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (57, N'ABC1246', N'Victory', 24, 37, 17, N'Red')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (58, N'ABC1247', N'Bajaj', 46, 17, 18, N'Blue')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (59, N'ABC1248', N'Hero', 39, 12, 19, N'Green')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (60, N'ABC1249', N'TVS', 4, 39, 20, N'Yellow')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (61, N'ABC1250', N'Mahindra', 15, 45, 21, N'Red')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (62, N'ABC1251', N'Piaggio', 31, 37, 22, N'Blue')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (63, N'ABC1252', N'Vespa', 17, 17, 23, N'Green')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (64, N'ABC1253', N'Peugeot', 30, 48, 24, N'Yellow')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (65, N'ABC1254', N'SYM', 8, 38, 25, N'Red')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (66, N'ABC1255', N'Kymco', 48, 54, 26, N'Blue')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (67, N'ABC1256', N'CFMoto', 20, 40, 27, N'Green')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (68, N'ABC1257', N'QJ Motor', 38, 56, 28, N'Yellow')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (69, N'ABC1258', N'Zontes', 4, 46, 29, N'Red')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (70, N'ABC1259', N'Geely', 35, 48, 30, N'Blue')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (71, N'ABC1260', N'Lifan', 13, 49, 31, N'Green')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (72, N'ABC1261', N'Zongshen', 16, 38, 32, N'Yellow')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (73, N'ABC1262', N'Loncin', 2, 49, 33, N'Red')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (74, N'ABC1263', N'Yadea', 30, 39, 34, N'Blue')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (75, N'ABC1264', N'Segway', 46, 49, 35, N'Green')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (76, N'ABC1265', N'Xiaomi', 48, 11, 36, N'Yellow')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (77, N'ABC1266', N'Ford', 7, 49, 37, N'Red')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (78, N'ABC1267', N'Chevrolet', 18, 29, 38, N'Blue')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (79, N'ABC1268', N'Toyota', 34, 19, 39, N'Green')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (80, N'ABC1269', N'Honda Car', 29, 16, 40, N'Yellow')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (81, N'ABC1270', N'Nissan', 45, 41, 41, N'Red')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (82, N'ABC1271', N'Hyundai', 3, 37, 42, N'Blue')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (83, N'ABC1272', N'Kia', 32, 13, 43, N'Green')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (84, N'ABC1273', N'Volkswagen', 15, 55, 44, N'Yellow')
INSERT [dbo].[Vehicles] ([VehiclesId], [LiscensePlate], [VehicleName], [ManufacturesId], [OwnerId], [SpecificationsId], [Color]) VALUES (85, N'ABC1274', N'Audi', 31, 29, 45, N'Red')
SET IDENTITY_INSERT [dbo].[Vehicles] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Account__C9F28456248D048B]    Script Date: 7/8/2024 10:28:51 AM ******/
ALTER TABLE [dbo].[Account] ADD UNIQUE NONCLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Manufact__737584F66868385E]    Script Date: 7/8/2024 10:28:51 AM ******/
ALTER TABLE [dbo].[Manufactures] ADD UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Owners__A9D105347BF15D07]    Script Date: 7/8/2024 10:28:51 AM ******/
ALTER TABLE [dbo].[Owners] ADD UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Vehicles__8C6BC6D36EF0DC98]    Script Date: 7/8/2024 10:28:51 AM ******/
ALTER TABLE [dbo].[Vehicles] ADD UNIQUE NONCLUSTERED 
(
	[LiscensePlate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Specifications] ADD  DEFAULT ((0)) FOR [Weigth]
GO
ALTER TABLE [dbo].[Specifications] ADD  DEFAULT ((0)) FOR [TopSpeed]
GO
ALTER TABLE [dbo].[Specifications] ADD  DEFAULT ((0)) FOR [Acceleration]
GO
ALTER TABLE [dbo].[Specifications]  WITH CHECK ADD FOREIGN KEY([VehiclesId])
REFERENCES [dbo].[Vehicles] ([VehiclesId])
GO
ALTER TABLE [dbo].[Vehicles]  WITH CHECK ADD FOREIGN KEY([ManufacturesId])
REFERENCES [dbo].[Manufactures] ([ManufacturesId])
GO
ALTER TABLE [dbo].[Vehicles]  WITH CHECK ADD FOREIGN KEY([OwnerId])
REFERENCES [dbo].[Owners] ([OwnerId])
GO
/****** Object:  StoredProcedure [dbo].[CreateManufacture]    Script Date: 7/8/2024 10:28:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CreateManufacture] (
	@Name NVARCHAR(100) , @Icon NVARCHAR(100)
) AS
BEGIN
	INSERT INTO Manufactures (Name,Icon) VALUES (@Name, @Icon)
END
GO
/****** Object:  StoredProcedure [dbo].[CreateOwner]    Script Date: 7/8/2024 10:28:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CreateOwner] (
	 @Email NVARCHAR(100), @Address NVARCHAR(100), @FullName NVARCHAR(100), @PhoneNumber NVARCHAR(100)
) AS
BEGIN
	INSERT INTO Owners (FullName, Email, Address, PhoneNumber) 
	VALUES (@FullName, @Email, @Address,@PhoneNumber )
END
GO
/****** Object:  StoredProcedure [dbo].[CreateSpecification]    Script Date: 7/8/2024 10:28:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CreateSpecification] (
	@EngineType NVARCHAR(100),@FuelType NVARCHAR(100) , @EngineDisplacement NVARCHAR(100) , @Weigth FLOAT , @TopSpeed FlOAT, @Acceleration FLOAT
) AS
BEGIN
			INSERT INTO dbo.Specifications (EngineType, FuelType, Weigth, TopSpeed, Acceleration, EngineDisplacement)
            VALUES (@EngineType, @FuelType, @Weigth, @TopSpeed, @Acceleration,@EngineDisplacement)
END	
GO
/****** Object:  StoredProcedure [dbo].[CreateUser]    Script Date: 7/8/2024 10:28:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CreateUser] (
	@UserName NVARCHAR(100),@DisplayName NVARCHAR(100), @Password NVARCHAR(100), @Role NVARCHAR(100),@Image NVARCHAR(200)
) AS
BEGIN
	INSERT INTO Account (DisplayName, UserName, Password, Role,Image) 
	VALUES(@UserName,@DisplayName, @Password, @Role,@Image)
END
GO
/****** Object:  StoredProcedure [dbo].[CreateVehicle]    Script Date: 7/8/2024 10:28:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CreateVehicle] (
	@VehicleName NVARCHAR(100),@LiscensePlate NVARCHAR(100) , @Color NVARCHAR(100) , @ManufacturesId INT , @OwnerId INT, @SpecificationsId INT
) AS
BEGIN
		INSERT INTO dbo.Vehicles (VehicleName, LiscensePlate, Color, ManufacturesId, OwnerId, SpecificationsId) 
        VALUES (@VehicleName, @LiscensePlate, @Color, @ManufacturesId, @OwnerId, @SpecificationsId)
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteManufactureById]    Script Date: 7/8/2024 10:28:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DeleteManufactureById] (
	 @Id INT
) AS
BEGIN
	DELETE FROM Manufactures WHERE ManufacturesId = @Id;
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteOwner]    Script Date: 7/8/2024 10:28:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[DeleteOwner] (
	@Id INT
) AS
BEGIN
	DELETE FROM Owners WHERE OwnerId = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteUserById]    Script Date: 7/8/2024 10:28:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DeleteUserById] (
	@Id INT
) AS
BEGIN
	DELETE FROM Account WHERE ID = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteVehicleById]    Script Date: 7/8/2024 10:28:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DeleteVehicleById] (
	@VehiclesId INT
) AS
BEGIN
		DELETE FROM dbo.Vehicles WHERE VehiclesId = @VehiclesId
END
GO
/****** Object:  StoredProcedure [dbo].[FindOwnerByEmailNotById]    Script Date: 7/8/2024 10:28:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[FindOwnerByEmailNotById] (
	 @Id INT, @Email NVARCHAR(100)
) AS
BEGIN
	SELECT * FROM Owners WHERE Email = @Email AND OwnerId != @Id
END
GO
/****** Object:  StoredProcedure [dbo].[FindUserById]    Script Date: 7/8/2024 10:28:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindUserById] (
	@Id INT
) AS
BEGIN
	SELECT * FROM Account WHERE ID = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[FindUserByUserName]    Script Date: 7/8/2024 10:28:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindUserByUserName] (
	@UserName NVARCHAR(100)
) AS
BEGIN
	SELECT * FROM Account WHERE UserName = @UserName
END
GO
/****** Object:  StoredProcedure [dbo].[FindUserByUserNameAndPassword]    Script Date: 7/8/2024 10:28:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindUserByUserNameAndPassword] (
	@UserName NVARCHAR(100),
	@Password NVARCHAR(100)
) AS
BEGIN
	SELECT * FROM Account WHERE UserName = @UserName AND Password =	@Password
END
GO
/****** Object:  StoredProcedure [dbo].[FindUserByUserNameNotById]    Script Date: 7/8/2024 10:28:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindUserByUserNameNotById] (
	@UserName NVARCHAR(100) , @Id INT
) AS
BEGIN
	SELECT * FROM Account WHERE UserName = @UserName AND ID != @Id 
END
GO
/****** Object:  StoredProcedure [dbo].[FindVehiclesById]    Script Date: 7/8/2024 10:28:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindVehiclesById] (
	@Id INT
) AS
BEGIN
	SELECT * FROM Vehicles WHERE VehiclesId = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[FindVehiclesByPlate]    Script Date: 7/8/2024 10:28:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindVehiclesByPlate] (
	@LiscensePlate NVARCHAR(100)
) AS
BEGIN
	SELECT * FROM Vehicles WHERE LiscensePlate = @LiscensePlate
END
GO
/****** Object:  StoredProcedure [dbo].[FindVehiclesByPlateNotById]    Script Date: 7/8/2024 10:28:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FindVehiclesByPlateNotById] (
	@Id INT, @LiscensePlate NVARCHAR(100)
) AS
BEGIN
	SELECT * FROM Vehicles WHERE LiscensePlate = @LiscensePlate AND VehiclesId != @Id
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllManufactures]    Script Date: 7/8/2024 10:28:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetAllManufactures] AS
BEGIN
	SELECT * FROM Manufactures
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllOwner]    Script Date: 7/8/2024 10:28:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetAllOwner]  AS
BEGIN
	SELECT * FROM Owners
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllUser]    Script Date: 7/8/2024 10:28:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[GetAllUser]  AS
BEGIN
	SELECT * FROM Account
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllVehicles]    Script Date: 7/8/2024 10:28:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetAllVehicles] AS
BEGIN
				SELECT
                 v.VehiclesId, v.VehicleName, v.LiscensePlate, v.Color, 
                m.Name as ManufactureName,m.ManufacturesId as ManufacturesId , o.FullName as OwnerName,o.OwnerId as OwnerId , o.Email as OwnerEmail,
                s.EngineType, s.FuelType , s.Weigth, s.TopSpeed, s.Acceleration, s.EngineDisplacement
                 FROM Vehicles AS v 
                JOIN Specifications AS s
                 ON s.SpecificationsId = v.SpecificationsId 
                JOIN Manufactures AS m
                 ON m.ManufacturesId = v.ManufacturesId 
                JOIN Owners AS o
                 ON o.OwnerId = v.OwnerId 
END		
GO
/****** Object:  StoredProcedure [dbo].[GetManufacturesById]    Script Date: 7/8/2024 10:28:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetManufacturesById] (
	@Id INT
) AS
BEGIN
	SELECT * FROM Manufactures WHERE ManufacturesId = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[GetManufacturesByName]    Script Date: 7/8/2024 10:28:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetManufacturesByName] (
	@Name NVARCHAR(100)
) AS
BEGIN
	SELECT * FROM Manufactures WHERE Name = @Name
END
GO
/****** Object:  StoredProcedure [dbo].[GetOwnerByEmail]    Script Date: 7/8/2024 10:28:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROC [dbo].[GetOwnerByEmail] (
	 @Email NVARCHAR(100)
) AS
BEGIN
	SELECT * FROM Owners WHERE Email = @Email
END
GO
/****** Object:  StoredProcedure [dbo].[GetOwnerById]    Script Date: 7/8/2024 10:28:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetOwnerById] (
	 @Id INT
) AS
BEGIN
	SELECT * FROM Owners WHERE OwnerId = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[GetSpecificationId]    Script Date: 7/8/2024 10:28:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetSpecificationId] AS
BEGIN 
	SELECT TOP 1 SpecificationsId FROM dbo.Specifications ORDER BY SpecificationsId DESC
END
GO
/****** Object:  StoredProcedure [dbo].[GetVehiclesByIdOrSearchByName]    Script Date: 7/8/2024 10:28:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetVehiclesByIdOrSearchByName] (
	@Id INT, @Name NVARCHAR(100), @Type INT
) AS
BEGIN
				SELECT
                 v.VehiclesId, v.VehicleName, v.LiscensePlate, v.Color, 
                m.Name as ManufactureName,m.ManufacturesId as ManufacturesId , o.FullName as OwnerName,o.OwnerId as OwnerId , o.Email as OwnerEmail,
                s.EngineType, s.FuelType , s.Weigth, s.TopSpeed, s.Acceleration, s.EngineDisplacement
                 FROM Vehicles AS v 
                JOIN Specifications AS s
                 ON s.SpecificationsId = v.SpecificationsId 
                JOIN Manufactures AS m
                 ON m.ManufacturesId = v.ManufacturesId 
                JOIN Owners AS o
                 ON o.OwnerId = v.OwnerId 
				 WHERE (@Type = 1 AND v.VehiclesId = @Id) OR (@Type = 2 AND v.VehicleName LIKE @Name)

END		
GO
/****** Object:  StoredProcedure [dbo].[GetVehiclesByManufactureName]    Script Date: 7/8/2024 10:28:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetVehiclesByManufactureName] (
	@ManufactureName NVARCHAR(100)
) AS
BEGIN
	SELECT v.VehiclesId, v.VehicleName, v.LiscensePlate, v.Color,
       m.Name as ManufactureName,m.ManufacturesId as ManufacturesId , o.FullName as OwnerName,o.OwnerId as OwnerId , o.Email as OwnerEmail,         
       s.EngineType, s.FuelType , s.Weigth, s.TopSpeed, s.Acceleration, s.EngineDisplacement
		FROM Vehicles AS v 
        JOIN Specifications AS s
        ON s.SpecificationsId = v.SpecificationsId
        JOIN Manufactures AS m
        ON m.ManufacturesId = v.ManufacturesId 
        JOIN Owners AS o
        ON o.OwnerId = v.OwnerId 
        WHERE m.Name = @ManufactureName 
END
GO
/****** Object:  StoredProcedure [dbo].[SearchManufactureByName]    Script Date: 7/8/2024 10:28:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SearchManufactureByName] (
	@Name NVARCHAR(100)
) AS
BEGIN
	SELECT * FROM Manufactures WHERE Name LIKE @Name
END
GO
/****** Object:  StoredProcedure [dbo].[SearchOwnerByFullName]    Script Date: 7/8/2024 10:28:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SearchOwnerByFullName] (
	 @FullName NVARCHAR(100)
) AS
BEGIN
	SELECT * FROM Owners WHERE FullName LIKE @FullName
END
GO
/****** Object:  StoredProcedure [dbo].[SearchUserByUserName]    Script Date: 7/8/2024 10:28:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SearchUserByUserName] (
	@UserName NVARCHAR(100)
) AS
BEGIN
	SELECT * FROM Account WHERE UserName LIKE @UserName
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateManufacture]    Script Date: 7/8/2024 10:28:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROC [dbo].[UpdateManufacture] (
	@Name NVARCHAR(100) , @Icon NVARCHAR(100), @Id INT
) AS
BEGIN
	UPDATE Manufactures SET Name = @Name, Icon = @Icon WHERE ManufacturesId = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateOwner]    Script Date: 7/8/2024 10:28:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateOwner] (
	 @Email NVARCHAR(100), @Address NVARCHAR(100), @FullName NVARCHAR(100), @PhoneNumber NVARCHAR(100), @Id INT
) AS
BEGIN
	UPDATE Owners SET FullName = @FullName,
                    Email = @Email, Address = @Address,
                    PhoneNumber = @PhoneNumber
                    WHERE OwnerId = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[UpdatePassword]    Script Date: 7/8/2024 10:28:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdatePassword] (
	@UserName NVARCHAR(100), @Password NVARCHAR(100)
) AS
BEGIN
	UPDATE dbo.Account SET Password = @Password WHERE UserName = @UserName
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateSpecificationByVehiclesId]    Script Date: 7/8/2024 10:28:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateSpecificationByVehiclesId] (
	@EngineType NVARCHAR(100),@FuelType NVARCHAR(100) , @EngineDisplacement NVARCHAR(100) , @Weigth FLOAT , @TopSpeed FlOAT, @Acceleration FLOAT,
	@VehiclesId INT
) AS
BEGIN
			UPDATE dbo.Specifications SET 
                EngineType = @EngineType, 
                FuelType = @FuelType, 
                Weigth = @Weigth, 
                TopSpeed = @TopSpeed, 
                Acceleration = @Acceleration, 
                EngineDisplacement = @EngineDisplacement 
                WHERE SpecificationsId = 
                (SELECT SpecificationsId FROM dbo.Vehicles WHERE VehiclesId = @VehiclesId)
END	
GO
/****** Object:  StoredProcedure [dbo].[UpdateUser]    Script Date: 7/8/2024 10:28:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateUser] (
	@UserName NVARCHAR(100),@DisplayName NVARCHAR(100), @Password NVARCHAR(100), @Role NVARCHAR(100) , @Id INT, @Image NVARCHAR(200)
) AS
BEGIN
	UPDATE Account SET UserName = @UserName, DisplayName = @DisplayName, Password = @Password,Role = @Role, Image = @Image
 WHERE ID = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateVehicles]    Script Date: 7/8/2024 10:28:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateVehicles] (
	@VehicleName NVARCHAR(100),@LiscensePlate NVARCHAR(100) , @Color NVARCHAR(100) , @ManufacturesId INT , @OwnerId INT,
	@VehiclesId INT
) AS
BEGIN
		UPDATE dbo.Vehicles SET 
                VehicleName = @VehicleName, 
                LiscensePlate = @LiscensePlate, 
                Color = @Color, 
                ManufacturesId = @ManufacturesId, 
                OwnerId = @OwnerId
                WHERE VehiclesId = @VehiclesId
END
GO
