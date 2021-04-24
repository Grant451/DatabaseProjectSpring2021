CREATE OR ALTER PROCEDURE AutoShop.RetrieveRepairs
AS

SELECT L.RepairID, L.RepairName, L.LaborCost, L.Status
FROM AutoShop.Repairs L
GO

