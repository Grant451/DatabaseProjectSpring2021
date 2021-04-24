CREATE OR ALTER PROCEDURE AutoShop.RetrieveCustomers
AS

Select C.CustomerID, C.CustomerName, C.VinNumber
from Location.Customers C
GO

/*
CustomerID int identity,
CustomerName nvarchar(64),
vinnumber nvarchar(11),
PRIMARY KEY (CustomerID)
*/