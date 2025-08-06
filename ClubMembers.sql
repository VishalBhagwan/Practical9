USE [master]
GO

/****** Object:  Database [ClubMembers] ******/
CREATE DATABASE [ClubMembers]
GO
USE ClubMembers
GO
/****** Object:  Table [dbo].[Members] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Members](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](200) NOT NULL,
	[ClubName] [varchar](200) NOT NULL,
	[Age] [int] NOT NULL,
	[Fee] [decimal] (10, 2) NOT NULL
 CONSTRAINT [PK_Name] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Members] ON 

INSERT [dbo].[Members] ([ID], [Name], [ClubName], [Age], [Fee]) VALUES (1, 'Sam', 'Reading', 20, 500.00)
INSERT [dbo].[Members] ([ID], [Name], [ClubName], [Age], [Fee]) VALUES (2, 'Kate', 'Pottery', 21, 750.00)
INSERT [dbo].[Members] ([ID], [Name], [ClubName], [Age], [Fee]) VALUES (3, 'Jake', 'Gaming', 20, 1000.00)
INSERT [dbo].[Members] ([ID], [Name], [ClubName], [Age], [Fee]) VALUES (4, 'Chris', 'Running', 19, 450.00)
INSERT [dbo].[Members] ([ID], [Name], [ClubName], [Age], [Fee]) VALUES (5, 'Jane', 'Reading', 19, 500.00)
INSERT [dbo].[Members] ([ID], [Name], [ClubName], [Age], [Fee]) VALUES (6, 'Tom', 'Football', 20, 550.00)
SET IDENTITY_INSERT [dbo].[Members] OFF
USE [master]
GO
ALTER DATABASE [ClubMembers] SET  READ_WRITE 
GO