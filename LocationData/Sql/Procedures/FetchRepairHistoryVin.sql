--DROP PROCEDURE IF EXISTS AutoShop.FetchRepairHistoryVehicle
--GO

CREATE PROCEDURE AutoShop.FetchRepairHistoryVehicle
   @vinnumber NVARCHAR(11)
AS

SELECT C.CustomerName, R.RepairName
FROM AutoShop.Customers C
	INNER JOIN AutoShop.Appointments A ON A.CustomerID = C.CustomerId
	INNER JOIN AutoShop.Repairs R ON R.RepairID = A.RepairId
WHERE C.vinnumber = @vinnumber;
GO

--EXEC AutoShop.FetchRepairHistoryVehicle '28522458199';

