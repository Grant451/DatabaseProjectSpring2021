CREATE OR ALTER PROCEDURE AutoShop.CreateAppointment
	@AppointmentID int Output,
	@LocationID int,
	@RepairID int,
    @CustomerID int,
	@AppointmentTime Datetime2(0)
AS

INSERT Location.Appointments(LocationID, RepairID, CustomerID, AppointmentTime)
VALUES(@LocationID, @RepairID, @CustomerID, @AppointmentTime);

SET @AppointmentID = SCOPE_IDENTITY();--primary key
GO

/*
  AppointmentID int Not NUll identity(1,1),
  LocationID int not null,
  RepairID int not null,
  CustomerID int not null,
  AppointmentTime Datetime2(0) not null
  */