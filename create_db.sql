USE [ImageStuff]
GO
/****** Object:  Table [dbo].[Stuffs]    Script Date: 6/5/2016 9:45:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Stuffs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Word] [varchar](50) NOT NULL,
	[ImageFileName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Stuffs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO