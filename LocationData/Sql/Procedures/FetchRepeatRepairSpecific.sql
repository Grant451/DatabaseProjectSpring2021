-- Q19 Fetch Repeat Repairs for a specific customer
--DROP PROCEDURE IF EXISTS AutoShop.FetchRepeatRepairsSpecific
--GO

CREATE PROCEDURE AutoShop.FetchRepeatRepairsSpecific
	@CustomerName NVARCHAR(64)
AS

SELECT C.CustomerName, R.RepairName, COUNT(R.RepairId) AS RepeatRepairs
FROM AutoShop.Employees E
	INNER JOIN AutoShop.EmployeesRepairs ER ON ER.EmployeeId = E.EmployeeId
	INNER JOIN AutoShop.Repairs R ON R.RepairId = ER.RepairId
	INNER JOIN AutoShop.Appointments A ON A.RepairId = R.RepairId
	INNER JOIN AutoShop.Customers C ON C.CustomerId = A.CustomerId
WHERE C.CustomerName = @CustomerName
GROUP BY C.CustomerName, R.RepairName
HAVING COUNT(R.RepairId) > 1
GO

--EXEC AutoShop.FetchRepeatRepairsSpecific 'Zeus Terry';