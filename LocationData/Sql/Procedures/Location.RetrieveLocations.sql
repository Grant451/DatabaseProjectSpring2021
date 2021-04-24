CREATE OR ALTER PROCEDURE AutoShop.RetrieveLocations
AS

SELECT L.StreetAddress, L.City, L.Region, L.Zip, L.LocationID
FROM Location.Location L
GO