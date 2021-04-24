
/*
CREATE TABLE Location.Location (
  LocationID int identity,
  StreetAddress nvarchar(255),
  City nvarchar(255),
  Region nvarchar(50),
  Zip nvarchar(20),
  PRIMARY KEY (LocationID)
);

CREATE TABLE Location.Stock (
  LocationID int identity,
  PartID int,
  Quantity int
);

CREATE INDEX PK ON Location.Stock (LocationID);
CREATE INDEX FK ON Location.Stock (LocationID);

CREATE TABLE Location.Parts (
  PartID int identity,
  PartName nvarchar(32),
  Price NVARCHAR(64) NOT NULL,
  PRIMARY KEY (PartID)
);

CREATE TABLE Location.RepairParts (
  RepairID int identity,
  PartID int,
  quantity int
);

CREATE INDEX PK ON  Location.RepairParts (PartID);
CREATE INDEX FK ON  Location.RepairParts (PartID);

CREATE TABLE Location.Repairs (
  RepairID int identity,
  RepairName nvarchar(64),
  LaborCost nvarchar(100),
  status nvarchar(255),
  PRIMARY KEY (RepairID)
);

CREATE TABLE Location.EmployeesRepairs (
  EmployeeID int identity,
  RepairID int
);

CREATE INDEX PK ON Location.EmployeesRepairs (EmployeeID, RepairID);
CREATE INDEX FK ON Location.EmployeesRepairs (EmployeeID, RepairID);

CREATE TABLE Location.Employees (
  EmployeeID int not null IDENTITY(1,1),
  EmployeeName nvarchar(32) not null,
  [Hours] DATETIME2(0) not null,
  PRIMARY KEY (EmployeeID)
);

CREATE INDEX U ON  Location.Employees (EmployeeName);

CREATE TABLE Location.EmployeesLocation (
  EmployeeID int identity,
  LocationID int
);

CREATE INDEX PK ON Location.EmployeesLocation (EmployeeID, LocationID);
CREATE INDEX FK ON Location.EmployeesLocation (EmployeeID, LocationID);

CREATE TABLE Location.Appointments (
  AppointmentID int Not NUll identity(1,1),
  LocationID int not null,
  RepairID int not null,
  CustomerID int not null,
  AppointmentTime Datetime2(0) not null
);

CREATE INDEX PK ON  Location.Appointments (AppointmentID)--, LocationID, RepairID);
CREATE INDEX FK ON  Location.Appointments (CustomerID, LocationID, RepairID);

CREATE TABLE Location.Customers (
  CustomerID int identity,
  CustomerName nvarchar(64),
  VinNumber nvarchar(11),
  PRIMARY KEY (CustomerID)
);
*/


--drop tables if they exist:
DROP TABLE IF EXISTS AutoShop.Stock;
DROP TABLE IF EXISTS AutoShop.Appointments;
DROP TABLE IF EXISTS AutoShop.EmployeesLocation;
DROP TABLE IF EXISTS AutoShop.EmployeesRepairs;
DROP TABLE IF EXISTS AutoShop.RepairParts;
DROP TABLE IF EXISTS AutoShop.Locations;
DROP TABLE IF EXISTS AutoShop.Repairs;
DROP TABLE IF EXISTS AutoShop.Employees;
DROP TABLE IF EXISTS AutoShop.Customers;
DROP TABLE IF EXISTS AutoShop.Parts;
GO

--drop specific procedures if they exist:
DROP PROCEDURE IF EXISTS Location.FetchRepairHistoryCustomer
DROP PROCEDURE IF EXISTS AutoShop.FetchRepairHistoryCustomer
GO

CREATE TABLE AutoShop.Locations (
  LocationId INT NOT NULL IDENTITY(1, 1),
  StreetAddress NVARCHAR(255) NOT NULL,
  City NVARCHAR(255) NOT NULL,
  Region NVARCHAR(255) NOT NULL,
  Zip NVARCHAR(10) NOT NULL,

  CONSTRAINT [PK_AutoShop_Locations_LocationId] PRIMARY KEY (LocationId),
  CONSTRAINT [UK_AutoShop_Locations_StreetAddress] UNIQUE (StreetAddress)
);


CREATE TABLE AutoShop.Repairs (
  RepairId INT NOT NULL IDENTITY(1, 1),
  RepairName NVARCHAR(64) NOT NULL,
  LaborCost NVARCHAR(100) NOT NULL,
  [Status] NVARCHAR(255) NOT NULL DEFAULT 'In Progress',

  CONSTRAINT [PK_AutoShop_Repairs_RepairId] PRIMARY KEY (RepairID),
  CONSTRAINT [UK_AutoShop_Locations_RepairName] UNIQUE (RepairName)
);


CREATE TABLE AutoShop.Employees (
  EmployeeId INT NOT NULL IDENTITY(1, 1),
  EmployeeName NVARCHAR(255) NOT NULL,
  [Hours] DATETIME2(0) NOT NULL,

  CONSTRAINT [PK_AutoShop_Emplyees_EmployeeId] PRIMARY KEY (EmployeeId),
  CONSTRAINT [UK_AutoShop_Locations_EmployeeName] UNIQUE (EmployeeName)
);


CREATE TABLE AutoShop.Customers (
  CustomerId INT NOT NULL IDENTITY(1, 1),
  CustomerName NVARCHAR(64) NOT NULL,
  vinnumber NVARCHAR(11) NOT NULL,

  CONSTRAINT [PK_AutoShop_Customers_CustomerId] PRIMARY KEY (CustomerID),
  CONSTRAINT [UK_AutoShop_Locations_CustomerName] UNIQUE (CustomerName)
);


CREATE TABLE AutoShop.Parts (
  PartId INT NOT NULL IDENTITY(1, 1),
  PartName NVARCHAR(64) NOT NULL,
  Price NVARCHAR(64) NOT NULL,

  CONSTRAINT [PK_AutoShop_Parts_PartId] PRIMARY KEY (PartID)
);


CREATE TABLE AutoShop.Stock (
  LocationId INT NOT NULL,
  PartId INT NOT NULL,
  Quantity INT NOT NULL,

  CONSTRAINT [FK_AutoShop_Stock_AutoShop_Locations] FOREIGN KEY(LocationId)
	REFERENCES AutoShop.Locations(LocationId),

  CONSTRAINT [FK_AutoShop_Stock_AutoShop_Parts] FOREIGN KEY(PartId)
	REFERENCES AutoShop.Parts(PartId)
);


CREATE TABLE AutoShop.Appointments (
  AppointmentId INT NOT NULL IDENTITY(1, 1),
  LocationId INT NOT NULL,
  RepairId INT NOT NULL,
  CustomerId INT NOT NULL,
  AppointmentTime DATETIME2(0) NOT NULL,

  CONSTRAINT [PK_AutoShop_Appointments_AppointmentId] PRIMARY KEY (AppointmentId),

  CONSTRAINT [FK_AutoShop_Appointments_AutoShop_Location] FOREIGN KEY(LocationId)
	REFERENCES AutoShop.Locations(LocationId),

  CONSTRAINT [FK_AutoShop_Appointments_AutoShop_Repairs] FOREIGN KEY(RepairId)
	REFERENCES AutoShop.Repairs(RepairId),

  CONSTRAINT [FK_AutoShop_Appointments_AutoShop_Customers] FOREIGN KEY(CustomerId)
	REFERENCES AutoShop.Customers(CustomerId)
);


CREATE TABLE AutoShop.EmployeesLocation (
	EmployeeId INT NOT NULL, 
	LocationId INT NOT NULL, 

	CONSTRAINT [FK_AutoShop_EmployeesLocation_AutoShop_Employees] FOREIGN KEY(EmployeeId)
		REFERENCES AutoShop.Employees(EmployeeId),

	CONSTRAINT [FK_AutoShop_EmployeesLocation_AutoShop_Locations] FOREIGN KEY(LocationId)
		REFERENCES AutoShop.Locations(LocationId)
);


CREATE TABLE AutoShop.EmployeesRepairs (
	EmployeeId INT NOT NULL, 
	RepairId INT NOT NULL, 

	CONSTRAINT [FK_AutoShop_EmployeesRepairs_AutoShop_Employees] FOREIGN KEY(EmployeeId)
		REFERENCES AutoShop.Employees(EmployeeId),

	CONSTRAINT [FK_AutoShop_EmployeesRepairs_AutoShop_Repairs] FOREIGN KEY(RepairId)
		REFERENCES AutoShop.Repairs(RepairId)
);


CREATE TABLE AutoShop.RepairParts (
	RepairId INT NOT NULL,
	PartId INT NOT NULL,

	CONSTRAINT [FK_AutoShop_RepairParts_AutoShop_Repairs] FOREIGN KEY(RepairId)
		REFERENCES AutoShop.Repairs(RepairId),

	CONSTRAINT [FK_AutoShop_RepairParts_AutoShop_Parts] FOREIGN KEY(PartId)
		REFERENCES AutoShop.Parts(PartId)
);
