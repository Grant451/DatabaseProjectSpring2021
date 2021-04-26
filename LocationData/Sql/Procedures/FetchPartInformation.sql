--Q1

-- Fetch parts used based on customer

--DROP PROCEDURE IF EXISTS AutoShop.FetchPartInformation
--GO

CREATE PROCEDURE AutoShop.FetchPartInformation
   @PartName NVARCHAR(64)
AS

SELECT L.StreetAddress, S.Quantity, P.Price
FROM AutoShop.Locations L 
	INNER JOIN AutoShop.Stock S ON S.LocationId = L.LocationId
	INNER JOIN AutoShop.Parts P ON P.PartId = S.PartId
WHERE P.PartName = @PartName
GO

--EXEC AutoShop.FetchPartInformation 'ipsum porta';

