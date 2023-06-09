USE [master]
GO
/****** Object:  Database [Biblioteca]    Script Date: 19/4/2023 10:53:43 p. m. ******/
CREATE DATABASE [Biblioteca]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Biblioteca', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER01\MSSQL\DATA\Biblioteca.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Biblioteca_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER01\MSSQL\DATA\Biblioteca_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Biblioteca] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Biblioteca].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Biblioteca] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Biblioteca] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Biblioteca] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Biblioteca] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Biblioteca] SET ARITHABORT OFF 
GO
ALTER DATABASE [Biblioteca] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Biblioteca] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Biblioteca] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Biblioteca] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Biblioteca] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Biblioteca] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Biblioteca] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Biblioteca] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Biblioteca] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Biblioteca] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Biblioteca] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Biblioteca] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Biblioteca] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Biblioteca] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Biblioteca] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Biblioteca] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Biblioteca] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Biblioteca] SET RECOVERY FULL 
GO
ALTER DATABASE [Biblioteca] SET  MULTI_USER 
GO
ALTER DATABASE [Biblioteca] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Biblioteca] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Biblioteca] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Biblioteca] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Biblioteca] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Biblioteca] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Biblioteca', N'ON'
GO
ALTER DATABASE [Biblioteca] SET QUERY_STORE = OFF
GO
USE [Biblioteca]
GO
/****** Object:  Table [dbo].[empleado]    Script Date: 19/4/2023 10:53:43 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[empleado](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Cedula] [varchar](15) NULL,
	[Nombres] [varchar](100) NULL,
	[Apellidos] [varchar](100) NULL,
	[Dirección] [varchar](max) NULL,
	[Teléfono] [varchar](15) NULL,
	[Email] [varchar](100) NULL,
	[cargo] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estudiante]    Script Date: 19/4/2023 10:53:43 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estudiante](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Matricula] [varchar](100) NULL,
	[Carrera] [varchar](100) NULL,
	[Nombres] [varchar](100) NULL,
	[Apellidos] [varchar](100) NULL,
	[Telefono] [varchar](15) NULL,
	[Email_Estudiante] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[libro]    Script Date: 19/4/2023 10:53:43 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[libro](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](50) NULL,
	[Autor] [varchar](100) NULL,
	[Titulo] [varchar](200) NULL,
	[Descripcion] [varchar](max) NULL,
	[Edicion] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 19/4/2023 10:53:43 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](50) NULL,
	[clave] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[empleado] ON 

INSERT [dbo].[empleado] ([Id], [Cedula], [Nombres], [Apellidos], [Dirección], [Teléfono], [Email], [cargo]) VALUES (7, N'00216547892', N'adsfasdfasdf', N'adsfasdfasdfdf', N'adfadsfasdf', N'8099788505', N'asdfasdfasdfsdaf', N'asdfasdfasdfsdaf')
SET IDENTITY_INSERT [dbo].[empleado] OFF
GO
SET IDENTITY_INSERT [dbo].[libro] ON 

INSERT [dbo].[libro] ([Id], [Codigo], [Autor], [Titulo], [Descripcion], [Edicion]) VALUES (2, N'005646655', N'manuel', N'dkfjaksdfjksdjfkjkjk', N'dkfajsdkfjasdkfjaskdfjskdafkadsfk', N'VDFASDFSD25555')
SET IDENTITY_INSERT [dbo].[libro] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([Id], [usuario], [clave]) VALUES (1, N'admin', N'123456')
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
/****** Object:  StoredProcedure [dbo].[buscar]    Script Date: 19/4/2023 10:53:43 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  proc [dbo].[buscar] (@Id int,@Tabla varchar(50))  
as  

if @Tabla='Empleado'
Select* from Empleado where Id=@Id
else if @Tabla='Estudiante'
select * from Estudiante
else
select* from libro
GO
/****** Object:  StoredProcedure [dbo].[consultaempleado]    Script Date: 19/4/2023 10:53:43 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[consultaempleado]
as
Select* from empleado
GO
/****** Object:  StoredProcedure [dbo].[consultaEstudiante]    Script Date: 19/4/2023 10:53:43 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[consultaEstudiante]
as
Select* from Estudiante
GO
/****** Object:  StoredProcedure [dbo].[consultaLibro]    Script Date: 19/4/2023 10:53:43 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[consultaLibro]
as
Select* from Libro
GO
/****** Object:  StoredProcedure [dbo].[ObtenerUsuarios]    Script Date: 19/4/2023 10:53:43 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[ObtenerUsuarios](
@usuario varchar(100),
@clave varchar(100))
as

Select usuario from usuarios where usuario=@usuario and clave=@clave
GO
/****** Object:  StoredProcedure [dbo].[Sp_Consulta]    Script Date: 19/4/2023 10:53:43 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[Sp_Consulta](
@Tabla varchar(50))
as
if @Tabla='Empleado'
Select* from empleado
else if @Tabla='Estudiante'
Select* from Estudiante
else 
Select * from libro
GO
/****** Object:  StoredProcedure [dbo].[Sp_EditarEmpleado]    Script Date: 19/4/2023 10:53:43 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  proc [dbo].[Sp_EditarEmpleado](
    @Id int,
     @Cedula varchar(15),
	  @Nombres varchar(100),
      @Apellidos varchar(100),
      @Dirección varchar (max),
      @Telefono varchar(100),
      @Email varchar(100),
      @cargo varchar(100))
	  as
	  update  Empleado set Cedula=@Cedula, [Nombres]=@Nombres, [Apellidos]=@Apellidos, [Dirección]=@Dirección, [Teléfono]=@Telefono, [Email]=@Email, [cargo]=@cargo
	  where Id=@Id
GO
/****** Object:  StoredProcedure [dbo].[Sp_EliminarRegistro]    Script Date: 19/4/2023 10:53:43 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Sp_EliminarRegistro](
@Id int,
@Tabla varchar(50))
as
if @Tabla='Empleado'
Delete empleado where Id=@Id
else if @Tabla='Estudiante'  
Delete Estudiante where Id=@Id
else
Delete libro where Id=@Id
GO
/****** Object:  StoredProcedure [dbo].[Sp_NuevoEmpleado]    Script Date: 19/4/2023 10:53:43 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE  proc [dbo].[Sp_NuevoEmpleado](
     @Cedula varchar(15),
	  @Nombres varchar(100),
      @Apellidos varchar(100),
      @Dirección varchar (max),
      @Telefono varchar(100),
      @Email varchar(100),
      @cargo varchar(100))
	  as
	  Insert into Empleado( [Cedula], [Nombres], [Apellidos], [Dirección], [Teléfono], [Email], [cargo])
	  values
	  ( @Cedula,
	  @Nombres,
      @Apellidos ,
      @Dirección ,
      @Telefono,
      @Email ,
      @cargo )
GO
/****** Object:  StoredProcedure [dbo].[Sp_RegistrarEstudiante]    Script Date: 19/4/2023 10:53:43 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create proc [dbo].[Sp_RegistrarEstudiante](
   @Matricula varchar(50)
      ,@Carrera varchar(100)
      ,@Nombres varchar(100)
      ,@Apellidos varchar(100)
      ,@Telefono varchar(15),
	  @Email_Estudiante varchar(100)
	  )
	  as 
	  Insert into Estudiante(

Matricula, [Carrera], [Nombres], [Apellidos], [Telefono], [Email_Estudiante]

   )
	  values
	  (  
	    @Matricula      ,@Carrera       ,@Nombres       ,@Apellidos       ,@Telefono,	  @Email_Estudiante
	  
	  )
GO
/****** Object:  StoredProcedure [dbo].[Sp_RegistrarLibro]    Script Date: 19/4/2023 10:53:43 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Sp_RegistrarLibro](
   @Codigo varchar(50)
      ,@Autor varchar(100)
      ,@Titulo varchar(100)
      ,@Descripcion varchar(100)
      ,@Edicion varchar(100)
	  )
	  as 
	  Insert into Libro(Codigo
      ,Autor
      ,Titulo
      ,Descripcion
      ,Edicion)
	  values
	  (  @Codigo
      ,@Autor
      ,@Titulo
      ,@Descripcion      ,@Edicion)
GO
USE [master]
GO
ALTER DATABASE [Biblioteca] SET  READ_WRITE 
GO
