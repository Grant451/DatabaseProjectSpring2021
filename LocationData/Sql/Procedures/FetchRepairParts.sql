-- Fetch Info about parts required for specific repair
--DROP PROCEDURE IF EXISTS AutoShop.FetchRepairParts
--GO

CREATE PROCEDURE AutoShop.FetchRepairParts
   @RepairName NVARCHAR(64)
AS

SELECT P.PartName, P.Price

FROM AutoShop.Repairs R
	INNER JOIN AutoShop.RepairParts RP ON RP.RepairId = R.RepairId
	INNER JOIN AutoShop.Parts P ON P.PartId = RP.PartId

WHERE R.RepairName = @RepairName
GO

--EXEC AutoShop.FetchRepairParts 'fringilla euismod';