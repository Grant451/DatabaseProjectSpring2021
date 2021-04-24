

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

