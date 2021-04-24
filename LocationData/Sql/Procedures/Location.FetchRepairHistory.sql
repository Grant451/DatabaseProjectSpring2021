-- get repair history for specific customer
--DROP PROCEDURE IF EXISTS AutoShop.FetchRepairHistoryCustomer
--GO

CREATE PROCEDURE Location.FetchRepairHistoryCustomer
   @CustomerName NVARCHAR(64)
AS

SELECT C.CustomerName, R.RepairName
FROM Location.Customers C
	INNER JOIN Location.Appointments A ON A.CustomerID = C.CustomerId
	INNER JOIN Location.Repairs R ON R.RepairID = A.RepairId
WHERE C.CustomerName = @CustomerName;
GO

--EXEC AutoShop.FetchRepairHistoryCustomer 'Vincent Flores';