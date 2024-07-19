

CREATE DATABASE EmployeeDB;


USE EmployeeDB;


CREATE TABLE Departments (
    DeptId INT PRIMARY KEY IDENTITY,
    DeptName NVARCHAR(100) NOT NULL,
    DeptCreation DATETIME NOT NULL
);


CREATE TABLE Employees (
    EmployeeId INT PRIMARY KEY IDENTITY,
    EmployeeName NVARCHAR(100) NOT NULL,
    Age INT NOT NULL,
    Gender NVARCHAR(50) NOT NULL,
    City NVARCHAR(100) NOT NULL,
    Address NVARCHAR(200) NOT NULL,
    DeptId INT,
    FOREIGN KEY (DeptId) REFERENCES Departments(DeptId)
);

