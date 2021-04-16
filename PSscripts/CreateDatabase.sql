USE [master];

IF EXISTS
   (
      SELECT *
      FROM sys.databases d
      WHERE d.name = N'$(DatabaseName)'
   )
BEGIN
   DECLARE @Msg varchar(256) = 'Database [$(DatabaseName)] already exists.';
   PRINT @Msg;
   RETURN;
END;

-- The file has to be provided to work around a known bug
-- with SqlLocalDB 2017.
CREATE DATABASE [$(DatabaseName)]
ON PRIMARY 
(
   NAME = N'PrimaryData',
   FILENAME = N'$(USERPROFILE)\$(DatabaseName).mdf'
)
COLLATE SQL_Latin1_General_CP1_CI_AS;

ALTER DATABASE [$(DatabaseName)]
SET
   ANSI_NULLS ON,
   ANSI_PADDING ON,
   ANSI_WARNINGS ON,
   ARITHABORT ON,
   AUTO_CLOSE OFF,
   AUTO_CREATE_STATISTICS ON,
   AUTO_SHRINK OFF,
   AUTO_UPDATE_STATISTICS ON,
   CONCAT_NULL_YIELDS_NULL ON,
   NUMERIC_ROUNDABORT OFF,
   QUOTED_IDENTIFIER OFF,
   RECURSIVE_TRIGGERS OFF,
   ALLOW_SNAPSHOT_ISOLATION ON,
   RECOVERY SIMPLE;
GO