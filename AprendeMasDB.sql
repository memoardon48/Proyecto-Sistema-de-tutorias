USE [AprendeMas]
GO
/****** Object:  Table [dbo].[Auditoria]    Script Date: 12/11/2021 5:38:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Auditoria](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[userName] [nvarchar](50) NOT NULL,
	[accion] [nvarchar](100) NOT NULL,
	[tabla] [nvarchar](60) NOT NULL,
	[formulario] [nvarchar](60) NOT NULL,
	[codRegistro] [int] NOT NULL,
	[fecha] [datetime] NULL,
 CONSTRAINT [PK_Auditoria_id] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BalanceGeneral]    Script Date: 12/11/2021 5:38:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BalanceGeneral](
	[codBalance] [int] IDENTITY(1,1) NOT NULL,
	[activosCorrientes] [decimal](10, 2) NULL,
	[activosNoCorrientes] [decimal](10, 2) NULL,
	[pasivosCorrientes] [decimal](10, 2) NULL,
	[pasivosNoCorrientes] [decimal](10, 2) NULL,
	[patrimonio] [decimal](10, 2) NULL,
	[fecha] [datetime] NULL,
 CONSTRAINT [PK_BalanceGeneral_codBalance] PRIMARY KEY CLUSTERED 
(
	[codBalance] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clase]    Script Date: 12/11/2021 5:38:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clase](
	[codClase] [int] IDENTITY(1,1) NOT NULL,
	[nombreClase] [nvarchar](100) NULL,
	[estado] [nvarchar](15) NULL,
 CONSTRAINT [PK_Clase_codClase] PRIMARY KEY CLUSTERED 
(
	[codClase] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClaseTutor]    Script Date: 12/11/2021 5:38:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClaseTutor](
	[codClase] [int] NOT NULL,
	[codTutor] [int] NOT NULL,
	[estado] [nvarchar](15) NULL,
 CONSTRAINT [PK_ClaseTutor_codClaseAndcodTutor] PRIMARY KEY CLUSTERED 
(
	[codClase] ASC,
	[codTutor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 12/11/2021 5:38:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[codCliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NULL,
	[apellido] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[edad] [int] NULL,
	[celular] [nvarchar](50) NULL,
	[universidad] [nvarchar](50) NULL,
	[estado] [nvarchar](15) NULL,
 CONSTRAINT [PK_Cliente_codCliente] PRIMARY KEY CLUSTERED 
(
	[codCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DatosMarketing]    Script Date: 12/11/2021 5:38:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatosMarketing](
	[codEncuesta] [int] IDENTITY(1,1) NOT NULL,
	[Muestra] [int] NULL,
	[codClase] [int] NULL,
	[horario] [nvarchar](50) NULL,
	[redSocial] [nvarchar](50) NULL,
	[precioComun] [nvarchar](100) NULL,
	[Universidad] [nvarchar](50) NULL,
	[Fecha] [date] NULL,
 CONSTRAINT [PK_DatosMarketing_codEncuesta] PRIMARY KEY CLUSTERED 
(
	[codEncuesta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EvaluacionesRRHH]    Script Date: 12/11/2021 5:38:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EvaluacionesRRHH](
	[codEvaluacion] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [datetime] NULL,
	[codTutor] [int] NULL,
	[metodo] [int] NULL,
	[tiempoEficaz] [int] NULL,
	[resolucionDudas] [int] NULL,
	[respetuo] [int] NULL,
	[confianza] [int] NULL,
	[comprensionCliente] [int] NULL,
	[preparacion] [int] NULL,
 CONSTRAINT [PK_EvaluacionesRRHH_codEvaluacion] PRIMARY KEY CLUSTERED 
(
	[codEvaluacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 12/11/2021 5:38:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[codFactura] [int] NOT NULL,
	[codTutoria] [int] NOT NULL,
	[Total] [decimal](10, 2) NULL,
	[fecha] [datetime] NULL,
 CONSTRAINT [PK_Factura_codFactura] PRIMARY KEY CLUSTERED 
(
	[codFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pagos]    Script Date: 12/11/2021 5:38:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pagos](
	[codPago] [int] IDENTITY(1,1) NOT NULL,
	[codTutor] [int] NOT NULL,
	[codTutoria] [int] NOT NULL,
	[monto] [decimal](10, 2) NULL,
	[fechaPago] [datetime] NULL,
 CONSTRAINT [PK_Pagos_codPago] PRIMARY KEY CLUSTERED 
(
	[codPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tutor]    Script Date: 12/11/2021 5:38:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tutor](
	[codTutor] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NULL,
	[apellido] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[edad] [int] NULL,
	[celular] [nvarchar](50) NULL,
	[universidad] [nvarchar](50) NULL,
	[carrera] [nvarchar](70) NULL,
	[porcentaje] [decimal](10, 2) NULL,
	[cuenta] [nvarchar](50) NULL,
	[banco] [nvarchar](50) NULL,
	[estado] [nvarchar](15) NULL,
	[fechaAgregado] [datetime] NULL,
 CONSTRAINT [PK_Tutor_codTutor] PRIMARY KEY CLUSTERED 
(
	[codTutor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tutoria]    Script Date: 12/11/2021 5:38:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tutoria](
	[codTutoria] [int] IDENTITY(1,1) NOT NULL,
	[codCliente] [int] NOT NULL,
	[codTutor] [int] NULL,
	[codClase] [int] NOT NULL,
	[temas] [nvarchar](500) NULL,
	[fecha] [datetime] NULL,
	[tipo] [nvarchar](50) NULL,
	[horas] [int] NULL,
	[personas] [int] NULL,
	[conocimientoCliente] [nvarchar](500) NULL,
	[estado] [nvarchar](50) NULL,
	[pagadaCliente] [nvarchar](10) NULL,
	[pagadaTutor] [nvarchar](10) NULL,
 CONSTRAINT [PK_Tutoria_codTutoria] PRIMARY KEY CLUSTERED 
(
	[codTutoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 12/11/2021 5:38:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[codUsuario] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[pass] [nvarchar](50) NOT NULL,
	[tipo] [int] NOT NULL,
	[estado] [nvarchar](15) NULL,
 CONSTRAINT [PK_Usuario_codUsuario] PRIMARY KEY CLUSTERED 
(
	[codUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ClaseTutor]  WITH CHECK ADD  CONSTRAINT [FK_Clase$ImpartidaPor$Tutor] FOREIGN KEY([codClase])
REFERENCES [dbo].[Clase] ([codClase])
GO
ALTER TABLE [dbo].[ClaseTutor] CHECK CONSTRAINT [FK_Clase$ImpartidaPor$Tutor]
GO
ALTER TABLE [dbo].[ClaseTutor]  WITH CHECK ADD  CONSTRAINT [FK_Tutor$Sabe$Clase] FOREIGN KEY([codTutor])
REFERENCES [dbo].[Tutor] ([codTutor])
GO
ALTER TABLE [dbo].[ClaseTutor] CHECK CONSTRAINT [FK_Tutor$Sabe$Clase]
GO
ALTER TABLE [dbo].[DatosMarketing]  WITH CHECK ADD  CONSTRAINT [FK_Clase$Seleccionada$DatosMarketing] FOREIGN KEY([codClase])
REFERENCES [dbo].[Clase] ([codClase])
GO
ALTER TABLE [dbo].[DatosMarketing] CHECK CONSTRAINT [FK_Clase$Seleccionada$DatosMarketing]
GO
ALTER TABLE [dbo].[EvaluacionesRRHH]  WITH CHECK ADD  CONSTRAINT [FK_Tutor$Tiene$EvaluacionesRRHH] FOREIGN KEY([codTutor])
REFERENCES [dbo].[Tutor] ([codTutor])
GO
ALTER TABLE [dbo].[EvaluacionesRRHH] CHECK CONSTRAINT [FK_Tutor$Tiene$EvaluacionesRRHH]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Tutoria$Tiene$Factura] FOREIGN KEY([codTutoria])
REFERENCES [dbo].[Tutoria] ([codTutoria])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [FK_Tutoria$Tiene$Factura]
GO
ALTER TABLE [dbo].[Pagos]  WITH CHECK ADD  CONSTRAINT [FK_Tutor$Recibe$Pago] FOREIGN KEY([codTutor])
REFERENCES [dbo].[Tutor] ([codTutor])
GO
ALTER TABLE [dbo].[Pagos] CHECK CONSTRAINT [FK_Tutor$Recibe$Pago]
GO
ALTER TABLE [dbo].[Pagos]  WITH CHECK ADD  CONSTRAINT [FK_Tutoria$Tiene$Pago] FOREIGN KEY([codTutoria])
REFERENCES [dbo].[Tutoria] ([codTutoria])
GO
ALTER TABLE [dbo].[Pagos] CHECK CONSTRAINT [FK_Tutoria$Tiene$Pago]
GO
ALTER TABLE [dbo].[Tutoria]  WITH CHECK ADD  CONSTRAINT [FK_Clase$PedidaEn$Tutoria] FOREIGN KEY([codClase])
REFERENCES [dbo].[Clase] ([codClase])
GO
ALTER TABLE [dbo].[Tutoria] CHECK CONSTRAINT [FK_Clase$PedidaEn$Tutoria]
GO
ALTER TABLE [dbo].[Tutoria]  WITH CHECK ADD  CONSTRAINT [FK_Cliente$Paga$Tutoria] FOREIGN KEY([codCliente])
REFERENCES [dbo].[Cliente] ([codCliente])
GO
ALTER TABLE [dbo].[Tutoria] CHECK CONSTRAINT [FK_Cliente$Paga$Tutoria]
GO
ALTER TABLE [dbo].[Tutoria]  WITH CHECK ADD  CONSTRAINT [FK_Tutor$Imparte$Tutoria] FOREIGN KEY([codTutor])
REFERENCES [dbo].[Tutor] ([codTutor])
GO
ALTER TABLE [dbo].[Tutoria] CHECK CONSTRAINT [FK_Tutor$Imparte$Tutoria]
GO
/****** Object:  StoredProcedure [dbo].[Select_Auditoria]    Script Date: 12/11/2021 5:38:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Select_Auditoria]
(
	@userName nvarchar(50)
)
AS
	SET NOCOUNT ON;
SELECT * FROM  Auditoria WHERE userName LIKE @userName
GO
/****** Object:  StoredProcedure [dbo].[Select_Balance]    Script Date: 12/11/2021 5:38:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Select_Balance]
(
	@fecha1 datetime,
	@fecha2 datetime
)
AS
	SET NOCOUNT ON;
SELECT SUM(activosCorrientes + activosNoCorrientes) Activos , SUM(pasivosCorrientes + pasivosNoCorrientes) Pasivos, SUM(patrimonio) Patrimonio FROM BalanceGeneral WHERE fecha BETWEEN @fecha1 AND @fecha2
GO
/****** Object:  StoredProcedure [dbo].[Select_Clientes]    Script Date: 12/11/2021 5:38:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Select_Clientes]
(
	@universidad nvarchar(50)
)
AS
	SET NOCOUNT ON;
SELECT * FROM Cliente WHERE universidad LIKE @universidad
GO
/****** Object:  StoredProcedure [dbo].[Select_Evaluacion]    Script Date: 12/11/2021 5:38:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Select_Evaluacion]
(
	@fecha1 datetime,
	@fecha2 datetime
)
AS
	SET NOCOUNT ON;
SELECT T.nombre ,AVG(metodo) metodo , AVG(tiempoEficaz) tiempo, AVG(resolucionDudas) resolucion, AVG(respetuo) respetuo, AVG(confianza) confianza, AVG(comprensionCliente) comprension, AVG(preparacion) preparacion FROM EvaluacionesRRHH EHH INNER JOIN Tutor T ON EHH.codTutor = T.codTutor WHERE EHH.fecha BETWEEN @fecha1 AND @fecha2 GROUP BY T.nombre
GO
/****** Object:  StoredProcedure [dbo].[Select_Factura]    Script Date: 12/11/2021 5:38:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Select_Factura]
(
	@codFactura int
)
AS
	SET NOCOUNT ON;
SELECT F.codFactura , (CC.nombre + ' ' + CC.apellido) AS NombreCliente , (TT.nombre + ' ' + TT.apellido) AS nombreTutor, C.nombreClase, T.temas, T.fecha,T.tipo,T.horas,T.personas, F.fecha, F.Total   FROM Tutoria T INNER JOIN Clase C ON T.codClase = C.codClase INNER JOIN Tutor TT ON T.codTutor = TT.codTutor INNER JOIN Cliente CC ON T.codCliente = CC.codCliente INNER JOIN Factura F ON T.codTutoria = F.codTutoria WHERE F.codFactura = @codFactura
GO
/****** Object:  StoredProcedure [dbo].[Select_marketing]    Script Date: 12/11/2021 5:38:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Select_marketing]
(
	@fecha1 date,
	@fecha2 date
)
AS
	SET NOCOUNT ON;
SELECT DM.codEncuesta, DM.Muestra, C.nombreClase, DM.horario, DM.redSocial, DM.precioComun, DM.Universidad, DM.Fecha FROM DatosMarketing DM INNER JOIN Clase C ON DM.codClase = C.codClase WHERE Fecha BETWEEN @fecha1 AND @fecha2
GO
/****** Object:  StoredProcedure [dbo].[Select_Tutor]    Script Date: 12/11/2021 5:38:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Select_Tutor]
(
	@universidad nvarchar(50)
)
AS
	SET NOCOUNT ON;
SELECT * FROM Tutor WHERE universidad LIKE @universidad
GO
/****** Object:  StoredProcedure [dbo].[Select_Tutoria]    Script Date: 12/11/2021 5:38:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Select_Tutoria]
(
	@fecha1 datetime,
	@fecha2 datetime
)
AS
	SET NOCOUNT ON;
SELECT T.codTutoria, (CC.nombre + ' ' + CC.apellido) AS NombreCliente , (TT.nombre + ' ' + TT.apellido) AS nombreTutor, C.nombreClase, T.temas, T.fecha,T.tipo,T.horas,T.personas, T.conocimientoCliente,T.estado FROM Tutoria T LEFT JOIN Clase C ON T.codClase = C.codClase LEFT JOIN Tutor TT ON T.codTutor = TT.codTutor LEFT JOIN Cliente CC ON T.codCliente = CC.codCliente WHERE T.fecha BETWEEN @fecha1 AND @fecha2
GO
