USE [master]
GO
/****** Object:  Database [Deportivo]    Script Date: 09/04/2019 00:38:39 ******/
CREATE DATABASE [Deportivo]
USE [Deportivo]
GO
/****** Object:  Table [dbo].[Perfiles]    Script Date: 09/04/2019 00:38:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Perfiles](
	[id_perfil] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Perfiles] PRIMARY KEY CLUSTERED 
(
	[id_perfil] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Perfiles] ON
INSERT [dbo].[Perfiles] ([id_perfil], [nombre]) VALUES (1, N'Administrador')
INSERT [dbo].[Perfiles] ([id_perfil], [nombre]) VALUES (2, N'Tester')
INSERT [dbo].[Perfiles] ([id_perfil], [nombre]) VALUES (3, N'Desarrollador')
INSERT [dbo].[Perfiles] ([id_perfil], [nombre]) VALUES (4, N'Responsable de Reportes')
SET IDENTITY_INSERT [dbo].[Perfiles] OFF
/****** Object:  Table [dbo].[Marcas]    Script Date: 09/04/2019 00:38:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Marcas](
	[id_marca] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Marcas] PRIMARY KEY CLUSTERED 
(
	[id_marca] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Marcas] ON
INSERT [dbo].[Marcas] ([id_marca], [descripcion], [borrado]) VALUES (2, N'Nike', 0)
INSERT [dbo].[Marcas] ([id_marca], [descripcion], [borrado]) VALUES (3, N'Adidas', 0)
INSERT [dbo].[Marcas] ([id_marca], [descripcion], [borrado]) VALUES (4, N'Reebok', 0)
INSERT [dbo].[Marcas] ([id_marca], [descripcion], [borrado]) VALUES (5, N'Fila', 0)
INSERT [dbo].[Marcas] ([id_marca], [descripcion], [borrado]) VALUES (6, N'New Balance', 0)
SET IDENTITY_INSERT [dbo].[Marcas] OFF
/****** Object:  Table [dbo].[Formularios]    Script Date: 09/04/2019 00:38:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Formularios](
	[id_formulario] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Formularios] PRIMARY KEY CLUSTERED 
(
	[id_formulario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 09/04/2019 00:38:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Productos](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[id_marca] [int] NULL,
	[cantidad] [int] NULL,
	[precio_venta] [int] NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [IX_Productos] ON [dbo].[Productos] 
(
	[id_producto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Productos] ON
INSERT [dbo].[Productos] ([id_producto], [nombre], [id_marca], [cantidad], [precio_venta], [borrado]) VALUES (1, N'Pelota ', 2, 8, 500, 0)
INSERT [dbo].[Productos] ([id_producto], [nombre], [id_marca], [cantidad], [precio_venta], [borrado]) VALUES (2, N'Remera', 4, 10, 400, 0)
INSERT [dbo].[Productos] ([id_producto], [nombre], [id_marca], [cantidad], [precio_venta], [borrado]) VALUES (3, N'Short', 3, 5, 250, 0)
INSERT [dbo].[Productos] ([id_producto], [nombre], [id_marca], [cantidad], [precio_venta], [borrado]) VALUES (4, N'Medias', 4, 9, 135, 0)
INSERT [dbo].[Productos] ([id_producto], [nombre], [id_marca], [cantidad], [precio_venta], [borrado]) VALUES (5, N'Guantes ', 1, 4, 210, 0)
SET IDENTITY_INSERT [dbo].[Productos] OFF
/****** Object:  Table [dbo].[Usuarios]    Script Date: 09/04/2019 00:38:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[id_perfil] [int] NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[password] [varchar](10) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[estado] [varchar](1) NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado]) VALUES (1, 1, N'ADMIN', N'123', N'admin@bt.com', N'S')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado]) VALUES (2, 2, N'acme', N'test123', N'test123', N'N')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado]) VALUES (4, 3, N'Test3', N'test', N'test2@bt.com', N'')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado]) VALUES (5, 2, N'one21', N'fhkjasdhfa', N'fhkjasdhfa', N'N')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado]) VALUES (6, 3, N'Test11-09', N'123', N'test1109@bugs.com.ar', N'N')
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado]) VALUES (7, 4, N'Melisa', N'123', N'meli@gmail.com', N'S')
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
/****** Object:  Table [dbo].[Permisos]    Script Date: 09/04/2019 00:38:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permisos](
	[id_formulario] [int] NOT NULL,
	[id_perfil] [int] NOT NULL,
 CONSTRAINT [PK_Permisos] PRIMARY KEY CLUSTERED 
(
	[id_formulario] ASC,
	[id_perfil] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_Productos_Marcas]    Script Date: 09/04/2019 00:38:39 ******/
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Marcas] FOREIGN KEY([id_producto])
REFERENCES [dbo].[Productos] ([id_producto])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Marcas]
GO
/****** Object:  ForeignKey [FK_Usuarios_Perfiles]    Script Date: 09/04/2019 00:38:39 ******/
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Perfiles] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[Perfiles] ([id_perfil])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Perfiles]
GO
/****** Object:  ForeignKey [FK_Permisos_Formularios]    Script Date: 09/04/2019 00:38:39 ******/
ALTER TABLE [dbo].[Permisos]  WITH CHECK ADD  CONSTRAINT [FK_Permisos_Formularios] FOREIGN KEY([id_formulario])
REFERENCES [dbo].[Formularios] ([id_formulario])
GO
ALTER TABLE [dbo].[Permisos] CHECK CONSTRAINT [FK_Permisos_Formularios]
GO
/****** Object:  ForeignKey [FK_Permisos_Perfiles]    Script Date: 09/04/2019 00:38:39 ******/
ALTER TABLE [dbo].[Permisos]  WITH CHECK ADD  CONSTRAINT [FK_Permisos_Perfiles] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[Perfiles] ([id_perfil])
GO
ALTER TABLE [dbo].[Permisos] CHECK CONSTRAINT [FK_Permisos_Perfiles]
GO
