CREATE OR ALTER PROCEDURE Location.FetchLocation
	@LocationID INT
AS

SELECT L.StreetAddress, L.City, L.Region, L.Zip
FROM Location.Location L
WHERE L.LocationID = @LocationID
GO