USE [DVLDDatabase]
GO

/****** Object:  Table [dbo].[People]    Script Date: 3/22/2026 4:12:55 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[People](
	[PearsonID] [int] IDENTITY(1,1) NOT NULL,
	[NationalNumber] [nchar](10) NOT NULL,
	[FirstName] [nchar](20) NOT NULL,
	[SecondName] [nchar](20) NOT NULL,
	[ThirdName] [nchar](20) NOT NULL,
	[LastName] [nchar](20) NOT NULL,
	[DateOfBirth] [datetime] NOT NULL,
	[Gendor] [tinyint] NOT NULL,
	[Phone] [nchar](50) NOT NULL,
	[Address] [nchar](50) NULL,
	[Email] [nchar](50) NOT NULL,
	[NationalityCountryID] [int] NOT NULL,
	[ImagePath] [nchar](250) NOT NULL,
 CONSTRAINT [PK_People] PRIMARY KEY CLUSTERED 
(
	[PearsonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[People]  WITH CHECK ADD  CONSTRAINT [fk_People_Country] FOREIGN KEY([NationalityCountryID])
REFERENCES [dbo].[Countries] ([CountryID])
GO

ALTER TABLE [dbo].[People] CHECK CONSTRAINT [fk_People_Country]
GO

USE [DVLDDatabase]
GO

/****** Object:  Table [dbo].[Countries]    Script Date: 3/22/2026 4:14:33 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Countries](
	[CountryID] [int] NOT NULL,
	[CountryName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[CountryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


