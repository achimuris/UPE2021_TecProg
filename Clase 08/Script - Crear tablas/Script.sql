USE [UPE_EXCEPCIONES_2021]
GO
/****** Object:  StoredProcedure [dbo].[sp_listar_clientes]    Script Date: 4/5/2021 08:43:22 ******/
DROP PROCEDURE IF EXISTS [dbo].[sp_listar_clientes]
GO
/****** Object:  StoredProcedure [dbo].[sp_crear_cliente]    Script Date: 4/5/2021 08:43:22 ******/
DROP PROCEDURE IF EXISTS [dbo].[sp_crear_cliente]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tCliente]') AND type in (N'U'))
ALTER TABLE [dbo].[tCliente] DROP CONSTRAINT IF EXISTS [FK_tCliente_tTipoCliente]
GO
/****** Object:  Table [dbo].[tTipoCliente]    Script Date: 4/5/2021 08:43:22 ******/
DROP TABLE IF EXISTS [dbo].[tTipoCliente]
GO
/****** Object:  Table [dbo].[tCliente]    Script Date: 4/5/2021 08:43:22 ******/
DROP TABLE IF EXISTS [dbo].[tCliente]
GO
USE [master]
GO
/****** Object:  Database [UPE_EXCEPCIONES_2021]    Script Date: 4/5/2021 08:43:22 ******/
DROP DATABASE IF EXISTS [UPE_EXCEPCIONES_2021]
GO
/****** Object:  Database [UPE_EXCEPCIONES_2021]    Script Date: 4/5/2021 08:43:22 ******/
CREATE DATABASE [UPE_EXCEPCIONES_2021]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'UPE_EXCEPCIONES_2021', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\UPE_EXCEPCIONES_2021.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'UPE_EXCEPCIONES_2021_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\UPE_EXCEPCIONES_2021_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [UPE_EXCEPCIONES_2021] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [UPE_EXCEPCIONES_2021].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [UPE_EXCEPCIONES_2021] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [UPE_EXCEPCIONES_2021] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [UPE_EXCEPCIONES_2021] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [UPE_EXCEPCIONES_2021] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [UPE_EXCEPCIONES_2021] SET ARITHABORT OFF 
GO
ALTER DATABASE [UPE_EXCEPCIONES_2021] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [UPE_EXCEPCIONES_2021] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [UPE_EXCEPCIONES_2021] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [UPE_EXCEPCIONES_2021] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [UPE_EXCEPCIONES_2021] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [UPE_EXCEPCIONES_2021] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [UPE_EXCEPCIONES_2021] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [UPE_EXCEPCIONES_2021] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [UPE_EXCEPCIONES_2021] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [UPE_EXCEPCIONES_2021] SET  DISABLE_BROKER 
GO
ALTER DATABASE [UPE_EXCEPCIONES_2021] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [UPE_EXCEPCIONES_2021] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [UPE_EXCEPCIONES_2021] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [UPE_EXCEPCIONES_2021] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [UPE_EXCEPCIONES_2021] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [UPE_EXCEPCIONES_2021] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [UPE_EXCEPCIONES_2021] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [UPE_EXCEPCIONES_2021] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [UPE_EXCEPCIONES_2021] SET  MULTI_USER 
GO
ALTER DATABASE [UPE_EXCEPCIONES_2021] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [UPE_EXCEPCIONES_2021] SET DB_CHAINING OFF 
GO
ALTER DATABASE [UPE_EXCEPCIONES_2021] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [UPE_EXCEPCIONES_2021] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [UPE_EXCEPCIONES_2021] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [UPE_EXCEPCIONES_2021] SET QUERY_STORE = OFF
GO
USE [UPE_EXCEPCIONES_2021]
GO
/****** Object:  Table [dbo].[tCliente]    Script Date: 4/5/2021 08:43:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tCliente](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[fecha_nacimiento] [date] NOT NULL,
	[nombre_cliente] [nvarchar](50) NOT NULL,
	[apellido_cliente] [nvarchar](50) NOT NULL,
	[id_tipo] [int] NULL,
 CONSTRAINT [PK_tCliente] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tTipoCliente]    Script Date: 4/5/2021 08:43:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tTipoCliente](
	[id_tipo_cliente] [int] NOT NULL,
	[descripcion_tipocliente] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tTipoCliente] PRIMARY KEY CLUSTERED 
(
	[id_tipo_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tCliente] ON 

INSERT [dbo].[tCliente] ([id_cliente], [fecha_nacimiento], [nombre_cliente], [apellido_cliente], [id_tipo]) VALUES (1, CAST(N'2021-05-03' AS Date), N'', N'', NULL)
INSERT [dbo].[tCliente] ([id_cliente], [fecha_nacimiento], [nombre_cliente], [apellido_cliente], [id_tipo]) VALUES (2, CAST(N'2000-01-01' AS Date), N'fff', N'fff', NULL)
SET IDENTITY_INSERT [dbo].[tCliente] OFF
GO
ALTER TABLE [dbo].[tCliente]  WITH CHECK ADD  CONSTRAINT [FK_tCliente_tTipoCliente] FOREIGN KEY([id_tipo])
REFERENCES [dbo].[tTipoCliente] ([id_tipo_cliente])
GO
ALTER TABLE [dbo].[tCliente] CHECK CONSTRAINT [FK_tCliente_tTipoCliente]
GO
/****** Object:  StoredProcedure [dbo].[sp_crear_cliente]    Script Date: 4/5/2021 08:43:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_crear_cliente]
	@pNombre nvarchar(50),
	@pApellido nvarchar(50),
	@pFechaNacimiento date
as

	insert into tCliente 
	(nombre_cliente, apellido_cliente, fecha_nacimiento)
	values
	(@pNombre, @pApellido, @pFechaNacimiento)
GO
/****** Object:  StoredProcedure [dbo].[sp_listar_clientes]    Script Date: 4/5/2021 08:43:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_listar_clientes]

as



SELECT [id_cliente]
      ,[fecha_nacimiento]
      ,[nombre_cliente]
      ,[apellido_cliente]
      ,[id_tipo]
  FROM [dbo].[tCliente]

GO
USE [master]
GO
ALTER DATABASE [UPE_EXCEPCIONES_2021] SET  READ_WRITE 
GO
