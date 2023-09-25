/*
Navicat SQL Server Data Transfer

Source Server         : Local Edeplus Documentos
Source Server Version : 140000
Source Host           : 172.16.1.148,40103:1433
Source Database       : dbSagrario
Source Schema         : dbo

Target Server Type    : SQL Server
Target Server Version : 140000
File Encoding         : 65001

Date: 2023-09-25 09:44:37
*/


-- ----------------------------
-- Table structure for clientes
-- ----------------------------
DROP TABLE [clientes]
GO
CREATE TABLE [clientes] (
[idCliente] int NOT NULL IDENTITY(1,1) ,
[identificacion] varchar(255) NULL ,
[nombres] varchar(255) NULL ,
[apellidos] varchar(255) NULL ,
[celular] varchar(255) NULL ,
[email] varchar(255) NULL ,
[direccion] varchar(255) NULL 
)


GO
DBCC CHECKIDENT(N'[clientes]', RESEED, 12)
GO

-- ----------------------------
-- Records of clientes
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [clientes] ON
GO
INSERT INTO [clientes] ([idCliente], [identificacion], [nombres], [apellidos], [celular], [email], [direccion]) VALUES (N'6', N'0958030637', N'josue ', N'rea', N'0978965507', N'jrea314@outlook.com', N'guasmo sur'), (N'7', N'0958030637', N'josue ', N'rea', N'0978965507', N'jrea314@outlook.com', N'guasmo sur'), (N'8', N'0958030637', N'josue ', N'rea', N'0978965507', N'jrea314@outlook.com', N'guasmo sur'), (N'9', N'0958030637', N'josue ', N'rea', N'0978965507', N'jrea314@outlook.com', N'guasmo sur'), (N'10', N'0958030637', N'josue ', N'rea', N'0978965507', N'jrea314@outlook.com', N'guasmo sur'), (N'11', N'0958030637', N'josue ', N'rea', N'0978965507', N'jrea314@outlook.com', N'guasmo sur'), (N'12', N'0958030637', N'josue ', N'rea', N'0978965589', N'jrea3194@outlook.com', N'guasmo sur')
GO
GO
SET IDENTITY_INSERT [clientes] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for facturaCabecera
-- ----------------------------
DROP TABLE [facturaCabecera]
GO
CREATE TABLE [facturaCabecera] (
[idFacturaCabecera] int NOT NULL IDENTITY(1,1) ,
[idCliente] int NULL ,
[codigoFactura] varchar(255) NULL ,
[fechaEmision] varchar(255) NULL 
)


GO
DBCC CHECKIDENT(N'[facturaCabecera]', RESEED, 5)
GO

-- ----------------------------
-- Records of facturaCabecera
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [facturaCabecera] ON
GO
INSERT INTO [facturaCabecera] ([idFacturaCabecera], [idCliente], [codigoFactura], [fechaEmision]) VALUES (N'1', N'6', N'4e0d978c-08a9-4b60-a3fa-7c2c5258789d', N'25/09/2023 8:06:28'), (N'2', N'6', N'd3ee4080-6996-420f-ba16-c3e6d282a65f', N'25/09/2023 8:08:18'), (N'3', N'6', N'75feaa09-10c6-4435-a839-1bd0208fcacf', N'25/09/2023 9:36:34'), (N'4', N'6', N'4f0b0fcd-8778-4390-9ac4-4a963575dc06', N'25/09/2023 8:53:55'), (N'5', N'6', N'd7be86d3-b02b-4765-bd32-581da651e1fe', N'25/09/2023 8:58:08')
GO
GO
SET IDENTITY_INSERT [facturaCabecera] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for facturaDetalle
-- ----------------------------
DROP TABLE [facturaDetalle]
GO
CREATE TABLE [facturaDetalle] (
[idFacturaDetalle] int NOT NULL IDENTITY(1,1) ,
[idFacturaCabecera] int NULL ,
[idProducto] int NULL ,
[cantidad] varchar(255) NULL ,
[total] varchar(255) NULL 
)


GO
DBCC CHECKIDENT(N'[facturaDetalle]', RESEED, 18)
GO

-- ----------------------------
-- Records of facturaDetalle
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [facturaDetalle] ON
GO
INSERT INTO [facturaDetalle] ([idFacturaDetalle], [idFacturaCabecera], [idProducto], [cantidad], [total]) VALUES (N'2', N'2', N'2', N'DataGridViewTextBoxCell { ColumnIndex=2, RowIndex=0 }', N'DataGridViewTextBoxCell { ColumnIndex=4, RowIndex=0 }'), (N'5', N'4', N'5', N'10', N'50'), (N'6', N'4', N'6', N'10', N'2250'), (N'7', N'4', N'7', N'40', N'79,6'), (N'8', N'4', N'8', N'45', N'225'), (N'9', N'4', N'9', N'45', N'225'), (N'10', N'4', N'10', N'50', N'112,5'), (N'11', N'5', N'11', N'10', N'50'), (N'12', N'5', N'12', N'10', N'2250'), (N'13', N'5', N'13', N'5', N'25'), (N'16', N'3', N'16', N'10', N'50'), (N'17', N'3', N'17', N'10', N'2250'), (N'18', N'3', N'18', N'50', N'3999,4999999999995')
GO
GO
SET IDENTITY_INSERT [facturaDetalle] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for facturas
-- ----------------------------
DROP TABLE [facturas]
GO
CREATE TABLE [facturas] (
[idFactura] int NOT NULL IDENTITY(1,1) ,
[idFacturaCabecera] int NULL ,
[subtotal] varchar(255) NULL ,
[iva] varchar(255) NULL ,
[total] varchar(255) NULL 
)


GO
DBCC CHECKIDENT(N'[facturas]', RESEED, 5)
GO

-- ----------------------------
-- Records of facturas
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [facturas] ON
GO
INSERT INTO [facturas] ([idFactura], [idFacturaCabecera], [subtotal], [iva], [total]) VALUES (N'3', N'3', N'3999,4999999999995', N'479,94', N'4479,44'), (N'4', N'4', N'642,1', N'77,05', N'719,152'), (N'5', N'5', N'25', N'3', N'28')
GO
GO
SET IDENTITY_INSERT [facturas] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for productos
-- ----------------------------
DROP TABLE [productos]
GO
CREATE TABLE [productos] (
[idProducto] int NOT NULL IDENTITY(1,1) ,
[nombre] varchar(255) NULL ,
[precio] varchar(255) NULL 
)


GO
DBCC CHECKIDENT(N'[productos]', RESEED, 18)
GO

-- ----------------------------
-- Records of productos
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [productos] ON
GO
INSERT INTO [productos] ([idProducto], [nombre], [precio]) VALUES (N'2', N'cxv', N'DataGridViewTextBoxCell { ColumnIndex=3, RowIndex=0 }'), (N'5', N'sa', N'5'), (N'6', N'dfgdf', N'225'), (N'7', N'yu', N'1,99'), (N'8', N'5', N'5'), (N'9', N'45', N'5'), (N'10', N'arroz', N'2,25'), (N'11', N'sa', N'5'), (N'12', N'dfgdf', N'225'), (N'13', N'35', N'5'), (N'16', N'sa', N'5'), (N'17', N'dfgdf', N'225'), (N'18', N'sd', N'79,99')
GO
GO
SET IDENTITY_INSERT [productos] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Indexes structure for table clientes
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table clientes
-- ----------------------------
ALTER TABLE [clientes] ADD PRIMARY KEY ([idCliente])
GO

-- ----------------------------
-- Indexes structure for table facturaCabecera
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table facturaCabecera
-- ----------------------------
ALTER TABLE [facturaCabecera] ADD PRIMARY KEY ([idFacturaCabecera])
GO

-- ----------------------------
-- Indexes structure for table facturaDetalle
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table facturaDetalle
-- ----------------------------
ALTER TABLE [facturaDetalle] ADD PRIMARY KEY ([idFacturaDetalle])
GO

-- ----------------------------
-- Indexes structure for table facturas
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table facturas
-- ----------------------------
ALTER TABLE [facturas] ADD PRIMARY KEY ([idFactura])
GO

-- ----------------------------
-- Indexes structure for table productos
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table productos
-- ----------------------------
ALTER TABLE [productos] ADD PRIMARY KEY ([idProducto])
GO

-- ----------------------------
-- Foreign Key structure for table [facturaCabecera]
-- ----------------------------
ALTER TABLE [facturaCabecera] ADD FOREIGN KEY ([idCliente]) REFERENCES [clientes] ([idCliente]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [facturaDetalle]
-- ----------------------------
ALTER TABLE [facturaDetalle] ADD FOREIGN KEY ([idFacturaCabecera]) REFERENCES [facturaCabecera] ([idFacturaCabecera]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [facturaDetalle] ADD FOREIGN KEY ([idProducto]) REFERENCES [productos] ([idProducto]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [facturas]
-- ----------------------------
ALTER TABLE [facturas] ADD FOREIGN KEY ([idFacturaCabecera]) REFERENCES [facturaCabecera] ([idFacturaCabecera]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
