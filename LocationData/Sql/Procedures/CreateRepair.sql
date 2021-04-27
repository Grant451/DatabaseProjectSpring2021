--Q29 inserts into repairs table.
--N'fringilla euismod', '$3.67', 'Complete'
--DROP PROCEDURE IF EXISTS AutoShop.CreateRepair
--GO

CREATE OR ALTER PROCEDURE AutoShop.CreateRepair
  @RepairName NVARCHAR(64),
  @LaborCost NVARCHAR(100),
  @Status NVARCHAR(255)
AS


INSERT INTO AutoShop.Repairs (RepairName, LaborCost, [Status])
VALUES	(@RepairName, @LaborCost, @Status)
GO

--EXEC AutoShop.CreateRepair 'window replacement', '$1.25' ,'Complete';--valid insertion data for demo
--EXEC AutoShop.CreateRepair '427-9420 Mauris. Ave', 'In condimentum.', 'Roth Mullins', '2020-06-21 11:13:00';--already in the table

--select * from AutoShop.Repairs--used for testing