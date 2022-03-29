USE BigBoxPhoneStore
GO
/****** Object: Table [dbo].[PhoneProducts] Script Date: 3/24/2022 12:59:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products]
(
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [Name] [varchar](50) NOT NULL,
    [Description] [varchar](max) NULL,
    [CategoryID] [int] NOT NULL,
    [Price] [money] NOT NULL,
    [CreatedAt] [datetime] NOT NULL,
    [ModifiedAt] [datetime] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

