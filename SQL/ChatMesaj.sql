USE [ChatMesaj]
GO
/****** Object:  Table [dbo].[Table_Kullanıcı]    Script Date: 12.07.2023 14:59:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table_Kullanıcı](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[Ad] [varchar](15) NULL,
	[SoyAd] [varchar](15) NULL,
	[KullanıcıAdı] [varchar](15) NULL,
	[Sifre] [varchar](20) NULL,
	[Mesaj] [varchar](50) NULL,
	[KimdenGeldi] [varchar](15) NULL,
	[ToplamMesaj] [int] NULL,
 CONSTRAINT [PK_Table_Kullanıcı] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Table_Kullanıcı] ON 

INSERT [dbo].[Table_Kullanıcı] ([id], [Ad], [SoyAd], [KullanıcıAdı], [Sifre], [Mesaj], [KimdenGeldi], [ToplamMesaj]) VALUES (1, N'ALP', N'MertOğlu', N'f', N'1', N'SDFSFD', N'f', 1)
INSERT [dbo].[Table_Kullanıcı] ([id], [Ad], [SoyAd], [KullanıcıAdı], [Sifre], [Mesaj], [KimdenGeldi], [ToplamMesaj]) VALUES (2, N'sdf', N'sdf', N'ff', N'1', N'Tester', N'f', 0)
SET IDENTITY_INSERT [dbo].[Table_Kullanıcı] OFF
GO
ALTER TABLE [dbo].[Table_Kullanıcı] ADD  CONSTRAINT [DF_Table_Kullanıcı_ToplamMesaj]  DEFAULT ((0)) FOR [ToplamMesaj]
GO
