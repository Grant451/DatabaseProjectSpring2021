CREATE OR ALTER PROCEDURE AutoShop.CreateLocation
	@StreetAddress nvarchar(255),
	@City nvarchar(255),
	@Region nvarchar(50),
	@zip nvarchar(10),
	@LocationID INT OUTPUT
AS

INSERT Location.Location(StreetAddress, City, Region, Zip)
VALUES(@StreetAddress, @City, @Region, @Zip);

SET @LocationID = SCOPE_IDENTITY();
GO