-- Q5
-- Fetch a specific part's quantites across all locations
--DROP PROCEDURE IF EXISTS AutoShop.FetchPart
--GO

CREATE PROCEDURE AutoShop.FetchPart
   @PartName NVARCHAR(64)
AS

SELECT L.LocationId, L.StreetAddress, S.Quantity

FROM AutoShop.Parts P
	INNER JOIN AutoShop.Stock S ON S.PartId = P.PartId
	INNER JOIN AutoShop.Locations L ON L.LocationId = S.LocationId

WHERE P.PartName = @PartName
GO

--EXEC AutoShop.FetchPart 'vitae,  orci.';