CREATE DATABASE users
DROP DATABASE users
use users

CREATE TABLE Users
( UserID int NOT NULL IDENTITY
          CONSTRAINT PK_Users PRIMARY KEY,
  FirstName varchar(25),
  LastName varchar(25),
  UserEmail varchar(25),
  UserPassword varchar(25),
  ConfirmPassword varchar(25),
  UserLevel varchar(15)
)

SELECT *
FROM Users

DROP TABLE Users