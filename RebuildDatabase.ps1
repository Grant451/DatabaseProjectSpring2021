Param(
   [string] $Server = "(localdb)\MSSQLLocalDb",
   [string] $Database = "CIS560"
)

# This script requires the SQL Server module for PowerShell.
# The below commands may be required.

# To check whether the module is installed.
# Get-Module -ListAvailable -Name SqlServer;

# Install the SQL Server Module
# Install-Module -Name SqlServer -Scope CurrentUser

$CurrentDrive = (Get-Location).Drive.Name + ":"

Write-Host ""
Write-Host "Rebuilding database $Database on $Server..."

<#
   If on your local machine, you can drop and re-create the database.
#>
& ".\PSscripts\DropDatabase.ps1" -Database $Database
& ".\PSscripts\CreateDatabase.ps1" -Database $Database

<#
   If on the department's server, you don't have permissions to drop or create databases.
   In this case, maintain a script to drop all tables.
#>
#Write-Host "Dropping tables..."
#Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Tables\DropTables.sql"

Write-Host "Creating schema..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LocationData\Sql\Schemas\Location.sql"

Write-Host "Creating tables..."
Invoke-sqlcmd -ServerInstance $Server -Database $Database -InputFile "LocationData\Sql\Tables\CreateLocationtables.sql"

Write-Host "Inserting testData..."
Invoke-sqlcmd -ServerInstance $Server -Database $Database -InputFile "LocationData\Sql\Data\testData.sql"

Write-Host "Stored procedures..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LocationData\Sql\Procedures\Location.CreateLocation.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LocationData\Sql\Procedures\Location.RetrieveLocations.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LocationData\Sql\Procedures\Location.FetchLocation.sql"

Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LocationData\Sql\Procedures\Location.CreateAppointment.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LocationData\Sql\Procedures\Location.RetrieveAppointments.sql"

Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LocationData\Sql\Procedures\Location.CreateCustomer.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LocationData\Sql\Procedures\Location.RetrieveCustomers.sql"

<#     #>
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LocationData\Sql\Procedures\Location.FetchRepairHistoryCustomer.sql"

Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LocationData\Sql\Procedures\Location.RetrieveRepairs.sql"

<#
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Person.CreatePerson.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Person.RetrievePersons.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Person.FetchPerson.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Person.GetPerson.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Person.SavePersonAddress.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Person.RetrieveAddressesForPerson.sql"
#>

Write-Host "Inserting data..."
<#
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Data\Person.AddressType.sql"
#>

Write-Host "Rebuild completed."
Write-Host ""

Set-Location $CurrentDrive
