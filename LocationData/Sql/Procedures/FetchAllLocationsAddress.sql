--use brynnritt

-- Fetch all locations

--DROP PROCEDURE IF EXISTS AutoShop.FetchAllLocationsAddress
--GO

CREATE PROCEDURE AutoShop.FetchAllLocationsAddress
AS

SELECT L.StreetAddress
FROM AutoShop.Locations L
GO

--EXEC AutoShop.FetchAllLocationsAddress;