--q28

--DROP PROCEDURE IF EXISTS AutoShop.CreateAppointment
--GO

CREATE OR ALTER PROCEDURE AutoShop.CreateAppointment
	--@AppointmentID int Output,
	@LocationID int,
	@RepairID int,
    @CustomerID int,
	@AppointmentTime Datetime2(0)
AS

INSERT AutoShop.Appointments(LocationID, RepairID, CustomerID, AppointmentTime)
SELECT @LocationID, @RepairID, @CustomerID, @AppointmentTime
FROM 
        (
            VALUES
            (@LocationID, @RepairID, @CustomerID, @AppointmentTime)
        ) A(StreetAddress, RepairName, CustomerName, AppointmentTime)
   INNER JOIN AutoShop.Locations L ON L.StreetAddress = A.StreetAddress
   INNER JOIN AutoShop.Repairs R ON R.RepairName = A.RepairName
   INNER JOIN AutoShop.Customers C ON C.CustomerName = A.CustomerName;
--SET @AppointmentID = SCOPE_IDENTITY();--primary key
GO

/*
  AppointmentID int Not NUll identity(1,1),
  LocationID int not null,
  RepairID int not null,
  CustomerID int not null,
  AppointmentTime Datetime2(0) not null
  */