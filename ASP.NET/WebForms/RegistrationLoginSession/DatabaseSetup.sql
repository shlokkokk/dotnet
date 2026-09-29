
IF DB_ID('DotNetPractical') IS NULL
    CREATE DATABASE DotNetPractical;
GO
USE DotNetPractical;
GO
IF OBJECT_ID('dbo.Feedback','U') IS NULL
    CREATE TABLE dbo.Feedback(
        Id INT IDENTITY(1,1) PRIMARY KEY,
        Name NVARCHAR(100) NOT NULL,
        Message NVARCHAR(500) NOT NULL
    );
GO
IF OBJECT_ID('dbo.Users','U') IS NULL
    CREATE TABLE dbo.Users(
        Id INT IDENTITY(1,1) PRIMARY KEY,
        Username NVARCHAR(50) NOT NULL UNIQUE,
        Password NVARCHAR(100) NOT NULL
    );
GO
