USE [master]
GO
/****** Object:  Database [Video_Rental_Sys]    Script Date: 2/21/2020 11:13:57 AM ******/
CREATE DATABASE [Video_Rental_Sys]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Video_Rental_Sys_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Video_Rental_Sys.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Video_Rental_Sys_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Video_Rental_Sys.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Video_Rental_Sys] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Video_Rental_Sys].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Video_Rental_Sys] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Video_Rental_Sys] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Video_Rental_Sys] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Video_Rental_Sys] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Video_Rental_Sys] SET ARITHABORT OFF 
GO
ALTER DATABASE [Video_Rental_Sys] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Video_Rental_Sys] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Video_Rental_Sys] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Video_Rental_Sys] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Video_Rental_Sys] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Video_Rental_Sys] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Video_Rental_Sys] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Video_Rental_Sys] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Video_Rental_Sys] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Video_Rental_Sys] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Video_Rental_Sys] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Video_Rental_Sys] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Video_Rental_Sys] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Video_Rental_Sys] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Video_Rental_Sys] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Video_Rental_Sys] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Video_Rental_Sys] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Video_Rental_Sys] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Video_Rental_Sys] SET  MULTI_USER 
GO
ALTER DATABASE [Video_Rental_Sys] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Video_Rental_Sys] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Video_Rental_Sys] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Video_Rental_Sys] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Video_Rental_Sys] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Video_Rental_Sys] SET QUERY_STORE = OFF
GO
USE [Video_Rental_Sys]
GO
/****** Object:  Table [dbo].[Customer_Cunt]    Script Date: 2/21/2020 11:13:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer_Cunt](
	[CustomerID] [int] NULL,
	[CountNo] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer_Record]    Script Date: 2/21/2020 11:13:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer_Record](
	[Customer_ID] [int] IDENTITY(1,1) NOT NULL,
	[Customer_FirstName] [varchar](50) NULL,
	[Customer_LastName] [varchar](50) NULL,
	[Customer_Mobile] [varchar](50) NULL,
	[Customer_Address] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rental_Record]    Script Date: 2/21/2020 11:13:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rental_Record](
	[Rental_ID] [int] IDENTITY(1,1) NOT NULL,
	[Customer_ID] [varchar](50) NULL,
	[Movie_ID] [varchar](50) NULL,
	[Rental_Date] [varchar](50) NULL,
	[Return_Date] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Video_Cunt]    Script Date: 2/21/2020 11:13:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Video_Cunt](
	[MovieID] [int] NULL,
	[CountNo] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Video_Record]    Script Date: 2/21/2020 11:13:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Video_Record](
	[Video_ID] [int] IDENTITY(1,1) NOT NULL,
	[Video_Title] [varchar](50) NULL,
	[Video_Ratting] [varchar](50) NULL,
	[Video_Year] [int] NULL,
	[Video_Cost] [int] NULL,
	[Video_Copies] [int] NULL,
	[Video_Plot] [varchar](50) NULL,
	[Video_Genre] [varchar](50) NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [Video_Rental_Sys] SET  READ_WRITE 
GO
