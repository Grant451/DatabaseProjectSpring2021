--Q28 must have a valid street address, valid repair name, valid customer in the system.
--must also have the datetime in the right format. 
--DROP PROCEDURE IF EXISTS AutoShop.CreateAppointment
--GO

CREATE OR ALTER PROCEDURE AutoShop.CreateAppointment
	@StreetAddress nvarchar(255),
	@RepairName nvarchar(64),
    @CustomerName nvarchar(64),
	@AppointmentTime Datetime2(0)
AS


INSERT AutoShop.Appointments(LocationId, RepairId, CustomerId, AppointmentTime)
SELECT L.LocationId, R.RepairID, C.CustomerID, A.AppointmentTime
FROM
      (
         VALUES
            (@StreetAddress, @RepairName, @CustomerName, @AppointmentTime)
			) A(StreetAddress, RepairName, CustomerName, AppointmentTime)
   INNER JOIN AutoShop.Locations L ON L.StreetAddress = A.StreetAddress
   INNER JOIN AutoShop.Repairs R ON R.RepairName = A.RepairName
   INNER JOIN AutoShop.Customers C ON C.CustomerName = A.CustomerName;
GO

--EXEC AutoShop.CreateAppointment '427-9420 Mauris. Ave', 'fringilla euismod', 'Randall Park', '2020-06-21 11:13:00';--valid insertion data for demo
--EXEC AutoShop.CreateAppointment '427-9420 Mauris. Ave', 'In condimentum.', 'Roth Mullins', '2020-06-21 11:13:00';--already in the table

--select * from AutoShop.Appointments--used for testing