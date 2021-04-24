IF NOT EXISTS
   (
      SELECT *
      FROM sys.schemas s
      WHERE s.[name] = 'AutoShop'
   )
BEGIN
   EXEC('CREATE SCHEMA [AutoShop] AUTHORIZATION [dbo]');
END;