CREATE TABLE Product
(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(20)
);

CREATE TABLE Category
(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(20)
);

CREATE TABLE Product_Category
(
	ProductId INT REFERENCES Product (Id),
	CategoryId INT REFERENCES Category (Id),
	CONSTRAINT PK_Product_Category PRIMARY KEY (ProductId, CategoryId)
);