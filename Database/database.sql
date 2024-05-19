USE GroceryStore;

GO

--IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'dbo.Promotion') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
--DROP TABLE dbo.Promotion 

--CREATE TABLE Promotion
--(
--	PromotionID INT IDENTITY(1,1),
--	DiscountRate FLOAT,
--	StartDay DATETIME,
--	EndDay DATETIME,
--	PromotionCode INT,

--	CONSTRAINT PK_Promotion PRIMARY KEY (PromotionID)
--);

--GO
--IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'dbo.CategoryPromotion') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
--DROP TABLE dbo.CategoryPromotion 

--CREATE TABLE CategoryPromotion
--(
--     CategoryID INT,
--     PromotionID INT,

--     CONSTRAINT FK_Category_Promotion FOREIGN KEY(CategoryID) REFERENCES Category(CategoryID),
--     CONSTRAINT FK_Promotion_Category FOREIGN KEY(PromotionID) REFERENCES Promotion(PromotionID),
--);

GO
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'dbo.Category') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE dbo.Category 

CREATE TABLE Category
(
	CategoryID INT IDENTITY(1,1),
	Name NVARCHAR(50),

	CONSTRAINT PK_Category PRIMARY KEY (CategoryID)
);

GO
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'dbo.Supplier') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE dbo.Supplier 

CREATE TABLE Supplier
(
    SupplierID INT IDENTITY(1, 1),
    Name NVARCHAR(50),
    Email NVARCHAR(50),
    Phone CHAR(10)

    CONSTRAINT PK_Supplier PRIMARY KEY (SupplierID)
);

GO
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'dbo.Product') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE dbo.Product 

CREATE TABLE Product
(
    ProductID INT IDENTITY(1,1),
    Name NVARCHAR(50),
    CostPrice MONEY,
    SKU char(12) NOT NULL UNIQUE,
    MarketPrice MONEY,
    SupplierID INT,
	CategoryID INT,
    CONSTRAINT PK_Product PRIMARY KEY (ProductID),
    CONSTRAINT FK_Product_Supplier FOREIGN KEY(SupplierID) REFERENCES Supplier(SupplierID),
	CONSTRAINT FK_Product_Category FOREIGN KEY(CategoryID) REFERENCES Category(CategoryID)
);

CREATE TABLE ProductDetail
(
	SKU char(12),
	QuantityInStock INT,
	Expiry DATE,
	BarCode nchar(20),

	CONSTRAINT PK_ProductDetail PRIMARY KEY (SKU, Expiry),
	CONSTRAINT FK_ProductDetail_Product FOREIGN KEY(SKU) REFERENCES Product(SKU)
);


GO
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'dbo.Timekeeping') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE dbo.Timekeeping 

CREATE TABLE Timekeeping
(
	TimekeepingID INT IDENTITY(1,1),
	Checkin DATETIME,
	Checkout DATETIME,

	CONSTRAINT PK_Timekeeping PRIMARY KEY(TimekeepingID)
);

GO
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'dbo.Job') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE dbo.Job 

CREATE TABLE Job
(
	JobID INT IDENTITY(1,1),
	JoinDate DATE,
	EndDate DATE NULL,
	Salary MONEY,
	Name NVARCHAR(50),

	CONSTRAINT PK_Job PRIMARY KEY (JobID)
);

GO
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'dbo.Employee') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE dbo.Employee 

CREATE TABLE Employee
(
	EmployeeID INT IDENTITY(1,1),
	FirstName NVARCHAR(50),
	LastName NVARCHAR(50),
	Role NVARCHAR(50),
	JobID INT,
	Login NVARCHAR(50),
	Password NVARCHAR(50),
	Img VARBINARY(MAX),

	CONSTRAINT PK_Employee PRIMARY KEY (EmployeeID),
	CONSTRAINT FK_Employee_Job FOREIGN KEY (JobID) REFERENCES Job(JobID)
);

GO
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'dbo.EmployeeTimekeeping') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE dbo.EmployeeTimekeeping 

CREATE TABLE EmployeeTimekeeping
(
	EmployeeID INT,
	TimekeepingID INT,

	CONSTRAINT FK_Employee_Timekeeping FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID),
	CONSTRAINT FK_Timekeeping_Employee FOREIGN KEY (TimekeepingID) REFERENCES Timekeeping(TimekeepingID)
);

GO
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'dbo.Payment') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE dbo.Payment 

CREATE TABLE Payment
(
	PaymentID INT IDENTITY(1,1),
	Name NVARCHAR(50),
	QR VARBINARY(MAX) NULL,

	CONSTRAINT PK_Payment PRIMARY KEY (PaymentID)
);

GO
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'dbo.ShopOrder') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE dbo.ShopOrder 

CREATE TABLE ShopOrder
(
	ShopOrderID INT IDENTITY(1,1),
	SubTotal MONEY,
	OrderDate DATETIME,
	PaymentID INT,
	EmployeeID INT,

	CONSTRAINT PK_ShopOrder PRIMARY KEY (ShopOrderID),
	CONSTRAINT FK_ShopOrder_Employee FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID),
	CONSTRAINT FK_ShopOrder_Payment FOREIGN KEY (PaymentID) REFERENCES Payment(PaymentID)
);

GO
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'dbo.OrderLine') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE dbo.OrderLine 

CREATE TABLE OrderLine
(
	OrderLineID INT IDENTITY(1,1),
	Quantity INT,
	Price MONEY,
	ShopOrderID INT,
	ProductID INT,

	CONSTRAINT PK_OrderLine PRIMARY KEY (OrderLineID),
	CONSTRAINT FK_OrderLine_Product FOREIGN KEY (ProductID) REFERENCES Product(ProductID),
	CONSTRAINT FK_OrderLine_ShopOrder FOREIGN KEY (ShopOrderID) REFERENCES ShopOrder(ShopOrderID)
);

GO

CREATE VIEW [VIEW_Invoice]
AS
	SELECT ShopOrder.ShopOrderID, Product.Name AS ProductName, ShopOrder.OrderDate, 
		OrderLine.Quantity, Product.MarketPrice, OrderLine.Price AS PriceLine, 
		(Employee.FirstName + ' ' + Employee.LastName) AS NameEmp, 
		ShopOrder.SubTotal, Payment.Name AS PaymentMethod
	FROM OrderLine, ShopOrder, Product, Employee, Payment
	WHERE ShopOrder.ShopOrderID = OrderLine.ShopOrderID 
		AND ShopOrder.EmployeeID = Employee.EmployeeID
		AND ShopOrder.PaymentID = Payment.PaymentID
		AND OrderLine.ProductID = Product.ProductID

GO

CREATE VIEW [VIEW_Statistical]
AS
SELECT c.Name AS  CategoryName, s.Name AS SupplierName, SUM(SubTotal) AS SubTotal
FROM ShopOrder AS so
JOIN OrderLine AS ol ON so.ShopOrderID = ol.ShopOrderID
JOIN Product AS p ON ol.ProductID = p.ProductID
JOIN Category as c ON p.CategoryID = c.CategoryID
JOIN Supplier as s ON s.SupplierID = p.SupplierID
GROUP BY c.Name, s.Name

GO

CREATE FUNCTION FUNC_RevenueTime
(
	@TGBatDau DATETIME,
	@TGKetThuc DATETIME
)
RETURNS @result TABLE 
(
	OrderDate DATE,
	ProductName NVARCHAR(50),
	Revenue MONEY,
	SubTotal MONEY
)
AS
BEGIN
	INSERT INTO @result
		SELECT so.OrderDate, p.Name, SUM(p.MarketPrice - p.CostPrice) AS Revenue, SUM(so.SubTotal) AS SubTotal
		FROM ShopOrder AS so
		JOIN OrderLine AS ol ON so.ShopOrderID = ol.ShopOrderID
		JOIN Product AS p ON p.ProductID = ol.ProductID
		WHERE so.OrderDate BETWEEN @TGBatDau AND @TGKetThuc
		GROUP BY so.OrderDate, p.Name
	RETURN
END;
