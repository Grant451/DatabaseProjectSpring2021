 --Fetch Employee Location
-- DROP PROCEDURE IF EXISTS AutoShop.FetchEmployeeLocation
--GO

CREATE PROCEDURE AutoShop.FetchEmployeeLocation
   @EmployeeName NVARCHAR(64)
AS

SELECT L.StreetAddress, L.City, L.Region, L.Zip

FROM AutoShop.Employees E
	INNER JOIN AutoShop.EmployeesLocation EL ON EL.EmployeeId = E.EmployeeId
	INNER JOIN AutoShop.Locations L ON L.LocationId = EL.LocationId

WHERE E.EmployeeName = @EmployeeName
GO

--EXEC AutoShop.FetchEmployeeLocation 'Norman Abbott';
