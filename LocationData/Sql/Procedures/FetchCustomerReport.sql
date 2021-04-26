-- Q24 Fetch Repeat Repairs for a specific customer
--DROP PROCEDURE IF EXISTS AutoShop.FetchCustomerReport
--GO

CREATE PROCEDURE AutoShop.FetchCustomerReport
	@CustomerName NVARCHAR(64)
AS

SELECT C.CustomerId, C.CustomerName, R.RepairId, C.vinnumber
FROM AutoShop.Employees E
	INNER JOIN AutoShop.EmployeesRepairs ER ON ER.EmployeeId = E.EmployeeId
	INNER JOIN AutoShop.Repairs R ON R.RepairId = ER.RepairId
	INNER JOIN AutoShop.Appointments A ON A.RepairId = R.RepairId
	INNER JOIN AutoShop.Customers C ON C.CustomerId = A.CustomerId
WHERE C.CustomerName = @CustomerName
GROUP BY C.CustomerId, C.CustomerName, R.RepairId, C.vinnumber
GO

--EXEC AutoShop.FetchCustomerReport 'Zeus Terry';