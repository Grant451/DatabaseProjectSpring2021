-- get repair history for specific customer
--DROP PROCEDURE IF EXISTS AutoShop.FetchRepairHistoryCustomer
--GO

CREATE  OR ALTER PROCEDURE Location.FetchRepairHistoryCustomer
   @CustomerName NVARCHAR(64)
AS

SELECT C.CustomerName, R.RepairName
FROM Location.Customers C
	INNER JOIN Location.Appointments A ON A.CustomerID = C.CustomerID
	INNER JOIN Location.Repairs R ON R.RepairID = A.RepairID
WHERE C.CustomerName = @CustomerName; 
GO

--EXEC AutoShop.FetchRepairHistoryCustomer 'Vincent Flores';