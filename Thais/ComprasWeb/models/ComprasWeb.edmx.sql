
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/14/2018 14:57:08
-- Generated from EDMX file: C:\Users\th_r_\source\repos\appCompras\ComprasWeb\models\ComprasWeb.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [thaisdb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PEDIDOS_CLIENTE]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PEDIDOS] DROP CONSTRAINT [FK_PEDIDOS_CLIENTE];
GO
IF OBJECT_ID(N'[dbo].[FK_PEDIDOS_PRODUTO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PEDIDOS] DROP CONSTRAINT [FK_PEDIDOS_PRODUTO];
GO
IF OBJECT_ID(N'[dbo].[FK_RELACAO_LOJA_PRODUTO_LOJA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RELACAO_LOJA_PRODUTO] DROP CONSTRAINT [FK_RELACAO_LOJA_PRODUTO_LOJA];
GO
IF OBJECT_ID(N'[dbo].[FK_RELACAO_LOJA_PRODUTO_PRODUTO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RELACAO_LOJA_PRODUTO] DROP CONSTRAINT [FK_RELACAO_LOJA_PRODUTO_PRODUTO];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CLIENTE]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CLIENTE];
GO
IF OBJECT_ID(N'[dbo].[LOJA]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LOJA];
GO
IF OBJECT_ID(N'[dbo].[PEDIDOS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PEDIDOS];
GO
IF OBJECT_ID(N'[dbo].[PRODUTO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PRODUTO];
GO
IF OBJECT_ID(N'[dbo].[RELACAO_LOJA_PRODUTO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RELACAO_LOJA_PRODUTO];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CLIENTE'
CREATE TABLE [dbo].[CLIENTE] (
    [ID_CLIENTE] bigint IDENTITY(1,1) NOT NULL,
    [NOME] varchar(100)  NOT NULL
);
GO

-- Creating table 'LOJA'
CREATE TABLE [dbo].[LOJA] (
    [ID_LOJA] bigint IDENTITY(1,1) NOT NULL,
    [LOJA1] varchar(100)  NOT NULL,
    [LOCALIDADE] varchar(100)  NULL
);
GO

-- Creating table 'PEDIDOS'
CREATE TABLE [dbo].[PEDIDOS] (
    [ID_PEDIDO] bigint  NOT NULL,
    [ID_CLIENTE] bigint  NOT NULL,
    [VALOR] varchar(100)  NULL,
    [PEDIDO] bigint  NOT NULL,
    [ID_PRODUTO] bigint  NOT NULL
);
GO

-- Creating table 'PRODUTO'
CREATE TABLE [dbo].[PRODUTO] (
    [ID_PRODUTO] bigint IDENTITY(1,1) NOT NULL,
    [PRODUTO1] varchar(100)  NOT NULL
);
GO

-- Creating table 'RELACAO_LOJA_PRODUTO'
CREATE TABLE [dbo].[RELACAO_LOJA_PRODUTO] (
    [ID_RELACAO_LOJA_PRODUTO] bigint IDENTITY(1,1) NOT NULL,
    [ID_LOJA] bigint  NOT NULL,
    [ID_PRODUTO] bigint  NOT NULL,
    [ESTOQUE] bigint  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID_CLIENTE] in table 'CLIENTE'
ALTER TABLE [dbo].[CLIENTE]
ADD CONSTRAINT [PK_CLIENTE]
    PRIMARY KEY CLUSTERED ([ID_CLIENTE] ASC);
GO

-- Creating primary key on [ID_LOJA] in table 'LOJA'
ALTER TABLE [dbo].[LOJA]
ADD CONSTRAINT [PK_LOJA]
    PRIMARY KEY CLUSTERED ([ID_LOJA] ASC);
GO

-- Creating primary key on [ID_PEDIDO] in table 'PEDIDOS'
ALTER TABLE [dbo].[PEDIDOS]
ADD CONSTRAINT [PK_PEDIDOS]
    PRIMARY KEY CLUSTERED ([ID_PEDIDO] ASC);
GO

-- Creating primary key on [ID_PRODUTO] in table 'PRODUTO'
ALTER TABLE [dbo].[PRODUTO]
ADD CONSTRAINT [PK_PRODUTO]
    PRIMARY KEY CLUSTERED ([ID_PRODUTO] ASC);
GO

-- Creating primary key on [ID_RELACAO_LOJA_PRODUTO] in table 'RELACAO_LOJA_PRODUTO'
ALTER TABLE [dbo].[RELACAO_LOJA_PRODUTO]
ADD CONSTRAINT [PK_RELACAO_LOJA_PRODUTO]
    PRIMARY KEY CLUSTERED ([ID_RELACAO_LOJA_PRODUTO] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ID_PRODUTO] in table 'PEDIDOS'
ALTER TABLE [dbo].[PEDIDOS]
ADD CONSTRAINT [FK_PEDIDOS_CLIENTE]
    FOREIGN KEY ([ID_PRODUTO])
    REFERENCES [dbo].[PRODUTO]
        ([ID_PRODUTO])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PEDIDOS_CLIENTE'
CREATE INDEX [IX_FK_PEDIDOS_CLIENTE]
ON [dbo].[PEDIDOS]
    ([ID_PRODUTO]);
GO

-- Creating foreign key on [ID_PRODUTO] in table 'RELACAO_LOJA_PRODUTO'
ALTER TABLE [dbo].[RELACAO_LOJA_PRODUTO]
ADD CONSTRAINT [FK_RELACAO_LOJA_PRODUTO_LOJA]
    FOREIGN KEY ([ID_PRODUTO])
    REFERENCES [dbo].[PRODUTO]
        ([ID_PRODUTO])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RELACAO_LOJA_PRODUTO_LOJA'
CREATE INDEX [IX_FK_RELACAO_LOJA_PRODUTO_LOJA]
ON [dbo].[RELACAO_LOJA_PRODUTO]
    ([ID_PRODUTO]);
GO

-- Creating foreign key on [ID_CLIENTE] in table 'PEDIDOS'
ALTER TABLE [dbo].[PEDIDOS]
ADD CONSTRAINT [FK_PEDIDOS_CLIENTE1]
    FOREIGN KEY ([ID_CLIENTE])
    REFERENCES [dbo].[CLIENTE]
        ([ID_CLIENTE])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PEDIDOS_CLIENTE1'
CREATE INDEX [IX_FK_PEDIDOS_CLIENTE1]
ON [dbo].[PEDIDOS]
    ([ID_CLIENTE]);
GO

-- Creating foreign key on [ID_LOJA] in table 'RELACAO_LOJA_PRODUTO'
ALTER TABLE [dbo].[RELACAO_LOJA_PRODUTO]
ADD CONSTRAINT [FK_RELACAO_LOJA_PRODUTO_LOJA1]
    FOREIGN KEY ([ID_LOJA])
    REFERENCES [dbo].[LOJA]
        ([ID_LOJA])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RELACAO_LOJA_PRODUTO_LOJA1'
CREATE INDEX [IX_FK_RELACAO_LOJA_PRODUTO_LOJA1]
ON [dbo].[RELACAO_LOJA_PRODUTO]
    ([ID_LOJA]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------