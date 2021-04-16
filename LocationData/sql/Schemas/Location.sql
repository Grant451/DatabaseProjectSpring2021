IF NOT EXISTS
   (
      SELECT *
      FROM sys.schemas s
      WHERE s.[name] = 'Location'
   )
BEGIN
   EXEC('CREATE SCHEMA [Location] AUTHORIZATION [dbo]');
END;