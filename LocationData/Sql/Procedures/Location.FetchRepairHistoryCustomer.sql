-- get repair history for specific customer


CREATE OR ALTER PROCEDURE AutoShop.FetchRepairHistoryCustomer
   @CustomerName NVARCHAR(64)
AS

SELECT C.CustomerName, R.RepairName
FROM AutoShop.Customers C
	INNER JOIN AutoShop.Appointments A ON A.CustomerID = C.CustomerID
	INNER JOIN AutoShop.Repairs R ON R.RepairID = A.RepairID
WHERE C.CustomerName = @CustomerName; 
GO

--EXEC AutoShop.FetchRepairHistoryCustomer 'Vincent Flores';