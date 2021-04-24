--DROP PROCEDURE IF EXISTS AutoShop.FetchRepairHistoryEmployee
--GO

CREATE PROCEDURE AutoShop.FetchRepairHistoryEmployee
   @EmployeeName NVARCHAR(255)
AS

SELECT E.EmployeeName, R.RepairName
FROM AutoShop.Employees E
	INNER JOIN AutoShop.EmployeesRepairs ER ON ER.EmployeeId = E.EmployeeId
	INNER JOIN AutoShop.Repairs R ON R.RepairId = ER.RepairId
WHERE E.EmployeeName = @EmployeeName;
GO

--EXEC AutoShop.FetchRepairHistoryEmployee 'Shannon Colon';
