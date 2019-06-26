SET QUOTED_IDENTIFIER OFF;
GO
USE [KisiselVerilerDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_AileBilgileri_KisiselBilgiler]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AileBilgileri] DROP CONSTRAINT [FK_AileBilgileri_KisiselBilgiler];
GO
IF OBJECT_ID(N'[KisiselVerilerDBModelStoreContainer].[FK_EgitimBilgileri_KisiselBilgiler]', 'F') IS NOT NULL
    ALTER TABLE [KisiselVerilerDBModelStoreContainer].[EgitimBilgileri] DROP CONSTRAINT [FK_EgitimBilgileri_KisiselBilgiler];
GO
IF OBJECT_ID(N'[dbo].[FK_IletisimBilgileri_KisiselBilgiler]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[IletisimBilgileri] DROP CONSTRAINT [FK_IletisimBilgileri_KisiselBilgiler];
GO
IF OBJECT_ID(N'[dbo].[FK_KisiIlgiAlanlari_İlgiAlanlari]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[KisiHobileri] DROP CONSTRAINT [FK_KisiIlgiAlanlari_İlgiAlanlari];
GO
IF OBJECT_ID(N'[dbo].[FK_KisiIlgiAlanlari_KisiselBilgiler]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[KisiHobileri] DROP CONSTRAINT [FK_KisiIlgiAlanlari_KisiselBilgiler];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[AileBilgileri]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AileBilgileri];
GO
IF OBJECT_ID(N'[dbo].[Hobiler]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Hobiler];
GO
IF OBJECT_ID(N'[dbo].[IletisimBilgileri]', 'U') IS NOT NULL
    DROP TABLE [dbo].[IletisimBilgileri];
GO
IF OBJECT_ID(N'[dbo].[KisiHobileri]', 'U') IS NOT NULL
    DROP TABLE [dbo].[KisiHobileri];
GO
IF OBJECT_ID(N'[dbo].[KisiselBilgiler]', 'U') IS NOT NULL
    DROP TABLE [dbo].[KisiselBilgiler];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[KisiselVerilerDBModelStoreContainer].[EgitimBilgileri]', 'U') IS NOT NULL
    DROP TABLE [KisiselVerilerDBModelStoreContainer].[EgitimBilgileri];
GO
IF OBJECT_ID(N'[KisiselVerilerDBModelStoreContainer].[database_firewall_rules]', 'U') IS NOT NULL
    DROP TABLE [KisiselVerilerDBModelStoreContainer].[database_firewall_rules];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'AileBilgileri'
CREATE TABLE [dbo].[AileBilgileri] (
    [AileBilgileriID] int IDENTITY(1,1) NOT NULL,
    [KisiID] int  NOT NULL,
    [AnneAdi] varchar(20)  NULL,
    [BabaAdi] varchar(20)  NULL,
    [KardesSayisi] tinyint  NULL
);
GO

-- Creating table 'Hobiler'
CREATE TABLE [dbo].[Hobiler] (
    [HobiID] int IDENTITY(1,1) NOT NULL,
    [HobiAdi] varchar(20)  NULL,
    [HobiUstKategoriID] int  NULL
);
GO

-- Creating table 'IletisimBilgileri'
CREATE TABLE [dbo].[IletisimBilgileri] (
    [IletisimBilgileriID] int IDENTITY(1,1) NOT NULL,
    [KisiID] int  NOT NULL,
    [Adres] varchar(50)  NULL,
    [Telefon] varchar(15)  NULL,
    [Mail] varchar(20)  NULL
);
GO

-- Creating table 'KisiHobileri'
CREATE TABLE [dbo].[KisiHobileri] (
    [KisiHobileriID] int IDENTITY(1,1) NOT NULL,
    [KisiID] int  NOT NULL,
    [HobiID] int  NOT NULL
);
GO

-- Creating table 'KisiselBilgiler'
CREATE TABLE [dbo].[KisiselBilgiler] (
    [KisiID] int IDENTITY(1,1) NOT NULL,
    [KisiAdi] varchar(30)  NULL,
    [KisiSoyadi] varchar(30)  NULL,
    [KisiTCNo] varchar(11)  NULL,
    [KisiDogumTarihi] datetime  NOT NULL,
    [KisiDogumYeri] varchar(30)  NULL,
    [KisiUyruk] varchar(20)  NULL,
    [KisiAylikGelir] decimal(19,4)  NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'EgitimBilgileri'
CREATE TABLE [dbo].[EgitimBilgileri] (
    [KisiID] int  NOT NULL,
    [Ilkokul] varchar(30)  NULL,
    [Ortaokul] varchar(30)  NULL,
    [Lise] varchar(30)  NULL,
    [Universite] varchar(30)  NULL
);
GO

-- Creating table 'database_firewall_rules'
CREATE TABLE [dbo].[database_firewall_rules] (
    [id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(128)  NOT NULL,
    [start_ip_address] varchar(45)  NOT NULL,
    [end_ip_address] varchar(45)  NOT NULL,
    [create_date] datetime  NOT NULL,
    [modify_date] datetime  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [AileBilgileriID] in table 'AileBilgileri'
ALTER TABLE [dbo].[AileBilgileri]
ADD CONSTRAINT [PK_AileBilgileri]
    PRIMARY KEY CLUSTERED ([AileBilgileriID] ASC);
GO

-- Creating primary key on [HobiID] in table 'Hobiler'
ALTER TABLE [dbo].[Hobiler]
ADD CONSTRAINT [PK_Hobiler]
    PRIMARY KEY CLUSTERED ([HobiID] ASC);
GO

-- Creating primary key on [IletisimBilgileriID] in table 'IletisimBilgileri'
ALTER TABLE [dbo].[IletisimBilgileri]
ADD CONSTRAINT [PK_IletisimBilgileri]
    PRIMARY KEY CLUSTERED ([IletisimBilgileriID] ASC);
GO

-- Creating primary key on [KisiHobileriID] in table 'KisiHobileri'
ALTER TABLE [dbo].[KisiHobileri]
ADD CONSTRAINT [PK_KisiHobileri]
    PRIMARY KEY CLUSTERED ([KisiHobileriID] ASC);
GO

-- Creating primary key on [KisiID] in table 'KisiselBilgiler'
ALTER TABLE [dbo].[KisiselBilgiler]
ADD CONSTRAINT [PK_KisiselBilgiler]
    PRIMARY KEY CLUSTERED ([KisiID] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [KisiID] in table 'EgitimBilgileri'
ALTER TABLE [dbo].[EgitimBilgileri]
ADD CONSTRAINT [PK_EgitimBilgileri]
    PRIMARY KEY CLUSTERED ([KisiID] ASC);
GO

-- Creating primary key on [id], [name], [start_ip_address], [end_ip_address], [create_date], [modify_date] in table 'database_firewall_rules'
ALTER TABLE [dbo].[database_firewall_rules]
ADD CONSTRAINT [PK_database_firewall_rules]
    PRIMARY KEY CLUSTERED ([id], [name], [start_ip_address], [end_ip_address], [create_date], [modify_date] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [KisiID] in table 'AileBilgileri'
ALTER TABLE [dbo].[AileBilgileri]
ADD CONSTRAINT [FK_AileBilgileri_KisiselBilgiler]
    FOREIGN KEY ([KisiID])
    REFERENCES [dbo].[KisiselBilgiler]
        ([KisiID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AileBilgileri_KisiselBilgiler'
CREATE INDEX [IX_FK_AileBilgileri_KisiselBilgiler]
ON [dbo].[AileBilgileri]
    ([KisiID]);
GO

-- Creating foreign key on [HobiID] in table 'KisiHobileri'
ALTER TABLE [dbo].[KisiHobileri]
ADD CONSTRAINT [FK_KisiIlgiAlanlari_İlgiAlanlari]
    FOREIGN KEY ([HobiID])
    REFERENCES [dbo].[Hobiler]
        ([HobiID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_KisiIlgiAlanlari_İlgiAlanlari'
CREATE INDEX [IX_FK_KisiIlgiAlanlari_İlgiAlanlari]
ON [dbo].[KisiHobileri]
    ([HobiID]);
GO

-- Creating foreign key on [KisiID] in table 'IletisimBilgileri'
ALTER TABLE [dbo].[IletisimBilgileri]
ADD CONSTRAINT [FK_IletisimBilgileri_KisiselBilgiler]
    FOREIGN KEY ([KisiID])
    REFERENCES [dbo].[KisiselBilgiler]
        ([KisiID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_IletisimBilgileri_KisiselBilgiler'
CREATE INDEX [IX_FK_IletisimBilgileri_KisiselBilgiler]
ON [dbo].[IletisimBilgileri]
    ([KisiID]);
GO

-- Creating foreign key on [KisiID] in table 'KisiHobileri'
ALTER TABLE [dbo].[KisiHobileri]
ADD CONSTRAINT [FK_KisiIlgiAlanlari_KisiselBilgiler]
    FOREIGN KEY ([KisiID])
    REFERENCES [dbo].[KisiselBilgiler]
        ([KisiID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_KisiIlgiAlanlari_KisiselBilgiler'
CREATE INDEX [IX_FK_KisiIlgiAlanlari_KisiselBilgiler]
ON [dbo].[KisiHobileri]
    ([KisiID]);
GO

-- Creating foreign key on [KisiID] in table 'EgitimBilgileri'
ALTER TABLE [dbo].[EgitimBilgileri]
ADD CONSTRAINT [FK_EgitimBilgileri_KisiselBilgiler]
    FOREIGN KEY ([KisiID])
    REFERENCES [dbo].[KisiselBilgiler]
        ([KisiID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------