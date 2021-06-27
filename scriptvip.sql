USE [master]
GO
/****** Object:  Database [TicTacToe]    Script Date: 27/06/2021 22:01:46 ******/
CREATE DATABASE [TicTacToe]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TicTacToe', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TicTacToe.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TicTacToe_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TicTacToe_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TicTacToe] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TicTacToe].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TicTacToe] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TicTacToe] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TicTacToe] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TicTacToe] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TicTacToe] SET ARITHABORT OFF 
GO
ALTER DATABASE [TicTacToe] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TicTacToe] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TicTacToe] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TicTacToe] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TicTacToe] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TicTacToe] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TicTacToe] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TicTacToe] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TicTacToe] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TicTacToe] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TicTacToe] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TicTacToe] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TicTacToe] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TicTacToe] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TicTacToe] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TicTacToe] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TicTacToe] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TicTacToe] SET RECOVERY FULL 
GO
ALTER DATABASE [TicTacToe] SET  MULTI_USER 
GO
ALTER DATABASE [TicTacToe] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TicTacToe] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TicTacToe] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TicTacToe] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TicTacToe] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TicTacToe] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TicTacToe', N'ON'
GO
ALTER DATABASE [TicTacToe] SET QUERY_STORE = OFF
GO
USE [TicTacToe]
GO
/****** Object:  Table [dbo].[bangxephang]    Script Date: 27/06/2021 22:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bangxephang](
	[taikhoan] [varchar](50) NULL,
	[score] [int] NULL,
	[win] [varchar](50) NULL,
	[lose] [varchar](50) NULL,
	[draw] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lichsu]    Script Date: 27/06/2021 22:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lichsu](
	[taikhoan] [varchar](50) NULL,
	[doithu] [varchar](50) NULL,
	[thoigian] [varchar](50) NULL,
	[result] [varchar](50) NULL,
	[bonusscore] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[userpass]    Script Date: 27/06/2021 22:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[userpass](
	[taikhoan] [varchar](50) NOT NULL,
	[matkhau] [varchar](50) NULL,
	[thoigian] [varchar](50) NULL,
	[ten] [varchar](50) NULL,
 CONSTRAINT [PK_nguoichoi] PRIMARY KEY CLUSTERED 
(
	[taikhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[bangxephang] ([taikhoan], [score], [win], [lose], [draw]) VALUES (N'hung', 0, N'0', N'0', N'0')
INSERT [dbo].[bangxephang] ([taikhoan], [score], [win], [lose], [draw]) VALUES (N'hieu', 0, N'0', N'0', N'0')
GO
INSERT [dbo].[userpass] ([taikhoan], [matkhau], [thoigian], [ten]) VALUES (N'hieu', N'hieu', N'27/06/2021 18:10:37', N'hieu')
INSERT [dbo].[userpass] ([taikhoan], [matkhau], [thoigian], [ten]) VALUES (N'hung', N'hung', N'27/06/2021 18:10:02', N'hung')
GO
USE [master]
GO
ALTER DATABASE [TicTacToe] SET  READ_WRITE 
GO
