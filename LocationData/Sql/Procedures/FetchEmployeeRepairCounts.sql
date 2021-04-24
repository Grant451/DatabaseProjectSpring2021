--DROP PROCEDURE IF EXISTS AutoShop.FetchEmployeeRepairCounts
--GO

CREATE PROCEDURE AutoShop.FetchEmployeeRepairCounts
   @EmployeeName NVARCHAR(255)
AS

SELECT COUNT(DISTINCT IIF(R.[Status] = 'Complete', R.[Status], NULL)) AS RepairsCompleted,
	COUNT(DISTINCT IIF(R.[Status] = 'In Progress', R.[Status], NULL)) AS RepairsInProgress

FROM AutoShop.Employees E
	INNER JOIN AutoShop.EmployeesRepairs ER ON ER.EmployeeId = E.EmployeeId
	INNER JOIN AutoShop.Repairs R ON R.RepairID = ER.RepairId

WHERE E.EmployeeName = @EmployeeName
GO

--EXEC AutoShop.FetchEmployeeRepairCounts 'Colleen Mcleod';