--Q26 AutoShop.FetchEmpoyeesByHours
--DROP PROCEDURE IF EXISTS AutoShop.FetchEmployeesByHours
--GO

CREATE PROCEDURE AutoShop.FetchEmployeesByHours
	@EmployeeName NVARCHAR(255)
AS

WITH
  ctereport (EmployeeID, EmployeeName, StreetAddress, Hours)
  AS
  (
	SELECT e.EmployeeID, EmployeeName, L.StreetAddress, e.Hours
    FROM AutoShop.Employees e
		INNER JOIN AutoShop.EmployeesLocation EL ON EL.EmployeeId = e.EmployeeId
		INNER JOIN AutoShop.Locations L ON L.LocationId = EL.LocationId
	WHERE @EmployeeName = e.EmployeeName
  )
SELECT EmployeeName, Hours, StreetAddress
FROM ctereport
ORDER BY EmployeeID
GO

--EXEC AutoShop.FetchEmployeesByHours 'Travis French';