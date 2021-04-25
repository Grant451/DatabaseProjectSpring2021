-- Q17
-- Fetch All Employees
--USE brynnritt

--DROP PROCEDURE IF EXISTS AutoShop.FetchAllEmployees
--GO

CREATE PROCEDURE AutoShop.FetchAllEmployees
AS

SELECT E.EmployeeName
FROM AutoShop.Employees E
GO

--EXEC AutoShop.FetchAllEmployees;