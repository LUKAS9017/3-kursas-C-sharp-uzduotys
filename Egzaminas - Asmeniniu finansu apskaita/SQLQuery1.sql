-- Sukuriame duomen� baz�
CREATE DATABASE AsmeniniuFinansuApskaita;

use AsmeniniuFinansuApskaita;

-- Naudotoj� lentel�
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL,
    Password NVARCHAR(50) NOT NULL
);

-- Klasifikatori� lentel�
CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY IDENTITY(1,1),
    Type NVARCHAR(50) NOT NULL, -- "Pajamos" arba "I�laidos"
    Name NVARCHAR(50) NOT NULL
);

-- �ra�� lentel�
CREATE TABLE Transactions (
    TransactionID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT FOREIGN KEY REFERENCES Users(UserID),
    CategoryID INT FOREIGN KEY REFERENCES Categories(CategoryID),
    Amount DECIMAL(18,2) NOT NULL,
    Date DATE NOT NULL,
    Description NVARCHAR(255)
);
