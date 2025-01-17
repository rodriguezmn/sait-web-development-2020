USE [master]
GO
/****** Object:  Database [ITAssets]    Script Date: 2020-05-10 4:47:22 PM ******/
CREATE DATABASE [ITAssets]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ITAssets', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ITAssets.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ITAssets_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ITAssets_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ITAssets] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ITAssets].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ITAssets] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ITAssets] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ITAssets] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ITAssets] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ITAssets] SET ARITHABORT OFF 
GO
ALTER DATABASE [ITAssets] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ITAssets] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ITAssets] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ITAssets] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ITAssets] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ITAssets] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ITAssets] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ITAssets] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ITAssets] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ITAssets] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ITAssets] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ITAssets] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ITAssets] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ITAssets] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ITAssets] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ITAssets] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [ITAssets] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ITAssets] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ITAssets] SET  MULTI_USER 
GO
ALTER DATABASE [ITAssets] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ITAssets] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ITAssets] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ITAssets] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ITAssets] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ITAssets] SET QUERY_STORE = OFF
GO
USE [ITAssets]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 2020-05-10 4:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Asset]    Script Date: 2020-05-10 4:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asset](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TagNumber] [nvarchar](max) NOT NULL,
	[AssetTypeId] [int] NOT NULL,
	[Manufacturer] [nvarchar](max) NOT NULL,
	[Model] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NOT NULL,
	[SerialNumber] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Asset] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AssetType]    Script Date: 2020-05-10 4:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AssetType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_AssetType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200502224748_CreateAssestsIT', N'3.1.2')
GO
SET IDENTITY_INSERT [dbo].[Asset] ON 

INSERT [dbo].[Asset] ([Id], [TagNumber], [AssetTypeId], [Manufacturer], [Model], [Description], [SerialNumber]) VALUES (1, N'1002001', 2, N'LG', N'38GL950G-B', N'37.5" Class 21:9 UltraGear™ Nano IPS 1ms Curved Gaming Monitor w / G - Sync®', N'N1000401')
INSERT [dbo].[Asset] ([Id], [TagNumber], [AssetTypeId], [Manufacturer], [Model], [Description], [SerialNumber]) VALUES (2, N'1002002', 2, N'LG', N'34WL850-W', N'34" 21:9 UltraWide® WQHD Nano IPS Monitor with Thunderbolt™ 3', N'N1000402')
INSERT [dbo].[Asset] ([Id], [TagNumber], [AssetTypeId], [Manufacturer], [Model], [Description], [SerialNumber]) VALUES (3, N'1001001', 1, N'HP', N'33BC850-W', N'Intel® Core™ i7-9700T (2 GHz base frequency, up to 4.3 GHz with Intel® Turbo Boost Technology, 12 MB cache, 8 cores)', N'D1000402')
INSERT [dbo].[Asset] ([Id], [TagNumber], [AssetTypeId], [Manufacturer], [Model], [Description], [SerialNumber]) VALUES (4, N'1003001', 3, N'Cisco', N'IPPhone-8800', N'The Cisco IP Phone 8800 Series is a great fit for businesses of all sizes seeking secure, high-quality, full-featured VoIP.', N'C1000402')
INSERT [dbo].[Asset] ([Id], [TagNumber], [AssetTypeId], [Manufacturer], [Model], [Description], [SerialNumber]) VALUES (8, N'1001002', 1, N'HP', N'33BC850-P', N'Intel® Xeon® W2133 (3.6 GHz base frequency, up to 3.9 GHz with Intel® Turbo Boost Technology, 8.25 MB cache, 6 cores)', N'D1000403')
INSERT [dbo].[Asset] ([Id], [TagNumber], [AssetTypeId], [Manufacturer], [Model], [Description], [SerialNumber]) VALUES (9, N'1001003', 1, N'HP', N'33BC850-Z', N'Experience server-grade power in a desktop with impressive expandability. Cut through complex BIM, rendering and visualization projects with high-performance graphics and Intel® processors.', N'D1000404')
INSERT [dbo].[Asset] ([Id], [TagNumber], [AssetTypeId], [Manufacturer], [Model], [Description], [SerialNumber]) VALUES (10, N'1001004', 1, N'HP', N'33BC850-Z', N'Experience server-grade power in a desktop with impressive expandability. Cut through complex BIM, rendering and visualization projects with high-performance graphics and Intel® processors.', N'D1000405')
INSERT [dbo].[Asset] ([Id], [TagNumber], [AssetTypeId], [Manufacturer], [Model], [Description], [SerialNumber]) VALUES (11, N'1001001', 3, N'Cisco', N'33BC850-E', N'This 2-line model is ideal for information workers and teleworkers who have light-to-moderate voice communications needs.', N'78217821')
SET IDENTITY_INSERT [dbo].[Asset] OFF
GO
SET IDENTITY_INSERT [dbo].[AssetType] ON 

INSERT [dbo].[AssetType] ([Id], [Name]) VALUES (1, N'Desktop Computer')
INSERT [dbo].[AssetType] ([Id], [Name]) VALUES (2, N'Computer Monitor')
INSERT [dbo].[AssetType] ([Id], [Name]) VALUES (3, N'Phone')
INSERT [dbo].[AssetType] ([Id], [Name]) VALUES (4, N'Keyboard')
INSERT [dbo].[AssetType] ([Id], [Name]) VALUES (5, N'Mouse')
INSERT [dbo].[AssetType] ([Id], [Name]) VALUES (7, N'Mouse Pad')
INSERT [dbo].[AssetType] ([Id], [Name]) VALUES (8, N'USB Cable')
INSERT [dbo].[AssetType] ([Id], [Name]) VALUES (9, N'Handset')
INSERT [dbo].[AssetType] ([Id], [Name]) VALUES (10, N'Calculator')
INSERT [dbo].[AssetType] ([Id], [Name]) VALUES (11, N'Earphones')
INSERT [dbo].[AssetType] ([Id], [Name]) VALUES (12, N'HDMI cable')
SET IDENTITY_INSERT [dbo].[AssetType] OFF
GO
/****** Object:  Index [IX_Asset_AssetTypeId]    Script Date: 2020-05-10 4:47:22 PM ******/
CREATE NONCLUSTERED INDEX [IX_Asset_AssetTypeId] ON [dbo].[Asset]
(
	[AssetTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Asset]  WITH CHECK ADD  CONSTRAINT [FK_Asset_AssetType_AssetTypeId] FOREIGN KEY([AssetTypeId])
REFERENCES [dbo].[AssetType] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Asset] CHECK CONSTRAINT [FK_Asset_AssetType_AssetTypeId]
GO
USE [master]
GO
ALTER DATABASE [ITAssets] SET  READ_WRITE 
GO
