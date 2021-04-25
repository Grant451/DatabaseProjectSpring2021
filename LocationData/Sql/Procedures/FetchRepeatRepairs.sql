-- Q20 Fetch Repeat Repairs

--DROP PROCEDURE IF EXISTS AutoShop.FetchRepeatRepairs
--GO

CREATE PROCEDURE AutoShop.FetchRepeatRepairs
AS

SELECT C.CustomerName, R.RepairName, COUNT(R.RepairId) AS TimesRepaired
FROM AutoShop.Employees E
	INNER JOIN AutoShop.EmployeesRepairs ER ON ER.EmployeeId = E.EmployeeId
	INNER JOIN AutoShop.Repairs R ON R.RepairId = ER.RepairId
	INNER JOIN AutoShop.Appointments A ON A.RepairId = R.RepairId
	INNER JOIN AutoShop.Customers C ON C.CustomerId = A.CustomerId

GROUP BY C.CustomerName, R.RepairName
HAVING COUNT(R.RepairId) > 1
GO

--EXEC AutoShop.FetchRepeatRepairs;