--Q13 Fetch the inventory of all stores
--DROP PROCEDURE IF EXISTS AutoShop.FetchInventory
--GO

CREATE PROCEDURE AutoShop.FetchInventory
AS

SELECT P.PartName, S.Quantity, 
	CASE      
		WHEN S.Quantity < 10 THEN N'Very Low'     
		WHEN S.Quantity BETWEEN 10 AND 30 THEN N'Running Low'      
		WHEN S.Quantity BETWEEN 31 AND 50 THEN N'Order Soon'      
		ELSE N'In Stock'   
	END AS QuantityStatus

FROM AutoShop.Locations L
	INNER JOIN AutoShop.Stock S ON S.LocationId = L.LocationId
	INNER JOIN AutoShop.Parts P ON P.PartId = S.PartId
ORDER BY S.Quantity ASC
GO

--EXEC AutoShop.FetchInventory;