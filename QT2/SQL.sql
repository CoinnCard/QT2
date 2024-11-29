-- Create the database
CREATE DATABASE TicketDB;
GO

-- Use the newly created database
USE TicketDB;
GO

-- Create Users table
CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(100),
    Email NVARCHAR(100),
    Phone NVARCHAR(15),
    PaymentMethod NVARCHAR(50)
);
GO

-- Create Tickets table
CREATE TABLE Tickets (
    TicketID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT FOREIGN KEY REFERENCES Users(UserID),
    Destination NVARCHAR(100),
    TransportationMode NVARCHAR(50),
    PaymentStatus NVARCHAR(20),
    IssuedAt DATETIME DEFAULT GETDATE()
);
GO

-- Create Payments table
CREATE TABLE Payments (
    PaymentID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT FOREIGN KEY REFERENCES Users(UserID),
    TicketID INT FOREIGN KEY REFERENCES Tickets(TicketID),
    PaymentType NVARCHAR(50),
    PaymentAmount DECIMAL(10, 2),
    PaymentDate DATETIME DEFAULT GETDATE(),
    PaymentStatus NVARCHAR(20)
);
GO

-- Insert a user into the Users table
INSERT INTO Users (FullName, Email, Phone, PaymentMethod)
VALUES ('Nguyễn Văn A', 'nguyenvana@example.com', '0901234567', 'Momo');
GO

-- Insert a ticket into the Tickets table
INSERT INTO Tickets (UserID, Destination, TransportationMode, PaymentStatus)
VALUES (1, 'Bến Thành Market', 'Bus', 'Pending');
GO

-- Insert a payment record into the Payments table
INSERT INTO Payments (UserID, TicketID, PaymentType, PaymentAmount, PaymentStatus)
VALUES (1, 1, 'Momo', 50.00, 'Completed');
GO

-- Select all users
SELECT * FROM Users;
GO

-- Select all tickets
SELECT * FROM Tickets;
GO

-- Select payments for UserID 1
SELECT * FROM Payments WHERE UserID = 1;
GO
