--DROP PROCEDURE IF EXISTS AutoShop.FetchPopularApptTimes
--GO

CREATE PROCEDURE AutoShop.FetchPopularApptTimes
AS

SELECT L.StreetAddress, 
	COUNT(DISTINCT IIF(CAST(A.AppointmentTime as time) BETWEEN '01:00:00' AND '11:59:00', A.AppointmentId, NULL)) AS MorningAppointments,
	COUNT(DISTINCT IIF(CAST(A.AppointmentTime as time) BETWEEN '12:00:00' AND '16:59:00', A.AppointmentId, NULL)) AS AfternoonAppointments,
	COUNT(DISTINCT IIF(CAST(A.AppointmentTime as time) BETWEEN '17:00:00' AND '23:59:00', A.AppointmentId, NULL)) AS EveningAppointments
FROM AutoShop.Locations L
	INNER JOIN AutoShop.Appointments A ON A.LocationId = L.LocationId
GROUP BY L.StreetAddress
GO
--EXEC AutoShop.FetchPopularApptTimes;