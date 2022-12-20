CREATE TABLE Products (
Id INT PRIMARY KEY IDENTITY(1,1),
"Name" TEXT
);

CREATE TABLE Categories (
Id INT PRIMARY KEY IDENTITY(1,1),
"Name" TEXT
);

CREATE TABLE ProductCategories (
ProductId INT FOREIGN KEY REFERENCES Products(Id),
CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO Products
VALUES
('Product1'),
('Product2'),
('Product3'),
('Product4');

INSERT INTO Categories
VALUES
('Category1'),
('Category2'),
('Category3');

INSERT INTO ProductCategories
VALUES
(1, 1),
(2, 1),
(1, 3),
(3, 3);

SELECT P."Name", C."Name"
FROM Products P
LEFT JOIN ProductCategories PC
ON P.Id = PC.ProductId
LEFT JOIN Categories C
ON PC.CategoryId = C.Id;