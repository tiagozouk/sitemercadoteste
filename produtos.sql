USE [TesteSiteMercado]
GO

/****** Object:  Table [dbo].[produtos]    Script Date: 28/05/2021 14:53:20 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[produtos](
	[id] [uniqueidentifier] NOT NULL,
	[Name] [varchar](400) NOT NULL,
	[preco] [money] NOT NULL,
	[descricao] [varchar](1000) NOT NULL,
	[CreateAt] [datetime2](7) NOT NULL,
	[url_imagem] [varchar](512) NULL,
	[UpdateAt] [datetime2](7) NULL,
 CONSTRAINT [PK__produtos__8D509EBC57917E61] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


