USE [GraphQL_DB]
GO
/****** Object:  Table [dbo].[cidade]    Script Date: 21/02/2023 17:30:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cidade](
	[id] [int] NOT NULL,
	[nome] [varchar](120) NULL,
	[uf] [int] NULL,
	[ibge] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[estado]    Script Date: 21/02/2023 17:30:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estado](
	[id] [int] NOT NULL,
	[nome] [varchar](75) NULL,
	[uf] [varchar](2) NULL,
	[ibge] [int] NULL,
	[pais] [int] NULL,
	[ddd] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pais]    Script Date: 21/02/2023 17:30:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pais](
	[id] [int] NOT NULL,
	[nome] [varchar](60) NULL,
	[nome_pt] [varchar](60) NULL,
	[sigla] [varchar](2) NULL,
	[bacen] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[cidade] ADD  DEFAULT (NULL) FOR [nome]
GO
ALTER TABLE [dbo].[cidade] ADD  DEFAULT (NULL) FOR [uf]
GO
ALTER TABLE [dbo].[cidade] ADD  DEFAULT (NULL) FOR [ibge]
GO
ALTER TABLE [dbo].[estado] ADD  DEFAULT (NULL) FOR [nome]
GO
ALTER TABLE [dbo].[estado] ADD  DEFAULT (NULL) FOR [uf]
GO
ALTER TABLE [dbo].[estado] ADD  DEFAULT (NULL) FOR [ibge]
GO
ALTER TABLE [dbo].[estado] ADD  DEFAULT (NULL) FOR [pais]
GO
ALTER TABLE [dbo].[estado] ADD  DEFAULT (NULL) FOR [ddd]
GO
ALTER TABLE [dbo].[pais] ADD  DEFAULT (NULL) FOR [nome]
GO
ALTER TABLE [dbo].[pais] ADD  DEFAULT (NULL) FOR [nome_pt]
GO
ALTER TABLE [dbo].[pais] ADD  DEFAULT (NULL) FOR [sigla]
GO
ALTER TABLE [dbo].[pais] ADD  DEFAULT (NULL) FOR [bacen]
GO
EXEC sys.sp_addextendedproperty @name=N'comentario_cidade', @value=N'Municipios das Unidades Federativas' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cidade'
GO
EXEC sys.sp_addextendedproperty @name=N'comentario_estado', @value=N'Unidades Federativas' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'estado'
GO
EXEC sys.sp_addextendedproperty @name=N'comentario_pais', @value=N'Unidades Federativas' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'pais'
GO
