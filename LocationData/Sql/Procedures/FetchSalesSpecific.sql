--Q10
-- DROP PROCEDURE IF EXISTS AutoShop.FetchSalesSpecific
--GO

CREATE PROCEDURE AutoShop.FetchSalesSpecific
   @StreetAddress NVARCHAR(64)
AS

SELECT (SUM(CONVERT (float, RIGHT(P.Price, LEN(P.Price) - 1))) + 
SUM(CONVERT (float, RIGHT(P.Price, LEN(R.LaborCost) - 1)))) AS Sales

FROM AutoShop.Locations L
	INNER JOIN AutoShop.Appointments A ON A.LocationId = L.LocationId
	INNER JOIN AutoShop.Repairs R ON R.RepairId = A.RepairId
	INNER JOIN AutoShop.RepairParts RP ON RP.RepairId = R.RepairId
	INNER JOIN AutoShop.Parts P ON P.PartId = RP.PartId

WHERE L.StreetAddress = @StreetAddress
GO

--EXEC AutoShop.FetchSalesSpecific 'P.O. Box 776, 7543 Convallis Rd.';