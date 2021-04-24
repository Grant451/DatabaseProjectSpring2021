CREATE OR ALTER PROCEDURE AutoShop.CreateCustomer
	@CustomerID Int output,
	@CustomerName nvarchar(64),
	@VinNumber nvarchar(11)
AS

INSERT Location.Customers(CustomerName, VinNumber)
VALUES(@CustomerName, @VinNumber);

SET @CustomerID = SCOPE_IDENTITY();
GO

/*
CustomerID int identity,
CustomerName nvarchar(64),
vinnumber nvarchar(11),
PRIMARY KEY (CustomerID)
*/