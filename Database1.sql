USE [master]
GO
/****** Object:  Database [khalid]    Script Date: 06/07/2022 07:42:30 م ******/
CREATE DATABASE [khalid]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'khalid', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\khalid.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'khalid_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\khalid_log.ldf' , SIZE = 2304KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [khalid] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [khalid].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [khalid] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [khalid] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [khalid] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [khalid] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [khalid] SET ARITHABORT OFF 
GO
ALTER DATABASE [khalid] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [khalid] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [khalid] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [khalid] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [khalid] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [khalid] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [khalid] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [khalid] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [khalid] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [khalid] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [khalid] SET  DISABLE_BROKER 
GO
ALTER DATABASE [khalid] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [khalid] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [khalid] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [khalid] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [khalid] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [khalid] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [khalid] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [khalid] SET RECOVERY FULL 
GO
ALTER DATABASE [khalid] SET  MULTI_USER 
GO
ALTER DATABASE [khalid] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [khalid] SET DB_CHAINING OFF 
GO
ALTER DATABASE [khalid] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [khalid] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'khalid', N'ON'
GO
USE [khalid]
GO
/****** Object:  Table [dbo].[employee]    Script Date: 06/07/2022 07:42:30 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[employee](
	[id] [int] NOT NULL,
	[name] [nvarchar](50) NULL,
	[mobile] [nvarchar](9) NULL,
	[sexId] [int] NULL,
	[pictures] [varbinary](max) NULL,
 CONSTRAINT [PK_employee] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[kids]    Script Date: 06/07/2022 07:42:30 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[kids](
	[id] [int] NOT NULL,
	[name] [varchar](25) NULL,
	[NumberFatherid] [int] NOT NULL,
	[sexid] [int] NOT NULL,
	[DateOfBirth] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[sex]    Script Date: 06/07/2022 07:42:30 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sex](
	[id] [int] NOT NULL,
	[nameSex] [nvarchar](6) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[users]    Script Date: 06/07/2022 07:42:30 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[passowrd] [varchar](50) NOT NULL,
	[username] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[sexview]    Script Date: 06/07/2022 07:42:30 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[sexview] as select * from sex;
GO
INSERT [dbo].[employee] ([id], [name], [mobile], [sexId], [pictures]) VALUES (1, N'Abbas', N'733622649', 1, NULL)
INSERT [dbo].[employee] ([id], [name], [mobile], [sexId], [pictures]) VALUES (2, N'khaled', N'735208453', 1, NULL)
INSERT [dbo].[employee] ([id], [name], [mobile], [sexId], [pictures]) VALUES (3, N'samie', N'54743', 1, NULL)
INSERT [dbo].[employee] ([id], [name], [mobile], [sexId], [pictures]) VALUES (4, N'aaa', N'535635', 0, NULL)
INSERT [dbo].[employee] ([id], [name], [mobile], [sexId], [pictures]) VALUES (5, N'wrg', N'245', 2, NULL)
INSERT [dbo].[employee] ([id], [name], [mobile], [sexId], [pictures]) VALUES (8, N'sgsgrwwr', NULL, NULL, NULL)
INSERT [dbo].[kids] ([id], [name], [NumberFatherid], [sexid], [DateOfBirth]) VALUES (1, N'rgr', 1, 1, CAST(0xC3150B00 AS Date))
INSERT [dbo].[kids] ([id], [name], [NumberFatherid], [sexid], [DateOfBirth]) VALUES (2, N'rgr', 1, 1, CAST(0xC3150B00 AS Date))
INSERT [dbo].[kids] ([id], [name], [NumberFatherid], [sexid], [DateOfBirth]) VALUES (3, N'dg', 1, 1, CAST(0x453F0B00 AS Date))
INSERT [dbo].[kids] ([id], [name], [NumberFatherid], [sexid], [DateOfBirth]) VALUES (4, N'fg', 2, 1, CAST(0xAD1D0B00 AS Date))
INSERT [dbo].[kids] ([id], [name], [NumberFatherid], [sexid], [DateOfBirth]) VALUES (5, N'fgch', 1, 1, CAST(0xAB400B00 AS Date))
INSERT [dbo].[kids] ([id], [name], [NumberFatherid], [sexid], [DateOfBirth]) VALUES (6, N'egdfdfg', 1, 1, CAST(0xD2420B00 AS Date))
INSERT [dbo].[kids] ([id], [name], [NumberFatherid], [sexid], [DateOfBirth]) VALUES (7, N'dgbdgb', 1, 1, CAST(0xD2420B00 AS Date))
INSERT [dbo].[kids] ([id], [name], [NumberFatherid], [sexid], [DateOfBirth]) VALUES (8, N'dgbdgb', 1, 1, CAST(0xD2420B00 AS Date))
INSERT [dbo].[kids] ([id], [name], [NumberFatherid], [sexid], [DateOfBirth]) VALUES (9, N'gfhf', 1, 1, CAST(0xD2420B00 AS Date))
INSERT [dbo].[kids] ([id], [name], [NumberFatherid], [sexid], [DateOfBirth]) VALUES (10, N'gfhfryh', 1, 1, CAST(0xD2420B00 AS Date))
INSERT [dbo].[kids] ([id], [name], [NumberFatherid], [sexid], [DateOfBirth]) VALUES (12, N'hj', 1, 2, CAST(0xD2420B00 AS Date))
INSERT [dbo].[kids] ([id], [name], [NumberFatherid], [sexid], [DateOfBirth]) VALUES (13, N'hjmjfhc', 1, 2, CAST(0xC52B0B00 AS Date))
INSERT [dbo].[kids] ([id], [name], [NumberFatherid], [sexid], [DateOfBirth]) VALUES (14, N'vnm', 2, 1, CAST(0xD2420B00 AS Date))
INSERT [dbo].[kids] ([id], [name], [NumberFatherid], [sexid], [DateOfBirth]) VALUES (15, N'', 2, 1, CAST(0xD2420B00 AS Date))
INSERT [dbo].[kids] ([id], [name], [NumberFatherid], [sexid], [DateOfBirth]) VALUES (16, N'', 1, 2, CAST(0xD2420B00 AS Date))
INSERT [dbo].[kids] ([id], [name], [NumberFatherid], [sexid], [DateOfBirth]) VALUES (17, N'', 3, 2, CAST(0xD2420B00 AS Date))
INSERT [dbo].[kids] ([id], [name], [NumberFatherid], [sexid], [DateOfBirth]) VALUES (18, N'', 3, 2, CAST(0xD2420B00 AS Date))
INSERT [dbo].[kids] ([id], [name], [NumberFatherid], [sexid], [DateOfBirth]) VALUES (19, N'rhjfhj', 3, 2, CAST(0xD2420B00 AS Date))
INSERT [dbo].[kids] ([id], [name], [NumberFatherid], [sexid], [DateOfBirth]) VALUES (20, N'mvbm', 3, 2, CAST(0xD2420B00 AS Date))
INSERT [dbo].[sex] ([id], [nameSex]) VALUES (1, N'Male')
INSERT [dbo].[sex] ([id], [nameSex]) VALUES (2, N'Famale')
SET IDENTITY_INSERT [dbo].[users] ON 

INSERT [dbo].[users] ([id], [passowrd], [username]) VALUES (1, N'admin', N'admin')
INSERT [dbo].[users] ([id], [passowrd], [username]) VALUES (2, N'aa', N'aa')
INSERT [dbo].[users] ([id], [passowrd], [username]) VALUES (4, N'123', N'kaka')
INSERT [dbo].[users] ([id], [passowrd], [username]) VALUES (1003, N'1999', N'soso')
SET IDENTITY_INSERT [dbo].[users] OFF
ALTER TABLE [dbo].[employee]  WITH NOCHECK ADD FOREIGN KEY([sexId])
REFERENCES [dbo].[sex] ([id])
GO
ALTER TABLE [dbo].[kids]  WITH CHECK ADD FOREIGN KEY([sexid])
REFERENCES [dbo].[sex] ([id])
GO
ALTER TABLE [dbo].[kids]  WITH CHECK ADD  CONSTRAINT [fkNumF] FOREIGN KEY([NumberFatherid])
REFERENCES [dbo].[employee] ([id])
GO
ALTER TABLE [dbo].[kids] CHECK CONSTRAINT [fkNumF]
GO
USE [master]
GO
ALTER DATABASE [khalid] SET  READ_WRITE 
GO
