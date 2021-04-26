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

<#Query 1 #>
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LocationData\Sql\Procedures\FetchPartInformation.sql"
<#Query 2 #>
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LocationData\Sql\Procedures\Location.FetchRepairHistoryCustomer.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LocationData\Sql\Procedures\Location.RetrieveRepairs.sql" <#suplemental#>
<#Query 3 #>
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LocationData\Sql\Procedures\FetchRepairHistoryVin.sql"
<#Query 4 #>
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LocationData\Sql\Procedures\FetchRepairHistoryEmployee.sql"
<#Query 5 #>
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LocationData\Sql\Procedures\FetchPart.sql"
<#Query 6 #>
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LocationData\Sql\Procedures\FetchRepairParts.sql"
<#Query 7 #>
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LocationData\Sql\Procedures\FetchEmployeeLocation.sql"
<#Query 8 #>
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LocationData\Sql\Procedures\FetchEmployeeRepairCounts.sql"
<#Query 9 #>
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LocationData\Sql\Procedures\FetchAllEmployeeRepairCounts.sql"
<#Query 10 #>
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LocationData\Sql\Procedures\FetchSalesSpecific.sql"
<#Query 11 #>
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LocationData\Sql\Procedures\FetchSales.sql"
<#Query 12 #>
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LocationData\Sql\Procedures\FetchInventorySpecific.sql"
<#Query 13 #>
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LocationData\Sql\Procedures\FetchInventory.sql"
<#Query 14 #>
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LocationData\Sql\Procedures\FetchReparsinProgress.sql"
<#Query 16 #>
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LocationData\Sql\Procedures\FetchAllLocationsAddress.sql"
<#Query 17 #>
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LocationData\Sql\Procedures\FetchAllEmployees.sql"
<#Query 19 #>
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LocationData\Sql\Procedures\FetchRepeatRepairSpecific.sql"
<#Query 20 #>
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LocationData\Sql\Procedures\FetchRepeatRepairs.sql"
<#Query 22 #>
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LocationData\Sql\Procedures\FetchPopularApptTimes.sql"
<#Query 23 #>
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LocationData\Sql\Procedures\FetchSalesPerYear.sql"

<#
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Person.CreatePerson.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Person.RetrievePersons.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Person.FetchPerson.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Person.GetPerson.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Person.SavePersonAddress.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Person.RetrieveAddressesForPerson.sql"
#>


<#
Write-Host "Inserting data..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Data\Person.AddressType.sql"
#>

Write-Host "Rebuild completed."
Write-Host ""

Set-Location $CurrentDrive
