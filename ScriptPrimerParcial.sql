USE [master]
GO
/****** Object:  Database [TDPrimerParcial]    Script Date: 04/10/2024 17:07:27 ******/
CREATE DATABASE [TDPrimerParcial]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TDPrimerParcial', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLDEVELOPER\MSSQL\DATA\TDPrimerParcial.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TDPrimerParcial_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLDEVELOPER\MSSQL\DATA\TDPrimerParcial_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [TDPrimerParcial] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TDPrimerParcial].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TDPrimerParcial] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TDPrimerParcial] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TDPrimerParcial] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TDPrimerParcial] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TDPrimerParcial] SET ARITHABORT OFF 
GO
ALTER DATABASE [TDPrimerParcial] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TDPrimerParcial] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TDPrimerParcial] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TDPrimerParcial] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TDPrimerParcial] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TDPrimerParcial] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TDPrimerParcial] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TDPrimerParcial] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TDPrimerParcial] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TDPrimerParcial] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TDPrimerParcial] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TDPrimerParcial] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TDPrimerParcial] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TDPrimerParcial] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TDPrimerParcial] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TDPrimerParcial] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TDPrimerParcial] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TDPrimerParcial] SET RECOVERY FULL 
GO
ALTER DATABASE [TDPrimerParcial] SET  MULTI_USER 
GO
ALTER DATABASE [TDPrimerParcial] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TDPrimerParcial] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TDPrimerParcial] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TDPrimerParcial] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TDPrimerParcial] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TDPrimerParcial] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TDPrimerParcial', N'ON'
GO
ALTER DATABASE [TDPrimerParcial] SET QUERY_STORE = ON
GO
ALTER DATABASE [TDPrimerParcial] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [TDPrimerParcial]
GO
/****** Object:  Table [dbo].[Misiones]    Script Date: 04/10/2024 17:07:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Misiones](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FechaHora] [datetime] NOT NULL,
	[ValorSensor1] [bit] NOT NULL,
	[ValorSensor2] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Misiones] ON 

INSERT [dbo].[Misiones] ([Id], [FechaHora], [ValorSensor1], [ValorSensor2]) VALUES (1, CAST(N'2024-10-04T00:00:31.373' AS DateTime), 1, 0)
INSERT [dbo].[Misiones] ([Id], [FechaHora], [ValorSensor1], [ValorSensor2]) VALUES (2, CAST(N'2024-10-04T00:00:51.403' AS DateTime), 1, 0)
INSERT [dbo].[Misiones] ([Id], [FechaHora], [ValorSensor1], [ValorSensor2]) VALUES (3, CAST(N'2024-10-04T00:14:53.897' AS DateTime), 1, 0)
SET IDENTITY_INSERT [dbo].[Misiones] OFF
GO
USE [master]
GO
ALTER DATABASE [TDPrimerParcial] SET  READ_WRITE 
GO
