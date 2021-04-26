-- Q23 FetchSalesPerYear
--Gets a list of sales per year for each store
--DROP PROCEDURE IF EXISTS AutoShop.FetchSalesPerYear
--GO

CREATE PROCEDURE AutoShop.FetchSalesPerYear
AS

SELECT L.StreetAddress, YEAR(A.AppointmentTime) AS Year, (SUM(CONVERT (float, RIGHT(P.Price, LEN(P.Price) - 1))) + SUM(CONVERT (float, RIGHT(P.Price, LEN(R.LaborCost) - 1)))) AS Sales
FROM Locations L
	INNER JOIN AutoShop.Appointments A ON A.LocationId = L.LocationId
	INNER JOIN AutoShop.Repairs R ON R.RepairId = A.RepairId
	INNER JOIN AutoShop.RepairParts RP ON RP.RepairId = R.RepairId
	INNER JOIN AutoShop.Parts P ON P.PartId = RP.PartId
GROUP BY YEAR(A.AppointmentTime), L.StreetAddress
GO
/* example output:
2483 Nulla St.	2019	3617.72
2483 Nulla St.	2021	3916.62
2483 Nulla St.	2022	3278.9
271-191 Nisl Street	2019	565.26
271-191 Nisl Street	2021	3150.32
3521 Quam. Avenue	2019	2764.94
*/

--EXEC AutoShop.FetchSalesPerYear;