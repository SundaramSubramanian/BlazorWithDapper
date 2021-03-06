USE [master]
GO
/****** Object:  Database [DapperDemo]    Script Date: 15-08-2021 08:01:16 ******/
CREATE DATABASE [DapperDemo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DapperDemo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DapperDemo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DapperDemo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DapperDemo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DapperDemo] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DapperDemo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DapperDemo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DapperDemo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DapperDemo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DapperDemo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DapperDemo] SET ARITHABORT OFF 
GO
ALTER DATABASE [DapperDemo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DapperDemo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DapperDemo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DapperDemo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DapperDemo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DapperDemo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DapperDemo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DapperDemo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DapperDemo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DapperDemo] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DapperDemo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DapperDemo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DapperDemo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DapperDemo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DapperDemo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DapperDemo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DapperDemo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DapperDemo] SET RECOVERY FULL 
GO
ALTER DATABASE [DapperDemo] SET  MULTI_USER 
GO
ALTER DATABASE [DapperDemo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DapperDemo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DapperDemo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DapperDemo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DapperDemo] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DapperDemo] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DapperDemo', N'ON'
GO
ALTER DATABASE [DapperDemo] SET QUERY_STORE = OFF
GO
USE [DapperDemo]
GO
/****** Object:  Schema [DemoWorks]    Script Date: 15-08-2021 08:01:16 ******/
CREATE SCHEMA [DemoWorks]
GO
/****** Object:  Table [DemoWorks].[Sales]    Script Date: 15-08-2021 08:01:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [DemoWorks].[Sales](
	[SalesId] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](100) NULL,
	[Quantity] [int] NULL,
	[CreatedDt] [datetime2](7) NULL,
	[UpdatedDt] [datetime2](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[SalesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [DemoWorks].[Sales] ADD  DEFAULT (getdate()) FOR [CreatedDt]
GO
/****** Object:  StoredProcedure [DemoWorks].[DeleteSales]    Script Date: 15-08-2021 08:01:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [DemoWorks].[DeleteSales]
(
	@SalesId INT
)
AS 
BEGIN 
	DELETE FROM DemoWorks.Sales 
	WHERE SalesId=@SalesId
END 
GO
/****** Object:  StoredProcedure [DemoWorks].[GetSalesById]    Script Date: 15-08-2021 08:01:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [DemoWorks].[GetSalesById]
(
	@SalesId INT
)
AS 
BEGIN 

	SELECT 
		SalesId,
		ProductName,
		Quantity
	FROM DemoWorks.Sales
	WHERE SalesId=@SalesId

END
GO
/****** Object:  StoredProcedure [DemoWorks].[GetSalesDetails]    Script Date: 15-08-2021 08:01:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [DemoWorks].[GetSalesDetails]
AS 
BEGIN 
		SELECT 
			SalesId, 
			ProductName, 
			Quantity  
		FROM DemoWorks.Sales
END
GO
/****** Object:  StoredProcedure [DemoWorks].[SaveSalesDetails]    Script Date: 15-08-2021 08:01:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [DemoWorks].[SaveSalesDetails]
(

	@ProductName NVARCHAR(100),
	@Quantity INT
)
AS 
BEGIN 
		INSERT INTO DemoWorks.Sales 
		(
			ProductName,
			Quantity
		) 
		VALUES 
		(
			@ProductName,
			@Quantity
		)
END
GO
/****** Object:  StoredProcedure [DemoWorks].[UpdateSales]    Script Date: 15-08-2021 08:01:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [DemoWorks].[UpdateSales]
(
	@ProductName NVARCHAR(100),
	@Quantity INT,
	@SalesId INT

)
AS 
BEGIN 

	UPDATE DemoWorks.Sales SET 
		ProductName=@ProductName, 
		Quantity=@Quantity 
	WHERE SalesId=@SalesId
END 
GO
USE [master]
GO
ALTER DATABASE [DapperDemo] SET  READ_WRITE 
GO
