CREATE OR ALTER PROCEDURE Location.RetrieveRepairs
AS

SELECT L.RepairID, L.RepairName, L.LaborCost, L.Status
FROM Location.Repairs L
GO