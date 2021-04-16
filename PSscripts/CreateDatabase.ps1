[cmdletbinding()]
Param(
  [string] $Server = "(localdb)\MSSQLLocalDB",
  [string] $Database
)

$CurrentDrive = (Get-Location).Drive.Name + ":"
$CreateDatabaseScript = $PSScriptRoot + "\CreateDatabase.sql"

Write-Host
Write-Host "Creating database [$Database] if it does not exist..."
Invoke-Sqlcmd -ServerInstance $Server -Database "master" -InputFile $CreateDatabaseScript -Variable "DatabaseName=$Database"

if ( -not $? ) {
   throw "An error occurred creating the database."
}

Write-Host
Set-Location $CurrentDrive
