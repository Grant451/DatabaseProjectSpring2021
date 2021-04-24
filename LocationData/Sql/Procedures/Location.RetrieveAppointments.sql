CREATE OR ALTER PROCEDURE AutoShop.RetrieveAppointments
AS

Select A.AppointmentID, A.LocationID, A.RepairID, A.CustomerID, A.AppointmentTime
From Location.Appointments A
GO

/*
  AppointmentID int Not NUll identity(1,1),
  LocationID int not null,
  RepairID int not null,
  CustomerID int not null,
  AppointmentTime Datetime2(0) not null
  */