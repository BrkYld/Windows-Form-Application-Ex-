USE [MyLibrary]
GO
/****** Object:  Table [dbo].[Dil]    Script Date: 16.12.2018 23:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dil](
	[dilID] [int] IDENTITY(1,1) NOT NULL,
	[dil] [nvarchar](50) NULL,
 CONSTRAINT [PK_Dil] PRIMARY KEY CLUSTERED 
(
	[dilID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[İşlem]    Script Date: 16.12.2018 23:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[İşlem](
	[islemID] [int] IDENTITY(1,1) NOT NULL,
	[kisiID] [int] NOT NULL,
	[kitapID] [int] NOT NULL,
	[alimTarih] [date] NULL,
	[iadeTarih] [date] NULL,
 CONSTRAINT [PK_İşlem] PRIMARY KEY CLUSTERED 
(
	[islemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kisi]    Script Date: 16.12.2018 23:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kisi](
	[kisiID] [int] IDENTITY(1,1) NOT NULL,
	[isim] [nvarchar](50) NOT NULL,
	[soyisim] [nvarchar](50) NOT NULL,
	[cinsiyet] [bit] NULL,
	[doğumTarih] [date] NULL,
	[personel] [bit] NOT NULL,
	[ogrenci] [bit] NOT NULL,
 CONSTRAINT [PK_Kisi] PRIMARY KEY CLUSTERED 
(
	[kisiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kitap]    Script Date: 16.12.2018 23:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kitap](
	[kitapID] [int] IDENTITY(1,1) NOT NULL,
	[kitapAdi] [nvarchar](50) NOT NULL,
	[yazarID] [int] NOT NULL,
	[turID] [int] NOT NULL,
	[sayfaSayisi] [int] NOT NULL,
	[stok] [int] NULL,
	[kutuphaneID] [int] NOT NULL,
	[dilID] [int] NOT NULL,
	[yayınID] [int] NOT NULL,
	[konumID] [int] NULL,
 CONSTRAINT [PK_Kitap] PRIMARY KEY CLUSTERED 
(
	[kitapID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Konum]    Script Date: 16.12.2018 23:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Konum](
	[konumID] [int] IDENTITY(1,1) NOT NULL,
	[rafNo] [int] NULL,
 CONSTRAINT [PK_Konum] PRIMARY KEY CLUSTERED 
(
	[konumID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kütüphane]    Script Date: 16.12.2018 23:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kütüphane](
	[kutuphaneID] [int] NOT NULL,
	[kutuphaneİsmi] [nvarchar](100) NULL,
 CONSTRAINT [PK_Kütüphane_1] PRIMARY KEY CLUSTERED 
(
	[kutuphaneID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Öğrenci]    Script Date: 16.12.2018 23:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Öğrenci](
	[kisiID] [int] NOT NULL,
 CONSTRAINT [PK_Öğrenci] PRIMARY KEY CLUSTERED 
(
	[kisiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personel]    Script Date: 16.12.2018 23:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personel](
	[kisiID] [int] NOT NULL,
	[kullaniciAdı] [nvarchar](50) NOT NULL,
	[sifre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Personel] PRIMARY KEY CLUSTERED 
(
	[kisiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stok]    Script Date: 16.12.2018 23:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stok](
	[stokID] [int] NOT NULL,
	[stokAdedi] [int] NOT NULL,
 CONSTRAINT [PK_Stok] PRIMARY KEY CLUSTERED 
(
	[stokID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tür]    Script Date: 16.12.2018 23:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tür](
	[turID] [int] IDENTITY(1,1) NOT NULL,
	[turAdi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Tür] PRIMARY KEY CLUSTERED 
(
	[turID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[YayınEvi]    Script Date: 16.12.2018 23:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[YayınEvi](
	[yayınID] [int] IDENTITY(1,1) NOT NULL,
	[yayınEvi] [nvarchar](50) NULL,
 CONSTRAINT [PK_YayınEvi] PRIMARY KEY CLUSTERED 
(
	[yayınID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Yazar]    Script Date: 16.12.2018 23:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yazar](
	[yazarID] [int] IDENTITY(1,1) NOT NULL,
	[yazarAd] [nvarchar](50) NOT NULL,
	[yazarSoyad] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Yazar] PRIMARY KEY CLUSTERED 
(
	[yazarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[İşlem] ADD  CONSTRAINT [DF_İşlem_alimTarih]  DEFAULT (getdate()) FOR [alimTarih]
GO
ALTER TABLE [dbo].[Kitap] ADD  CONSTRAINT [DF_Kitap_kutuphaneID]  DEFAULT ((1)) FOR [kutuphaneID]
GO
ALTER TABLE [dbo].[Kütüphane] ADD  CONSTRAINT [DF_Kütüphane_kutuphaneID]  DEFAULT ((1)) FOR [kutuphaneID]
GO
ALTER TABLE [dbo].[Personel] ADD  CONSTRAINT [DF_Personel_kullaniciAdı]  DEFAULT (N'admin') FOR [kullaniciAdı]
GO
ALTER TABLE [dbo].[Personel] ADD  CONSTRAINT [DF_Personel_sifre]  DEFAULT ((1234)) FOR [sifre]
GO
ALTER TABLE [dbo].[Stok] ADD  CONSTRAINT [DF_Stok_stokAdedi]  DEFAULT ((50)) FOR [stokAdedi]
GO
ALTER TABLE [dbo].[İşlem]  WITH CHECK ADD  CONSTRAINT [FK_İşlem_Kitap1] FOREIGN KEY([kitapID])
REFERENCES [dbo].[Kitap] ([kitapID])
GO
ALTER TABLE [dbo].[İşlem] CHECK CONSTRAINT [FK_İşlem_Kitap1]
GO
ALTER TABLE [dbo].[İşlem]  WITH CHECK ADD  CONSTRAINT [FK_İşlem_Öğrenci] FOREIGN KEY([kisiID])
REFERENCES [dbo].[Öğrenci] ([kisiID])
GO
ALTER TABLE [dbo].[İşlem] CHECK CONSTRAINT [FK_İşlem_Öğrenci]
GO
ALTER TABLE [dbo].[Kitap]  WITH CHECK ADD  CONSTRAINT [FK_Kitap_Dil] FOREIGN KEY([dilID])
REFERENCES [dbo].[Dil] ([dilID])
GO
ALTER TABLE [dbo].[Kitap] CHECK CONSTRAINT [FK_Kitap_Dil]
GO
ALTER TABLE [dbo].[Kitap]  WITH CHECK ADD  CONSTRAINT [FK_Kitap_Konum] FOREIGN KEY([konumID])
REFERENCES [dbo].[Konum] ([konumID])
GO
ALTER TABLE [dbo].[Kitap] CHECK CONSTRAINT [FK_Kitap_Konum]
GO
ALTER TABLE [dbo].[Kitap]  WITH CHECK ADD  CONSTRAINT [FK_Kitap_Kütüphane1] FOREIGN KEY([kutuphaneID])
REFERENCES [dbo].[Kütüphane] ([kutuphaneID])
GO
ALTER TABLE [dbo].[Kitap] CHECK CONSTRAINT [FK_Kitap_Kütüphane1]
GO
ALTER TABLE [dbo].[Kitap]  WITH CHECK ADD  CONSTRAINT [FK_Kitap_Tür] FOREIGN KEY([turID])
REFERENCES [dbo].[Tür] ([turID])
GO
ALTER TABLE [dbo].[Kitap] CHECK CONSTRAINT [FK_Kitap_Tür]
GO
ALTER TABLE [dbo].[Kitap]  WITH CHECK ADD  CONSTRAINT [FK_Kitap_YayınEvi] FOREIGN KEY([yayınID])
REFERENCES [dbo].[YayınEvi] ([yayınID])
GO
ALTER TABLE [dbo].[Kitap] CHECK CONSTRAINT [FK_Kitap_YayınEvi]
GO
ALTER TABLE [dbo].[Kitap]  WITH CHECK ADD  CONSTRAINT [FK_Kitap_Yazar] FOREIGN KEY([yazarID])
REFERENCES [dbo].[Yazar] ([yazarID])
GO
ALTER TABLE [dbo].[Kitap] CHECK CONSTRAINT [FK_Kitap_Yazar]
GO
ALTER TABLE [dbo].[Öğrenci]  WITH CHECK ADD  CONSTRAINT [FK_Öğrenci_Kisi] FOREIGN KEY([kisiID])
REFERENCES [dbo].[Kisi] ([kisiID])
GO
ALTER TABLE [dbo].[Öğrenci] CHECK CONSTRAINT [FK_Öğrenci_Kisi]
GO
ALTER TABLE [dbo].[Personel]  WITH CHECK ADD  CONSTRAINT [FK_Personel_Kisi] FOREIGN KEY([kisiID])
REFERENCES [dbo].[Kisi] ([kisiID])
GO
ALTER TABLE [dbo].[Personel] CHECK CONSTRAINT [FK_Personel_Kisi]
GO
ALTER TABLE [dbo].[Stok]  WITH CHECK ADD  CONSTRAINT [FK_Stok_Kitap] FOREIGN KEY([stokID])
REFERENCES [dbo].[Kitap] ([kitapID])
GO
ALTER TABLE [dbo].[Stok] CHECK CONSTRAINT [FK_Stok_Kitap]
GO
/****** Object:  Trigger [dbo].[Kitapİade]    Script Date: 16.12.2018 23:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[Kitapİade] on [dbo].[İşlem]
after delete
as
begin
  declare @id int
  select @id = kitapID from deleted
  update Stok set stokAdedi = stokAdedi + 1 where stokID = @id
  declare @stok int
  select @stok = stokAdedi from dbo.Stok where stokID = @id
  update dbo.Kitap set stok = @stok where kitapID = @id
end
GO
ALTER TABLE [dbo].[İşlem] ENABLE TRIGGER [Kitapİade]
GO
/****** Object:  Trigger [dbo].[KitapKirala]    Script Date: 16.12.2018 23:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[KitapKirala] on [dbo].[İşlem]
after insert
as
begin
	DECLARE @id int
	select @id = kitapID from inserted
	--select stokAdedi from Stok where stokID = @id
	update Stok set stokAdedi = stokAdedi - 1 where stokID = @id
	declare @stok int
	select @stok = stokAdedi from dbo.Stok where stokID = @id
	update dbo.Kitap set stok = @stok where kitapID = @id
end
GO
ALTER TABLE [dbo].[İşlem] ENABLE TRIGGER [KitapKirala]
GO
/****** Object:  Trigger [dbo].[OTOKAYIT]    Script Date: 16.12.2018 23:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[OTOKAYIT] on [dbo].[Kisi]
after insert
as
begin
	DECLARE @bool bit
	select @bool = ogrenci from inserted
		IF @bool = 1
		begin
		insert into dbo.Öğrenci(kisiID) select kisiID from inserted
		end
		ELSE
		begin
		insert into dbo.Personel(kisiID) select kisiID from inserted
		end
end
GO
ALTER TABLE [dbo].[Kisi] ENABLE TRIGGER [OTOKAYIT]
GO
/****** Object:  Trigger [dbo].[konumAyarla]    Script Date: 16.12.2018 23:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[konumAyarla] on [dbo].[Kitap]
after insert
as
begin
	insert into Konum(rafNo) values(1)
	update Konum set rafNo = IDENT_CURRENT('Konum') where konumID = IDENT_CURRENT('Konum')
	update Kitap set konumID = IDENT_CURRENT('Konum') where kitapID = IDENT_CURRENT('Kitap')
	
end
GO
ALTER TABLE [dbo].[Kitap] ENABLE TRIGGER [konumAyarla]
GO
/****** Object:  Trigger [dbo].[StokOlustur]    Script Date: 16.12.2018 23:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[StokOlustur] on [dbo].[Kitap]
after insert
as
begin
	insert into dbo.Stok(stokID) select kitapID from inserted
	declare @id int
	select @id = kitapID from inserted
	declare @stok int
	select @stok = stokAdedi from dbo.Stok where stokId = @id
	update dbo.Kitap set stok = @stok where kitapID = @id
end
GO
ALTER TABLE [dbo].[Kitap] ENABLE TRIGGER [StokOlustur]
GO
