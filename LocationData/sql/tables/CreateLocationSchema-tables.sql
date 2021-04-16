

CREATE TABLE Location.Location (
  LocationID int identity,
  StreetAddress nvarchar(255),
  City nvarchar(255),
  Region nvarchar(50),
  Zip nvarchar(10)
  PRIMARY KEY (LocationID)
);

CREATE TABLE Location.Stock (
  LocationID int identity,
  PartID int,
  Quantity int
);

CREATE INDEX PK,FK1 ON  Stock (LocationID);

CREATE TABLE Location.Parts (
  PartID int identity,
  PartName nvarchar(32),
  PRIMARY KEY (PartID)
);

CREATE TABLE Location.RepairParts (
  RepairID int identity,
  PartID int,
  quantity int
);

CREATE INDEX (PK,FK) ON  RepairParts (RepairID, PartID);

CREATE TABLE Location.Repairs (
  RepairID int identity,
  RepairName TEXT,
  LaborCost nvarchar(100),
  status nvarchar(255),
  PRIMARY KEY (RepairID)
);

CREATE TABLE Location.EmployeesRepairs (
  EmployeeID int identity,
  RepairID int
);

CREATE INDEX (PK,FK) ON  EmployeesRepairs (EmployeeID, RepairID);

CREATE TABLE Location.Employees (
  EmployeeID int identity,
  EmployeeName nvarchar(32),
  hours int
  PRIMARY KEY (EmployeeID)
);

CREATE INDEX U ON  Employees (EmployeeName);

CREATE TABLE Location.EmployeesLocation (
  EmployeeID int identity,
  LocationID int
);

CREATE INDEX (PK,FK) ON  EmployeesLocation (EmployeeID, LocationID);

CREATE TABLE Location.Appointments (
  CustomerID int identity,
  LocationID int,
  RepairID int,
  Datetime Datetime2
);

CREATE INDEX (PK,FK) ON  Appointments (CustomerID, LocationID, RepairID);

CREATE TABLE Location.Customers (
  CustomerID int identity,
  CustomerName nvarchar(64),
  vinnumber nvarchar(11),
  PRIMARY KEY (CustomerID)
);

