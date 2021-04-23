CREATE OR ALTER PROCEDURE Location.CreateAppointment
	@CustomerID int,
	@LocationID int,
	@RepairID int,
	@Datetime Datetime2
AS

INSERT Location.Appointments(Datetime)
VALUES(@Datetime);

SET @CustomerID = SCOPE_IDENTITY();--primary key
SET @LocationID = SCOPE_IDENTITY();--primary key
SET @RepairID = SCOPE_IDENTITY();--primary key
GO

/*
  CustomerID int identity,
  LocationID int,
  RepairID int,
  Datetime Datetime2
  */