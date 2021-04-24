-- Fetch All Employee Repair Counts
--DROP PROCEDURE IF EXISTS AutoShop.FetchAllEmployeeRepairCounts
--GO

CREATE PROCEDURE AutoShop.FetchAllEmployeeRepairCounts

AS

SELECT E.EmployeeName,
	COUNT(DISTINCT IIF(R.[Status] = 'Complete', R.[Status], NULL)) AS RepairsCompleted,
	COUNT(DISTINCT IIF(R.[Status] = 'In Progress', R.[Status], NULL)) AS RepairsInProgress

FROM AutoShop.Employees E
	INNER JOIN AutoShop.EmployeesRepairs ER ON ER.EmployeeId = E.EmployeeId
	INNER JOIN AutoShop.Repairs R ON R.RepairID = ER.RepairId
GROUP BY E.EmployeeName
GO

--EXEC AutoShop.FetchAllEmployeeRepairCounts;