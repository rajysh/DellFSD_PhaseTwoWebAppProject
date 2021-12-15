--Create database EFCoreDBFirst
--go
use EFCoreDBFirst
go

--CREATE TABLE Users
--(
--UserId INT PRIMARY KEY IDENTITY(1,1),
--UserName VARCHAR(MAX),
--Password VARCHAR(MAX),
--FullName VARCHAR(MAX),
--Email VARCHAR(MAX),
--AGE INT)
--GO

select * from Users
GO
--Scaffold-DbContext "Server=W102XZP8Y2;Database=EFCoreDBFirst;Integrated Security=true"
--Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
--CREATE TABLE ContactDetail(
--ContactDetailId INT PRIMARY KEY IDENTITY,
--ContactName VARCHAR(MAX))

--Scaffold-DbContext "Server=W102XZP8Y2;Database=EFCoreDBFirst;Integrated Security=true"
--Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -FORCE

CREATE TABLE Brand(
BrandId INT PRIMARY KEY IDENTITY,
BrandName VARCHAR(MAX) NOT NULL,
BrandDesc VARCHAR(MAX) NOT NULL,
BrandAddedDate DATETIME)
GO

CREATE TABLE Product(
ProductId INT PRIMARY KEY IDENTITY,
ProductName VARCHAR(MAX) NOT NULL,
Price FLOAT,
Quantity INT,
ProductAddedDate DATETIME,
BrandId INT FOREIGN KEY REFERENCES Brand(BrandId))
GO