USE [master]
GO
/****** Object:  Database [cyper8]    Script Date: 1.11.2019 18:42:01 ******/
CREATE DATABASE [cyper8]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'cyper8', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\cyper8.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'cyper8_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\cyper8_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [cyper8] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [cyper8].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [cyper8] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [cyper8] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [cyper8] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [cyper8] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [cyper8] SET ARITHABORT OFF 
GO
ALTER DATABASE [cyper8] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [cyper8] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [cyper8] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [cyper8] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [cyper8] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [cyper8] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [cyper8] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [cyper8] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [cyper8] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [cyper8] SET  DISABLE_BROKER 
GO
ALTER DATABASE [cyper8] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [cyper8] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [cyper8] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [cyper8] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [cyper8] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [cyper8] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [cyper8] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [cyper8] SET RECOVERY FULL 
GO
ALTER DATABASE [cyper8] SET  MULTI_USER 
GO
ALTER DATABASE [cyper8] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [cyper8] SET DB_CHAINING OFF 
GO
ALTER DATABASE [cyper8] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [cyper8] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [cyper8] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [cyper8] SET QUERY_STORE = OFF
GO
USE [cyper8]
GO
/****** Object:  Table [dbo].[TBL_KULLANICI_GIRIS]    Script Date: 1.11.2019 18:42:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_KULLANICI_GIRIS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[K_ADI] [nvarchar](50) NULL,
	[SIFRE] [nchar](10) NULL,
 CONSTRAINT [PK_TBL_KULLANICI_GIRIS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_SIRKET_SECIMI]    Script Date: 1.11.2019 18:42:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_SIRKET_SECIMI](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[KODU] [nvarchar](50) NULL,
	[KISADI] [nvarchar](20) NULL,
	[TICARIUNVAN] [nvarchar](50) NULL,
	[YETKILISI] [nvarchar](50) NULL,
 CONSTRAINT [PK_TBL_SIRKET_SECIMI] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TBL_KULLANICI_GIRIS] ON 

INSERT [dbo].[TBL_KULLANICI_GIRIS] ([ID], [K_ADI], [SIFRE]) VALUES (1, N'adem', N'1234      ')
INSERT [dbo].[TBL_KULLANICI_GIRIS] ([ID], [K_ADI], [SIFRE]) VALUES (2, N'demo', N'demo      ')
SET IDENTITY_INSERT [dbo].[TBL_KULLANICI_GIRIS] OFF
SET IDENTITY_INSERT [dbo].[TBL_SIRKET_SECIMI] ON 

INSERT [dbo].[TBL_SIRKET_SECIMI] ([ID], [KODU], [KISADI], [TICARIUNVAN], [YETKILISI]) VALUES (1, N'DEMOCYPER8', N'DEMOCYPER8', N'DEMOCYPER8', NULL)
INSERT [dbo].[TBL_SIRKET_SECIMI] ([ID], [KODU], [KISADI], [TICARIUNVAN], [YETKILISI]) VALUES (2, N'yeni', N'yeni', N'yeni', NULL)
SET IDENTITY_INSERT [dbo].[TBL_SIRKET_SECIMI] OFF
USE [master]
GO
ALTER DATABASE [cyper8] SET  READ_WRITE 
GO
