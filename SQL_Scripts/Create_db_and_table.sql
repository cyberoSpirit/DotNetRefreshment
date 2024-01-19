USE master; 
GO 

IF NOT EXISTS 
( SELECT name FROM sys.databases WHERE name = N'DotNetCourseDatabase' ) 
CREATE DATABASE [DotNetCourseDatabase]; 
Go
     
USE DotNetCourseDatabase
GO

IF NOT EXISTS 
( SELECT * FROM sys.schemas WHERE name = N'TutorialAppSchema' )
EXEC('CREATE SCHEMA [TutorialAppSchema]');
GO

IF NOT EXISTS 
( SELECT * FROM sys.tables WHERE name = N'Computer' )
CREATE TABLE Computer(
    ComputerId INT IDENTITY(1,1) PRIMARY KEY,
    Motherboard NVARCHAR(50),
    CPUCores INT,
    HasWifi BIT,
    HasLTE BIT,
    ReleaseDate DATE,
    Price DECIMAL(18,4),
    VideoCard NVARCHAR(50)
);