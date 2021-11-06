/*
 Navicat Premium Data Transfer

 Source Server         : test
 Source Server Type    : SQL Server
 Source Server Version : 15004178
 Source Host           : localhost:1433
 Source Catalog        : promotions
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 15004178
 File Encoding         : 65001

 Date: 06/11/2021 11:40:16
*/


-- ----------------------------
-- Table structure for promotions
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[promotions]') AND type IN ('U'))
	DROP TABLE [dbo].[promotions]
GO

CREATE TABLE [dbo].[promotions] (
  [Id] int  NOT NULL,
  [Name] varchar(80) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Email] varchar(120) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Code] varchar(200) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Status] int  NULL
)
GO

ALTER TABLE [dbo].[promotions] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of promotions
-- ----------------------------
INSERT INTO [dbo].[promotions] ([Id], [Name], [Email], [Code], [Status]) VALUES (N'1', N'Alexander Rojas', N'omartaquiri@gmail.com', N'XA33242341111', N'1')
GO

INSERT INTO [dbo].[promotions] ([Id], [Name], [Email], [Code], [Status]) VALUES (N'2', N'Alexis Abarca', N'alexis.abarca@gmail.com', N'XA3324234333', N'1')
GO

INSERT INTO [dbo].[promotions] ([Id], [Name], [Email], [Code], [Status]) VALUES (N'3', N'Diana Hurtado Paucar', N'diana.hurtado@gmail.com', N'XA332423411', N'1')
GO

INSERT INTO [dbo].[promotions] ([Id], [Name], [Email], [Code], [Status]) VALUES (N'4', N'Alexander Taquiri', N'alexander.taquiri@gmail.com', N'XA332423432323', N'1')
GO

