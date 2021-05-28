USE [TesteSiteMercado]
GO

/****** Object:  Table [dbo].[User]    Script Date: 28/05/2021 14:52:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[User](
	[Id] [uniqueidentifier] NULL,
	[CreateAt] [datetime2](7) NULL,
	[UpdateAt] [datetime2](7) NULL,
	[Name] [varchar](250) NULL,
	[Email] [varchar](250) NULL,
	[Password] [varchar](250) NULL
) ON [PRIMARY]
GO


