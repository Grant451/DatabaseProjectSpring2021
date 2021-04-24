CREATE OR ALTER PROCEDURE AutoShop.FetchLocation
	@LocationID INT
AS

SELECT L.StreetAddress, L.City, L.Region, L.Zip
FROM Location.Location L
WHERE L.LocationID = @LocationID
GO