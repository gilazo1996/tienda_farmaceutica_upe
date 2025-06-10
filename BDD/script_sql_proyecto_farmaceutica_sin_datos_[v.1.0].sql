USE [master]
GO
/****** Object:  Database [proyecto_farmaceutica]    Script Date: 22/05/2025 3:32:00 ******/
CREATE DATABASE [proyecto_farmaceutica]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'proyecto_farmaceutica', FILENAME = N'D:\Archivos de programa 2\SQL Server 2017\MSSQL14.SQLEXPRESS\MSSQL\DATA\proyecto_farmaceutica.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'proyecto_farmaceutica_log', FILENAME = N'D:\Archivos de programa 2\SQL Server 2017\MSSQL14.SQLEXPRESS\MSSQL\DATA\proyecto_farmaceutica_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [proyecto_farmaceutica] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [proyecto_farmaceutica].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [proyecto_farmaceutica] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [proyecto_farmaceutica] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [proyecto_farmaceutica] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [proyecto_farmaceutica] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [proyecto_farmaceutica] SET ARITHABORT OFF 
GO
ALTER DATABASE [proyecto_farmaceutica] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [proyecto_farmaceutica] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [proyecto_farmaceutica] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [proyecto_farmaceutica] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [proyecto_farmaceutica] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [proyecto_farmaceutica] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [proyecto_farmaceutica] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [proyecto_farmaceutica] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [proyecto_farmaceutica] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [proyecto_farmaceutica] SET  DISABLE_BROKER 
GO
ALTER DATABASE [proyecto_farmaceutica] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [proyecto_farmaceutica] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [proyecto_farmaceutica] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [proyecto_farmaceutica] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [proyecto_farmaceutica] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [proyecto_farmaceutica] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [proyecto_farmaceutica] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [proyecto_farmaceutica] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [proyecto_farmaceutica] SET  MULTI_USER 
GO
ALTER DATABASE [proyecto_farmaceutica] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [proyecto_farmaceutica] SET DB_CHAINING OFF 
GO
ALTER DATABASE [proyecto_farmaceutica] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [proyecto_farmaceutica] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [proyecto_farmaceutica] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [proyecto_farmaceutica] SET QUERY_STORE = OFF
GO
USE [proyecto_farmaceutica]
GO
/****** Object:  Table [dbo].[accion_terapeutica]    Script Date: 22/05/2025 3:32:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[accion_terapeutica](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_accion_terapeutica] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[administracion_via]    Script Date: 22/05/2025 3:32:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[administracion_via](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_administracion_via] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[administrador]    Script Date: 22/05/2025 3:32:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[administrador](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_usuario] [int] NOT NULL,
 CONSTRAINT [PK_administrador] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_factura]    Script Date: 22/05/2025 3:32:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_factura](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_factura] [int] NOT NULL,
	[id_farmaco] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[subtotal] [decimal](9, 2) NOT NULL,
	[total] [decimal](9, 2) NOT NULL,
 CONSTRAINT [PK_detalle_factura] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[estado]    Script Date: 22/05/2025 3:32:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estado](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](10) NOT NULL,
 CONSTRAINT [PK_estado] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[estado_factura]    Script Date: 22/05/2025 3:32:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estado_factura](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_estado_factura] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[factura]    Script Date: 22/05/2025 3:32:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[factura](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nro_factura] [char](11) NOT NULL,
	[fecha_emision] [date] NOT NULL,
	[hora_emision] [time](2) NOT NULL,
	[id_vendedor] [int] NOT NULL,
	[id_cliente] [int] NULL,
	[id_metodo_pago] [int] NOT NULL,
	[id_estado_factura] [int] NOT NULL,
 CONSTRAINT [PK_factura] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[farmaceutico]    Script Date: 22/05/2025 3:32:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[farmaceutico](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_usuario] [int] NOT NULL,
	[cuil_farmaceutico] [varchar](13) NOT NULL,
 CONSTRAINT [PK_farmaceutico] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[farmaco]    Script Date: 22/05/2025 3:32:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[farmaco](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre_comercial] [varchar](70) NOT NULL,
	[codigo_farmaco] [varchar](50) NOT NULL,
	[id_principio_activo] [int] NOT NULL,
	[id_accion_terapeutica] [int] NOT NULL,
	[id_forma_farmaceutica] [int] NOT NULL,
	[id_administracion_via] [int] NOT NULL,
	[id_origen_fuente] [int] NOT NULL,
	[laboratorio] [varchar](70) NOT NULL,
	[codigo_barras] [char](13) NOT NULL,
	[fecha_vencimiento] [date] NOT NULL,
	[precio_unidad] [decimal](9, 2) NOT NULL,
	[requiere_receta] [char](2) NOT NULL,
	[stock] [int] NOT NULL,
	[id_proveedor] [int] NOT NULL,
 CONSTRAINT [PK_farmaco] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[forma_farmaceutica]    Script Date: 22/05/2025 3:32:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[forma_farmaceutica](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_forma_farmaceutica] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[gerente]    Script Date: 22/05/2025 3:32:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[gerente](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_usuario] [int] NOT NULL,
	[cuil_gerente] [varchar](13) NOT NULL,
 CONSTRAINT [PK_gerente] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[metodo_de_pago]    Script Date: 22/05/2025 3:32:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[metodo_de_pago](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_metodo_de_pago] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[origen_fuente]    Script Date: 22/05/2025 3:32:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[origen_fuente](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_origen_fuente] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[permiso]    Script Date: 22/05/2025 3:32:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[permiso](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_permiso] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[posicion_iva]    Script Date: 22/05/2025 3:32:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[posicion_iva](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_posicion_iva] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[principio_activo]    Script Date: 22/05/2025 3:32:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[principio_activo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_principio_activo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[proveedor]    Script Date: 22/05/2025 3:32:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[proveedor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](70) NOT NULL,
	[nro_telefono] [char](13) NULL,
	[email] [nvarchar](70) NOT NULL,
	[direccion] [varchar](70) NOT NULL,
	[cuit] [char](13) NOT NULL,
	[id_posicion_iva] [int] NOT NULL,
	[persona_contacto] [varchar](70) NULL,
	[id_metodo_pago] [int] NULL,
 CONSTRAINT [PK_proveedor] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rol]    Script Date: 22/05/2025 3:32:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rol](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](13) NOT NULL,
 CONSTRAINT [PK_rol] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rol_permiso]    Script Date: 22/05/2025 3:32:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rol_permiso](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_rol] [int] NOT NULL,
	[id_permiso] [int] NOT NULL,
 CONSTRAINT [PK_rol_permiso] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rol_usuario]    Script Date: 22/05/2025 3:32:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rol_usuario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_rol] [int] NOT NULL,
	[id_usuario] [int] NOT NULL,
 CONSTRAINT [PK_rol_usuario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sesion]    Script Date: 22/05/2025 3:32:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sesion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NULL,
	[hora] [time](2) NULL,
	[acceso_nro] [int] NULL,
	[id_usuario] [int] NOT NULL,
 CONSTRAINT [PK_sesion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 22/05/2025 3:32:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[id] [int] NOT NULL,
	[email] [nvarchar](70) NOT NULL,
	[password] [varchar](70) NOT NULL,
	[nickname] [varchar](70) NOT NULL,
	[nombre] [varchar](70) NOT NULL,
	[apellido] [varchar](70) NOT NULL,
	[dni] [char](8) NOT NULL,
	[genero] [varchar](10) NULL,
	[nro_celular] [varchar](13) NULL,
	[fecha_nacimiento] [date] NOT NULL,
	[id_estado] [int] NOT NULL,
 CONSTRAINT [PK_usuario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vendedor]    Script Date: 22/05/2025 3:32:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vendedor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_usuario] [int] NOT NULL,
	[cuil_vendedor] [char](13) NOT NULL,
 CONSTRAINT [PK_vendedor] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[administrador]  WITH CHECK ADD  CONSTRAINT [FK_administrador_usuario] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[usuario] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[administrador] CHECK CONSTRAINT [FK_administrador_usuario]
GO
ALTER TABLE [dbo].[detalle_factura]  WITH CHECK ADD  CONSTRAINT [FK_detalle_factura_factura] FOREIGN KEY([id_factura])
REFERENCES [dbo].[factura] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[detalle_factura] CHECK CONSTRAINT [FK_detalle_factura_factura]
GO
ALTER TABLE [dbo].[detalle_factura]  WITH CHECK ADD  CONSTRAINT [FK_detalle_factura_farmaco] FOREIGN KEY([id_farmaco])
REFERENCES [dbo].[farmaco] ([id])
GO
ALTER TABLE [dbo].[detalle_factura] CHECK CONSTRAINT [FK_detalle_factura_farmaco]
GO
ALTER TABLE [dbo].[factura]  WITH CHECK ADD  CONSTRAINT [FK_factura_estado_factura] FOREIGN KEY([id_estado_factura])
REFERENCES [dbo].[estado_factura] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[factura] CHECK CONSTRAINT [FK_factura_estado_factura]
GO
ALTER TABLE [dbo].[factura]  WITH CHECK ADD  CONSTRAINT [FK_factura_metodo_de_pago] FOREIGN KEY([id_metodo_pago])
REFERENCES [dbo].[metodo_de_pago] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[factura] CHECK CONSTRAINT [FK_factura_metodo_de_pago]
GO
ALTER TABLE [dbo].[factura]  WITH CHECK ADD  CONSTRAINT [FK_factura_vendedor] FOREIGN KEY([id_vendedor])
REFERENCES [dbo].[vendedor] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[factura] CHECK CONSTRAINT [FK_factura_vendedor]
GO
ALTER TABLE [dbo].[farmaceutico]  WITH CHECK ADD  CONSTRAINT [FK_farmaceutico_usuario] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[usuario] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[farmaceutico] CHECK CONSTRAINT [FK_farmaceutico_usuario]
GO
ALTER TABLE [dbo].[farmaco]  WITH CHECK ADD  CONSTRAINT [FK_farmaco_accion_terapeutica] FOREIGN KEY([id_accion_terapeutica])
REFERENCES [dbo].[accion_terapeutica] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[farmaco] CHECK CONSTRAINT [FK_farmaco_accion_terapeutica]
GO
ALTER TABLE [dbo].[farmaco]  WITH CHECK ADD  CONSTRAINT [FK_farmaco_administracion_via] FOREIGN KEY([id_administracion_via])
REFERENCES [dbo].[administracion_via] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[farmaco] CHECK CONSTRAINT [FK_farmaco_administracion_via]
GO
ALTER TABLE [dbo].[farmaco]  WITH CHECK ADD  CONSTRAINT [FK_farmaco_forma_farmaceutica] FOREIGN KEY([id_forma_farmaceutica])
REFERENCES [dbo].[forma_farmaceutica] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[farmaco] CHECK CONSTRAINT [FK_farmaco_forma_farmaceutica]
GO
ALTER TABLE [dbo].[farmaco]  WITH CHECK ADD  CONSTRAINT [FK_farmaco_origen_fuente] FOREIGN KEY([id_origen_fuente])
REFERENCES [dbo].[origen_fuente] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[farmaco] CHECK CONSTRAINT [FK_farmaco_origen_fuente]
GO
ALTER TABLE [dbo].[farmaco]  WITH CHECK ADD  CONSTRAINT [FK_farmaco_principio_activo] FOREIGN KEY([id_principio_activo])
REFERENCES [dbo].[principio_activo] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[farmaco] CHECK CONSTRAINT [FK_farmaco_principio_activo]
GO
ALTER TABLE [dbo].[farmaco]  WITH CHECK ADD  CONSTRAINT [FK_farmaco_proveedor] FOREIGN KEY([id_proveedor])
REFERENCES [dbo].[proveedor] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[farmaco] CHECK CONSTRAINT [FK_farmaco_proveedor]
GO
ALTER TABLE [dbo].[gerente]  WITH CHECK ADD  CONSTRAINT [FK_gerente_usuario] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[usuario] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[gerente] CHECK CONSTRAINT [FK_gerente_usuario]
GO
ALTER TABLE [dbo].[proveedor]  WITH CHECK ADD  CONSTRAINT [FK_proveedor_metodo_de_pago] FOREIGN KEY([id_metodo_pago])
REFERENCES [dbo].[metodo_de_pago] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[proveedor] CHECK CONSTRAINT [FK_proveedor_metodo_de_pago]
GO
ALTER TABLE [dbo].[proveedor]  WITH CHECK ADD  CONSTRAINT [FK_proveedor_posicion_iva] FOREIGN KEY([id_posicion_iva])
REFERENCES [dbo].[posicion_iva] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[proveedor] CHECK CONSTRAINT [FK_proveedor_posicion_iva]
GO
ALTER TABLE [dbo].[rol_permiso]  WITH CHECK ADD  CONSTRAINT [FK_rol_permiso_permiso] FOREIGN KEY([id_permiso])
REFERENCES [dbo].[permiso] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[rol_permiso] CHECK CONSTRAINT [FK_rol_permiso_permiso]
GO
ALTER TABLE [dbo].[rol_permiso]  WITH CHECK ADD  CONSTRAINT [FK_rol_permiso_rol] FOREIGN KEY([id_rol])
REFERENCES [dbo].[rol] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[rol_permiso] CHECK CONSTRAINT [FK_rol_permiso_rol]
GO
ALTER TABLE [dbo].[rol_usuario]  WITH CHECK ADD  CONSTRAINT [FK_rol_usuario_rol] FOREIGN KEY([id_rol])
REFERENCES [dbo].[rol] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[rol_usuario] CHECK CONSTRAINT [FK_rol_usuario_rol]
GO
ALTER TABLE [dbo].[rol_usuario]  WITH CHECK ADD  CONSTRAINT [FK_rol_usuario_usuario] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[usuario] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[rol_usuario] CHECK CONSTRAINT [FK_rol_usuario_usuario]
GO
ALTER TABLE [dbo].[sesion]  WITH CHECK ADD  CONSTRAINT [FK_sesion_usuario] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[usuario] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[sesion] CHECK CONSTRAINT [FK_sesion_usuario]
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [FK_usuario_estado] FOREIGN KEY([id_estado])
REFERENCES [dbo].[estado] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [FK_usuario_estado]
GO
ALTER TABLE [dbo].[vendedor]  WITH CHECK ADD  CONSTRAINT [FK_vendedor_usuario] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[usuario] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[vendedor] CHECK CONSTRAINT [FK_vendedor_usuario]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'en la columna descripcion puede ir ejemplos como:

- Analgesico
- Antibiotico
- Ansiolitico
- Antidepresivo
- Anti-inflamatorio
- Anticonceptivo
- Anticoalergenico
- Antidiabetico
- Antipsicotico
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'accion_terapeutica'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'en la columna descripcion puede ir ejemplos como:

- Oral
- Intravenosa
- Intramuscular
- Topica
- Rectal
- Vaginal
- Intradermica

' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'administracion_via'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'en la columna de descripcion va de ejemplo:

- Pendiente
- En proceso
- Enviada
- Cancelada
- Devuelta
- Facturada
- Pagada
- Descartada
- Contactada
- Seguimiento
- No calificada

' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'estado_factura'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ejemplo de nro_factura:
A-2024-0001' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'factura'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'la columna de codigo_barras debe ir una serie de 13 digitos:

3 4 2 8 7 4 6 9 3 2 3 4 5

---------------------------------------------------------------------------
la columna requiere_receta solo debe ir cadenas de string de 2 caracteres:

-  S I
-  S i
-  N O
-  N o' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'farmaco'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'en la columna descripcion puede ir ejemplos como:

- Solido
- Semisolido
- Liquido
- Gaseoso
- Granulado
- Comprimido

' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'forma_farmaceutica'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'en la columna descripcion va de ejemplo:

- Efectivo
- Cheque
- Tarjeta de Credito
- Tarjeta de Debido
- Transferencia Bancaria
- Pago QR
- Pago App Pay
- Criptomoneda
- BNPL
- NFC

' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'metodo_de_pago'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'en la columna descripcion puede ir ejemplos como:

- Natural
- Sintesis
- Biotecnologico

' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'origen_fuente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'en la columna descripcion, va el texto o titulo de las funcionalidades que tiene permitido cada usuario segun su rol de acceso al sistema' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'permiso'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'en la columna descripcion va como ejemplo:

- Responsable inscripto
- Monotributista
- Consumidor final
- Exento


' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'posicion_iva'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'en la columna descripcion puede ir ejemplos como:

- Acliclovir
- Amoxicilina
- Acarbosa
- Amox-ac. Clavulan
- Azitromina
- AAS
- Almagato
- Alantoina
- Beclometasona
- Benzocaina
- Budesonida
- Brom de ipratropio
- Calamina
- Cafalexina
- Cefaclor
- Cerufoxima
- Cimetidina
- Citalopram
- Claritromicina
- Cloxacilina
- Clomipramina
- Clotrimazol
- Cromoclicato
- Diclofenaco
- Dimenhidrinato
- Doxilamina+piridox
- Eritromicina
- Esomeprazol
- Etambutol
- Estreptomicina
- Famotidina
- Fenil butazona
- Fluocindona
- Fenoximetilpenicil
- Fosfomicina
- Fluticasona
- Fluoxetina
- Glicerina acuosa
- Hidrocortisona
- Hidroxido de Al.
- Hidroxido de Mg.
- Ibuprofeno
- Indometacina
- Imipramina
- Isoniacida
- Lidocaina
- Lansoprazol
- Magaldrato
- Metronidazol
- Miconazol
- Miglitol
- Montelukast
- Nateglinida
- Naproxeno
- Nedocromil
- Nitrofurantoina
- Nizatidina
- Omeprazol
- Oxido de Zn.
- Oxifenbutazona
- Pantoprazol
- Paracetamol
- Paroxetina
- Pioglitazona
- Piroxicam
- Pramoxina
- Prednisona
- Rabeprazol
- Ranitidina
- Roxatidina
- Repaglinida
- Rifampicina
- Rosiglitazona
- Salbutamol
- Salmeterol
- Sertralina
- Sucralfato
- Teofilina
- Terbutalina
- Triamcinolona
- Venlafaxina
- Zafirlukast' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'principio_activo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'en la columna nombre puede ir ejemplo:

     1)  Aibal Sociedad Anonima
     2)  AIR S. R. L.
----------------------------------------------------------------------
en la columna nro_telefono, puede ir ejemplo: 

     1)  0 1 1 - 2 8 1 8 - 0 2 4 0
----------------------------------------------------------------------
en la columna cuit, puede ir ejemplo: 

     1)  3 0 - 5 7 0 1 3 5 5 8 - 5


' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'proveedor'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'columna descripcion admite solo cadena de string de 13 caracteres:

-  a d m i n i s t r a d o r
-  g e r e n t e
-  v e n d e d o r
-  f a r m a c e u t i c o' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'rol'
GO
USE [master]
GO
ALTER DATABASE [proyecto_farmaceutica] SET  READ_WRITE 
GO
