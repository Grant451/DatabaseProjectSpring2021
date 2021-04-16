[cmdletbinding()]
Param(
  [string] $Server = "(localdb)\MSSQLLocalDB",
  [string] $Database
)

$Sql = @"
IF EXISTS
   (
      SELECT *
      FROM sys.databases d
      WHERE d.name = N'`$(DatabaseName)'
   )
BEGIN
   ALTER DATABASE [`$(DatabaseName)]
   SET SINGLE_USER
   WITH ROLLBACK IMMEDIATE;

   DROP DATABASE [`$(DatabaseName)];
END;
"@

Write-Host "Dropping $Database database"

Invoke-Sqlcmd -ServerInstance $Server -Database "master" -Query $Sql -Variable "DatabaseName=$Database"