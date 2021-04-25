-- Q14 Fetch Repairs in Progress
--DROP PROCEDURE IF EXISTS AutoShop.FetchReparsinProgress
--GO

CREATE PROCEDURE AutoShop.FetchReparsinProgress
    @StreetAddress NVARCHAR(255)
AS

SELECT  R.RepairName, E.EmployeeName, C.CustomerName
FROM AutoShop.Employees E
    INNER JOIN AutoShop.EmployeesRepairs ER ON ER.EmployeeId = E.EmployeeId
    INNER JOIN AutoShop.Repairs R ON R.RepairId = ER.RepairId
    INNER JOIN AutoShop.Appointments A ON A.RepairId = R.RepairId
    INNER JOIN AutoShop.Customers C ON C.CustomerId = A.CustomerId
    INNER JOIN AutoShop.EmployeesLocation AE ON E.EmployeeId = AE.EmployeeId
    INNER JOIN AutoShop.Locations AL ON AL.LocationId = AE.LocationId
WHERE AL.StreetAddress = @StreetAddress
GO

--EXEC AutoShop.FetchReparsinProgress 'P.O. Box 776, 7543 Convallis Rd.';

