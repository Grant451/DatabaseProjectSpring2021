--Q11
-- Get sales for all locations
--DROP PROCEDURE IF EXISTS AutoShop.FetchSales
--GO

CREATE PROCEDURE AutoShop.FetchSales
AS

SELECT L.StreetAddress, (SUM(CONVERT (float, RIGHT(P.Price, LEN(P.Price) - 1))) + SUM(CONVERT (float, RIGHT(P.Price, LEN(R.LaborCost) - 1)))) AS Sales


FROM AutoShop.Locations L
	INNER JOIN AutoShop.Appointments A ON A.LocationId = L.LocationId
	INNER JOIN AutoShop.Repairs R ON R.RepairId = A.RepairId
	INNER JOIN AutoShop.RepairParts RP ON RP.RepairId = R.RepairId
	INNER JOIN AutoShop.Parts P ON P.PartId = RP.PartId

GROUP BY L.StreetAddress
GO

--EXEC AutoShop.FetchSales;