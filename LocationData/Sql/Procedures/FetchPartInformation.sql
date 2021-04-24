-- Fetch parts used based on customer

--DROP PROCEDURE IF EXISTS AutoShop.FetchPartInformation
--GO

CREATE PROCEDURE AutoShop.FetchPartInformation
   @StreetAddress NVARCHAR(255),
   @PartName NVARCHAR(64)
AS

SELECT S.Quantity, P.Price
FROM AutoShop.Locations L 
	INNER JOIN AutoShop.Stock S ON S.LocationId = L.LocationId
	INNER JOIN AutoShop.Parts P ON P.PartId = S.PartId
WHERE L.StreetAddress = @StreetAddress 
	AND P.PartName = @PartName
GO

--EXEC AutoShop.FetchPartInformation '3521 Quam. Avenue', 'ipsum porta';

