USE [master]
GO
/****** Object:  Database [RMSdb]    Script Date: 16/07/2019 7:15:11 PM ******/
CREATE DATABASE [RMSdb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RMSdb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\RMSdb.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RMSdb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\RMSdb_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [RMSdb] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RMSdb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RMSdb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RMSdb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RMSdb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RMSdb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RMSdb] SET ARITHABORT OFF 
GO
ALTER DATABASE [RMSdb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RMSdb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RMSdb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RMSdb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RMSdb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RMSdb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RMSdb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RMSdb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RMSdb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RMSdb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RMSdb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RMSdb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RMSdb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RMSdb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RMSdb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RMSdb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RMSdb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RMSdb] SET RECOVERY FULL 
GO
ALTER DATABASE [RMSdb] SET  MULTI_USER 
GO
ALTER DATABASE [RMSdb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RMSdb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RMSdb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RMSdb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RMSdb] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'RMSdb', N'ON'
GO
ALTER DATABASE [RMSdb] SET QUERY_STORE = OFF
GO
USE [RMSdb]
GO
/****** Object:  FullTextCatalog [RMSdbCatalog]    Script Date: 16/07/2019 7:15:12 PM ******/
CREATE FULLTEXT CATALOG [RMSdbCatalog] WITH ACCENT_SENSITIVITY = ON
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [nvarchar](50) NOT NULL,
	[CustomerName] [nvarchar](100) NOT NULL,
	[CustomerAddressCountry] [nvarchar](100) NOT NULL,
	[CustomerAddressProvinceOrState] [nvarchar](100) NOT NULL,
	[CustomerAddressCityOrTown] [nvarchar](100) NOT NULL,
	[CustomerAddressExactLocation] [nvarchar](100) NOT NULL,
	[CustomerEmailAddress] [nvarchar](50) NOT NULL,
	[CustomerContactNumber] [nvarchar](50) NOT NULL,
	[CustomerContactPerson] [nvarchar](100) NOT NULL,
	[CustomerSalesOrder] [nvarchar](100) NULL,
	[CustomerInvoice] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventory]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[InvItemId] [nvarchar](50) NOT NULL,
	[InvItemName] [nvarchar](100) NOT NULL,
	[InvItemQuantity] [int] NULL,
	[InvItemLocation] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoice]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceNumber] [nvarchar](50) NOT NULL,
	[SOId] [nvarchar](50) NOT NULL,
	[InvoiceDate] [date] NOT NULL,
	[InvoiceAmount] [decimal](18, 2) NOT NULL,
	[InvoiceStatus] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InvoicedItems]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InvoicedItems](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceNumber] [nvarchar](50) NOT NULL,
	[SOId] [nvarchar](50) NOT NULL,
	[InvoiceItemPrice] [decimal](18, 2) NOT NULL,
	[InvoiceQuantity] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Items]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Items](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ItemId] [nvarchar](50) NOT NULL,
	[ItemName] [nvarchar](150) NOT NULL,
	[ItemDescription] [nvarchar](200) NOT NULL,
	[ItemPrice] [decimal](18, 2) NOT NULL,
	[ItemDiscount] [decimal](18, 2) NOT NULL,
	[ItemDisabled] [bit] NULL,
 CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED 
(
	[ItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PO]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PO](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[POId] [nvarchar](50) NOT NULL,
	[POVendorId] [nvarchar](50) NOT NULL,
	[POVendorName] [nvarchar](100) NOT NULL,
	[POInvoiceNumber] [nvarchar](50) NOT NULL,
	[POTotalAmount] [decimal](18, 2) NOT NULL,
	[PODate] [date] NOT NULL,
	[POStatus] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PO] PRIMARY KEY CLUSTERED 
(
	[POId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PurchaseOrderItems]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseOrderItems](
	[id] [int] NULL,
	[POId] [nvarchar](50) NULL,
	[ItemId] [nvarchar](50) NULL,
	[ItemPrice] [decimal](18, 2) NULL,
	[POQuantity] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalesOrderItems]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesOrderItems](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[SOid] [nvarchar](50) NOT NULL,
	[ItemId] [nvarchar](50) NOT NULL,
	[ItemPrice] [decimal](18, 2) NOT NULL,
	[SOQuantity] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SO]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SO](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[SOId] [nvarchar](50) NOT NULL,
	[SOCustomerId] [nvarchar](50) NOT NULL,
	[SOCustomerName] [nvarchar](100) NOT NULL,
	[SoTotalAmount] [decimal](18, 2) NOT NULL,
	[SODate] [date] NOT NULL,
	[SOStatus] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vendor]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vendor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[VendorId] [nvarchar](50) NOT NULL,
	[VendorName] [nvarchar](100) NOT NULL,
	[VendorAddressExactLocation] [nvarchar](100) NOT NULL,
	[VendorAddressCityOrTown] [nvarchar](100) NOT NULL,
	[VendorAddressProvinceOrState] [nvarchar](100) NOT NULL,
	[VendorAddressCountry] [nvarchar](50) NOT NULL,
	[VendorEmailAddress] [nvarchar](50) NOT NULL,
	[VendorContactNumber] [nvarchar](50) NOT NULL,
	[VendorContactPerson] [nvarchar](100) NOT NULL,
	[VendorPurchase] [nvarchar](100) NULL,
 CONSTRAINT [PK_Vendor] PRIMARY KEY CLUSTERED 
(
	[VendorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Inventory]  WITH CHECK ADD  CONSTRAINT [FK_Inventory_Items] FOREIGN KEY([InvItemId])
REFERENCES [dbo].[Items] ([ItemId])
GO
ALTER TABLE [dbo].[Inventory] CHECK CONSTRAINT [FK_Inventory_Items]
GO
ALTER TABLE [dbo].[PO]  WITH CHECK ADD  CONSTRAINT [FK_PO_Vendor] FOREIGN KEY([POVendorId])
REFERENCES [dbo].[Vendor] ([VendorId])
GO
ALTER TABLE [dbo].[PO] CHECK CONSTRAINT [FK_PO_Vendor]
GO
/****** Object:  StoredProcedure [dbo].[spCustomer_CreateNew]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spCustomer_CreateNew]
	@CustomerId nvarchar (50),
	@CustomerName nvarchar (100),
	@CustomerAddressCountry nvarchar (100),
	@CustomerAddressProvinceOrState nvarchar (100),
	@CustomerAddressCityOrTown nvarchar (100),
	@CustomerAddressExactLocation nvarchar (100),
	@CustomerEmailAddress nvarchar (50),
	@CustomerContactNumber nvarchar (50),
	@CustomerContactPerson nvarchar (100),
	@id int = 0 output


AS
BEGIN
	
	SET NOCOUNT ON;

    insert into dbo.Customers (CustomerId, CustomerName, CustomerAddressCountry, CustomerAddressProvinceOrState, CustomerAddressCityOrTown, 
								CustomerAddressExactLocation, CustomerEmailAddress, CustomerContactNumber, CustomerContactPerson)
	values (@CustomerId, @CustomerName, @CustomerAddressCountry, @CustomerAddressProvinceOrState, @CustomerAddressCityOrTown,
			@CustomerAddressExactLocation, @CustomerEmailAddress, @CustomerContactNumber, @CustomerContactPerson)

	select @id = SCOPE_IDENTITY()
END
GO
/****** Object:  StoredProcedure [dbo].[spCustomer_GetAll]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spCustomer_GetAll]
	
AS
BEGIN
	SET NOCOUNT ON;

    SELECT * FROM dbo.Customers
END
GO
/****** Object:  StoredProcedure [dbo].[spCustomer_GetLastRecordId]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spCustomer_GetLastRecordId]
	@id int = 0 output
AS
BEGIN
	
	SET NOCOUNT ON;

    select CustomerId from Customers where id = (Select MAX(id) from Customers);
END
GO
/****** Object:  StoredProcedure [dbo].[spCustomer_Update]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spCustomer_Update]
	@CustomerId nvarchar(50),
	@CustomerName nvarchar(100),
	@CustomerExactLocation nvarchar(100),
	@CustomerCityOrTown nvarchar(100),
	@CustomerProvinceOrState nvarchar(100),
	@CustomerCountry nvarchar(100),
	@CustomerEmail nvarchar(50),
	@CustomerContactNumber nvarchar(50),
	@CustomerContactPerson nvarchar(100)
AS
BEGIN

	SET NOCOUNT ON;

    UPDATE Customers
    SET CustomerName = @CustomerName, 
		CustomerAddressExactLocation = @CustomerExactLocation, 
		CustomerAddressCityOrTown = @CustomerCityOrTown, 
		CustomerAddressProvinceOrState = @CustomerProvinceOrState, 
		CustomerAddressCountry = @CustomerCountry,
		CustomerEmailAddress = @CustomerEmail,
		CustomerContactNumber = @CustomerContactNumber,
		CustomerContactPerson = @CustomerContactPerson
	WHERE CustomerId = @CustomerId
END
GO
/****** Object:  StoredProcedure [dbo].[spInv_GetAll]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInv_GetAll]
	
AS
BEGIN
	
	SET NOCOUNT ON;

    INSERT into dbo.Inventory (InvItemId, InvItemName)
	SELECT Items.ItemId AS InvItemId, Items.ItemName as InvItemName FROM dbo.Items
	Left Join dbo.Inventory ON Items.ItemId = Inventory.InvItemId
	WHERE Inventory.id = null AND ItemDisabled = 0

	Select * from dbo.Inventory ORDER BY InvItemId ASC
END
GO
/****** Object:  StoredProcedure [dbo].[spInv_GetAllWithQuantity]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInv_GetAllWithQuantity]
	
AS
BEGIN
	
	SET NOCOUNT ON;

	Select * from dbo.Inventory 
	Where InvItemQuantity > 0  
	ORDER BY InvItemId ASC
	
END
GO
/****** Object:  StoredProcedure [dbo].[spInv_GetFromItem]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInv_GetFromItem]
	
AS
BEGIN
	
	SET NOCOUNT ON;


	INSERT into dbo.Inventory (InvItemId, InvItemName, InvItemQuantity, InvItemLocation)
	SELECT Items.ItemId, Items.ItemName, Inventory.InvItemQuantity, Inventory.InvItemLocation from dbo.Items 
	LEFT OUTER JOIN dbo.Inventory ON Items.ItemId = Inventory.InvItemId
	WHERE ItemDisabled = 0 AND Inventory.InvItemId is null

	UPDATE dbo.Inventory
	set InvItemQuantity = 0
	WHERE InvItemQuantity IS NULL
END
GO
/****** Object:  StoredProcedure [dbo].[spInv_GetLastRecordId]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInv_GetLastRecordId]
		@id int = 0 output
AS
BEGIN
	
	SET NOCOUNT ON;

    SELECT InvoiceNumber from Invoice where id = (SELECT MAX(id) from Invoice);

END
GO
/****** Object:  StoredProcedure [dbo].[spInvoice_GetAll]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInvoice_GetAll]
	
AS
BEGIN
	
	SET NOCOUNT ON;

    SELECT Invoice.InvoiceNumber AS InvoiceNumber, 
		   Invoice.SOId as SOId, 
		   SO.SOCustomerName as SOCustomerName,   
		   Invoice.InvoiceAmount as InvoiceAmount,
		   Invoice.InvoiceDate as InvoiceDate,
		   Invoice.InvoiceStatus as InvoiceStatus
    FROM dbo.Invoice
	Left Join dbo.SO ON Invoice.SOId = SO.SOId
END
GO
/****** Object:  StoredProcedure [dbo].[spInvoice_TransferSOItemsToInvoice]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInvoice_TransferSOItemsToInvoice]
	@SOId nvarchar(50),
	@SOStatus nvarchar(50),
	@InvoiceNumber nvarchar(50),
	@id int = 0 output
AS
BEGIN
	
	SET NOCOUNT ON;

    INSERT INTO InvoicedItems (InvoiceNumber, SOId, InvoiceItemPrice, InvoiceQuantity)
	SELECT @InvoiceNumber, SalesOrderItems.SOid, SalesOrderItems.ItemPrice, SalesOrderItems.SOQuantity
	FROM SalesOrderItems
	WHERE SOid = @SOId

	DELETE from SalesOrderItems
	WHERE SOid = @SOId

	Update SO
	SET SOStatus = 'Posted'
	WHERE SOid = @SOId

END
GO
/****** Object:  StoredProcedure [dbo].[spInvoice_UpdateInvoiceTable]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInvoice_UpdateInvoiceTable]
	@SOId nvarchar(50),
	@InvoiceAmount decimal(18,2),
	@InvoiceStatus nvarchar(50),
	@InvoiceDate datetime,
	@InvoiceNumber nvarchar(50),
	@id int = 0 output
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT @InvoiceNumber = InvoicedItems.InvoiceNumber 
	FROM InvoicedItems 
	WHERE InvoicedItems.SOId = @SOId

	INSERT INTO Invoice (InvoiceNumber, SOId, InvoiceDate, InvoiceAmount, InvoiceStatus)
	VALUES (@InvoiceNumber, @SOId, @InvoiceDate, @InvoiceAmount, @InvoiceStatus)  
END
GO
/****** Object:  StoredProcedure [dbo].[spItem_CreateNew]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spItem_CreateNew]
	@ItemDisabled bit = 0,
	@ItemId nvarchar (50),
	@ItemName nvarchar (150),
	@ItemDescription nvarchar (200),
	@ItemPrice decimal (18,2),
	@ItemDiscount decimal (18,2),
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	insert into dbo.Items (ItemDisabled, ItemId, ItemName, ItemDescription, ItemPrice, ItemDiscount)
	values (@ItemDIsabled, @ItemId, @ItemName, @ItemDescription, @ItemPrice, @ItemDiscount)

	select @id = SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[spItem_GetAll]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spItem_GetAll]
	
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * from dbo.Items
END
GO
/****** Object:  StoredProcedure [dbo].[spItem_Search]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spItem_Search] @ItemSearchValue nvarchar (500)

AS
BEGIN
	
	SET NOCOUNT ON;

    SELECT * from dbo.Items where contains (ItemId, @ItemSearchValue)
	OR contains (ItemName, @ItemSearchValue) 
	OR contains (ItemDescription, @ItemSearchValue)
END
GO
/****** Object:  StoredProcedure [dbo].[spItem_Update]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spItem_Update] 
	@ItemId nvarchar (50),
	@ItemName nvarchar (150),
	@ItemDescription nvarchar (200),
	@ItemPrice decimal (18,2),
	@ItemDiscount decimal (18,2),
	@ItemDisabled bit
AS
BEGIN
	
	SET NOCOUNT ON;

	UPDATE Items
    SET ItemId = @ItemId, 
		ItemName = @ItemName, 
		ItemDescription = @ItemDescription, 
		ItemPrice = @ItemPrice, 
		ItemDiscount = @ItemDiscount,
		ItemDisabled = @ItemDisabled
	WHERE ItemId = @ItemId

END
GO
/****** Object:  StoredProcedure [dbo].[spPO_AddItemsToOrderItems]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spPO_AddItemsToOrderItems]
	@POId nvarchar(50),
	@ItemId nvarchar(50),
	@ItemPrice decimal(18,2),
	@POQuantity nvarchar(50),
	@id int = 0 output

AS
BEGIN
	
	SET NOCOUNT ON;

    INSERT into dbo.PurchaseOrderItems (POId, ItemId, ItemPrice, POQuantity)
	values (@POId, @ItemId, @ItemPrice, @POQuantity)

	select @id = SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[spPO_CreateNewPO]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spPO_CreateNewPO]
	@POId nvarchar(50),
	@POVendorId nvarchar(50),
	@POVendorName nvarchar(50),
	@POInvoiceNumber nvarchar(50),
	@POTotalAmount decimal(18,2),
	@PODate date,
	@POStatus nvarchar(50),
	@id int = 0 output
AS
BEGIN
	
	SET NOCOUNT ON;

	INSERT into dbo.PO (POId, POVendorId, POVendorName, POInvoiceNumber, POTotalAmount, PODate, POStatus)
	values (@POId, @POVendorId, @POVendorName, @POInvoiceNumber, @POTotalAmount, @PODate, @POStatus)

	select @id = SCOPE_IDENTITY();
   
END
GO
/****** Object:  StoredProcedure [dbo].[spPO_GetAll]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spPO_GetAll]
	
AS
BEGIN
	
	SET NOCOUNT ON;

    SELECT * FROM dbo.PO
END
GO
/****** Object:  StoredProcedure [dbo].[spPO_GetItemIdAndNameList]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spPO_GetItemIdAndNameList]
	
AS
BEGIN
	
	SET NOCOUNT ON;

    SELECT ItemId, ItemName, ItemPrice from Items WHERE ItemDisabled = 0
END
GO
/****** Object:  StoredProcedure [dbo].[spPO_GetLastRecordId]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spPO_GetLastRecordId]
	@id int = 0 output
AS
BEGIN
	
	SET NOCOUNT ON;

    SELECT POId from PO where id = (SELECT MAX(id) from PO);
END
GO
/****** Object:  StoredProcedure [dbo].[spPO_GetPOItems]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spPO_GetPOItems] @POId nvarchar(50)
	
AS
BEGIN
	
	SET NOCOUNT ON;

    select PurchaseOrderItems.ItemId, PurchaseOrderItems.ItemPrice, PurchaseOrderItems.POQuantity, Items.ItemName
	from PurchaseOrderItems
	LEFT JOIN Items ON PurchaseOrderItems.ItemId = Items.ItemId
	where PurchaseOrderItems.POId = @POId
	ORDER BY PurchaseOrderItems.ItemId;

END
GO
/****** Object:  StoredProcedure [dbo].[spPO_GetVendorList]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spPO_GetVendorList]
	
AS
BEGIN
	
	SET NOCOUNT ON;

    SELECT VendorId, VendorName from Vendor
END
GO
/****** Object:  StoredProcedure [dbo].[spPO_PostInInventory]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spPO_PostInInventory]
	@InvItemId nvarchar(50),
	@InvItemName nvarchar (100),
	@InvItemQuantity int,
	@InvItemLocation nvarchar (100),
	@id int = 0 output
AS
BEGIN
	
	SET NOCOUNT ON;

	if exists (Select * from dbo.Inventory where InvItemId = @InvItemId)
		update dbo.Inventory set InvItemQuantity = InvItemQuantity + @InvItemQuantity, InvItemLocation = @InvItemLocation
		where InvItemId = @InvItemId
	else 
    	insert into dbo.Inventory (InvItemId, InvItemName, InvItemQuantity, InvItemLocation)
		values (@InvItemId, @InvItemName, @InvItemQuantity, @InvItemLocation)
END
GO
/****** Object:  StoredProcedure [dbo].[spPO_UpdateItemsToOrderItems]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spPO_UpdateItemsToOrderItems]
	@POId nvarchar(50),
	@ItemId nvarchar(50),
	@ItemPrice decimal(18,2),
	@POQuantity nvarchar(50),
	@CheckInitialRun bit,
	@id int = 0 output
AS
BEGIN

	SET NOCOUNT ON;

	if @CheckInitialRun = 0
		DELETE from dbo.PurchaseOrderItems WHERE POId = @POId

    Insert into dbo.PurchaseOrderItems (POId, ItemId, ItemPrice, POQuantity)
	values (@POId, @ItemId, @ItemPrice, @POQuantity)

	select @id = SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[spPO_UpdatePO]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spPO_UpdatePO]
	@POId nvarchar(50),
	@POInvoiceNumber nvarchar(50),
	@POTotalAmount decimal(18,2),
	@PODate date,
	@POStatus nvarchar(50),
	@id int = 0 output
AS
BEGIN

	SET NOCOUNT ON;

	Update dbo.PO 
	Set POInvoiceNumber = @POInvoiceNumber, POTotalAmount = @POTotalAmount, 
				PODate = @PODate, POStatus = @POStatus
	WHERE POId = @POId

	select @id = SCOPE_IDENTITY();
    
END
GO
/****** Object:  StoredProcedure [dbo].[spPO_UpdateStatus]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spPO_UpdateStatus] 
	@POId nvarchar(50),
	@POStatus nvarchar(50),
	@POInvoiceNumber nvarchar(50),
	@id int = 0  output
AS
BEGIN
	
	SET NOCOUNT ON;

	Update dbo.PO
	SET POStatus = @POStatus, POInvoiceNumber = @POInvoiceNumber
	WHERE POId = @POId
	
	SELECT @id = SCOPE_IDENTITY();
   
END
GO
/****** Object:  StoredProcedure [dbo].[spSO_AddItemsToSOItems]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSO_AddItemsToSOItems]
	@SOId nvarchar(50),
	@ItemId nvarchar(50),
	@ItemPrice decimal(18,2),
	@SOQuantity int,
	@id int = 0 output
AS
BEGIN
	
	SET NOCOUNT ON;

	UPDATE dbo.Inventory
	SET InvItemQuantity = InvItemQuantity - @SOQuantity
	WHERE InvItemId = @ItemId

	INSERT into dbo.SalesOrderItems (SOId, ItemId, ItemPrice, SOQuantity)
	values (@SOId, @ItemId, @ItemPrice, @SOQuantity)

	select @id = SCOPE_IDENTITY();
    
END
GO
/****** Object:  StoredProcedure [dbo].[spSO_CreateNewSO]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSO_CreateNewSO]
	@SOId nvarchar(50),
	@SOCustomerId nvarchar(50),
	@SOCustomerName nvarchar(50),
	@SOTotalAmount decimal(18,2),
	@SODate date,
	@SOStatus nvarchar(50),
	@id int = 0 output
AS
BEGIN
	
	SET NOCOUNT ON;

	INSERT into dbo.SO (SOId, SOCustomerId, SOCustomerName, SOTotalAmount, SODate, SOStatus)
	values (@SOId, @SOCustomerId, @SOCustomerName, @SOTotalAmount, @SODate, @SOStatus)

	select @id = SCOPE_IDENTITY();
    
END
GO
/****** Object:  StoredProcedure [dbo].[spSO_GetAll]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSO_GetAll]
	
AS
BEGIN
	
	SET NOCOUNT ON;

    SELECT * FROM dbo.SO
END
GO
/****** Object:  StoredProcedure [dbo].[spSO_GetCustomerList]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSO_GetCustomerList]
	
AS
BEGIN
	
	SET NOCOUNT ON;

    SELECT CustomerId, CustomerName from Customers
END
GO
/****** Object:  StoredProcedure [dbo].[spSO_GetItemIdAndNameList]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSO_GetItemIdAndNameList]
	
AS
BEGIN
	
	SET NOCOUNT ON;

    SELECT Inventory.InvItemId, Inventory.InvItemName, Items.ItemPrice, Inventory.InvItemQuantity from Inventory
	LEFT JOIN dbo.Items ON Inventory.InvItemId = Items.ItemId
	WHERE ItemDisabled = 0 AND InvItemQuantity > 0
END
GO
/****** Object:  StoredProcedure [dbo].[spSO_GetLastRecordId]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSO_GetLastRecordId]
	@id int = 0 output
AS
BEGIN
	
	SET NOCOUNT ON;

    SELECT SOId from dbo.SO where id = (SELECT MAX(id) from SO);
END
GO
/****** Object:  StoredProcedure [dbo].[spSO_GetSOItems]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSO_GetSOItems]
	@SOId nvarchar(50)
AS
BEGIN
	
	SET NOCOUNT ON;

    select SalesOrderItems.ItemId, SalesOrderItems.ItemPrice, SalesOrderItems.SOQuantity, Items.ItemName
	from SalesOrderItems
	LEFT JOIN Items ON SalesOrderItems.ItemId = Items.ItemId
	where SalesOrderItems.SOId = @SOId
	ORDER BY SalesOrderItems.ItemId;
END
GO
/****** Object:  StoredProcedure [dbo].[spSO_UpdateInventoryQuantity]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSO_UpdateInventoryQuantity]
	@ItemId nvarchar(50),
	@SOQuantity nvarchar(50),
	@id int = 0 output
AS
BEGIN

	SET NOCOUNT ON;

	UPDATE Inventory
	SET InvItemQuantity = @SOQuantity
	WHERE InvItemId = @ItemId

	select @id = SCOPE_IDENTITY();    
END
GO
/****** Object:  StoredProcedure [dbo].[spSO_UpdateItemsToOrderItems]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSO_UpdateItemsToOrderItems]
	@SOId nvarchar(50),
	@ItemId nvarchar(50),
	@ItemPrice decimal(18,2),
	@SOQuantity nvarchar(50),
	@CheckInitialRun bit,
	@id int = 0 output
AS
BEGIN
	
	SET NOCOUNT ON;

    if @CheckInitialRun = 0
		DELETE from dbo.SalesOrderItems WHERE SOId = @SOId

    Insert into dbo.SalesOrderItems (SOId, ItemId, ItemPrice, SOQuantity)
	values (@SOId, @ItemId, @ItemPrice, @SOQuantity)

	select @id = SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[spSO_UpdateSO]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSO_UpdateSO]
	@SOId nvarchar(50),
	@SOTotalAmount decimal(18,2),
	@SODate date,
	@SOStatus nvarchar(50),
	@id int = 0 output
AS
BEGIN
	
	SET NOCOUNT ON;

    Update dbo.SO 
	Set SOTotalAmount = @SOTotalAmount, SODate = @SODate, SOStatus = @SOStatus
	WHERE SOId = @SOId

	select @id = SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[spVendor_CreateNew]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spVendor_CreateNew]
	@VendorId nvarchar (50),
	@VendorName nvarchar (100),
	@VendorAddressCountry nvarchar (100),
	@VendorAddressProvinceOrState nvarchar (100),
	@VendorAddressCityOrTown nvarchar (100),
	@VendorAddressExactLocation nvarchar (100),
	@VendorEmailAddress nvarchar (50),
	@VendorContactNumber nvarchar (50),
	@VendorContactPerson nvarchar (100),
	@id int = 0 output
AS
BEGIN
	
	SET NOCOUNT ON;

	insert into dbo.Vendor (VendorId, VendorName, VendorAddressCountry, VendorAddressProvinceOrState, VendorAddressCityOrTown, VendorAddressExactLocation,
							VendorEmailAddress, VendorContactNumber, VendorContactPerson)
	values (@VendorId, @VendorName, @VendorAddressCountry, @VendorAddressProvinceOrState, @VendorAddressCityOrTown, @VendorAddressExactLocation,
			@VendorEmailAddress, @VendorContactNumber, @VendorContactPerson)

	select @id = SCOPE_IDENTITY()
    
END
GO
/****** Object:  StoredProcedure [dbo].[spVendor_GetAll]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spVendor_GetAll]
	
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT * FROM dbo.Vendor
END
GO
/****** Object:  StoredProcedure [dbo].[spVendor_GetLastRecordId]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spVendor_GetLastRecordId]
	@id int = 0 output
AS
BEGIN
	
	SET NOCOUNT ON;

    SELECT VendorId from Vendor where id = (Select MAX(id) from Vendor);
END
GO
/****** Object:  StoredProcedure [dbo].[spVendor_Update]    Script Date: 16/07/2019 7:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spVendor_Update]
	@VendorId nvarchar(50),
	@VendorName nvarchar(100),
	@VendorExactLocation nvarchar(100),
	@VendorCityOrTown nvarchar(100),
	@VendorProvinceOrState nvarchar(100),
	@VendorCountry nvarchar(100),
	@VendorEmail nvarchar(50),
	@VendorContactNumber nvarchar(50),
	@VendorContactPerson nvarchar(100)
AS
BEGIN
	
	SET NOCOUNT ON;

    UPDATE Vendor
    SET VendorName = @VendorName, 
		VendorAddressExactLocation = @VendorExactLocation, 
		VendorAddressCityOrTown = @VendorCityOrTown, 
		VendorAddressProvinceOrState = @VendorProvinceOrState, 
		VendorAddressCountry = @VendorCountry,
		VendorEmailAddress = @VendorEmail,
		VendorContactNumber = @VendorContactNumber,
		VendorContactPerson = @VendorContactPerson
	WHERE VendorId = @VendorId
END
GO
USE [master]
GO
ALTER DATABASE [RMSdb] SET  READ_WRITE 
GO
