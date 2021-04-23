CREATE OR ALTER PROCEDURE Location.RetrieveLocations
AS

SELECT L.StreetAddress, L.City, L.Region, L.Zip, L.LocationID
FROM Location.Location L
GO