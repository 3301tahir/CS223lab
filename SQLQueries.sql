CREATE DATABASE cs223labDB
GO
USE cs223labDB
GO

CREATE TABLE Product (
    productNumber VARCHAR(10),
    inventoryNumber VARCHAR(10),
    dateAdded DATETIME,
    name VARCHAR(35),
    count INT,
    price FLOAT,
    availability BIT,
    delivery BIT,
    warranty BIT
)

INSERT INTO Product VALUES ('PR-097', 'IN-08', GETDATE(), 'OnePlus 10T', 1500, 799.99, 1, 1, 1),
    ('PR-091', 'IN-08', GETDATE(), 'OnePlus 10 Pro', 1700, 899.99, 1, 1, 1),
    ('PR-090', 'IN-08', '2022-01-15', 'OnePlus 10', 950, 749.99, 1, 1, 1),
    ('PR-081', 'IN-05', '2021-08-11', 'Oneplus 9T/R', 800, 799.99, 1, 1, 1),
    ('PR-078', 'IN-07', '2021-02-01', 'Oneplus 9', 800, 699.99, 0, 1, 0),
    ('PR-079', 'IN-07', '2020-10-19', 'Oneplus Nord', 50, 349.99, 0, 0, 0),
    ('PR-069', 'IN-06', '2019-12-21', 'Oneplus 8', 95, 399.99, 1, 0, 0)

SELECT * FROM Product

-- PROCEDURES for C# side

GO
CREATE PROCEDURE eProduct
@productNumber VARCHAR(10),
@inventoryNumber VARCHAR(10),
@dateAdded DATETIME,
@name VARCHAR(35),
@count INT,
@price FLOAT,
@availability BIT,
@delivery BIT,
@warranty BIT

AS
BEGIN
    INSERT INTO Product VALUES (@productNumber, @inventoryNumber, @dateAdded, @name, @count, @price, @availability, @delivery, @warranty)
END


GO
CREATE PROCEDURE UpdateProduct
@productNumber VARCHAR(10),
@inventoryNumber VARCHAR(10),
@dateAdded DATETIME,
@name VARCHAR(35),
@count INT,
@price FLOAT,
@availability BIT,
@delivery BIT,
@warranty BIT,
@oldProductNumber VARCHAR(10)
AS
BEGIN
    UPDATE Product 
    SET productNumber = @productNumber,
        inventoryNumber = @inventoryNumber,
        dateAdded = @dateAdded,
        name = @name,
        count = @count,
        price = @price,
        availability = @availability,
        delivery = @delivery,
        warranty = @warranty
    WHERE productNumber = @oldProductNumber
END

GO
CREATE PROCEDURE DeleteProduct
@productNumber VARCHAR(10)
AS
BEGIN
    DELETE FROM Product 
    WHERE productNumber = @productNumber
END


GO
CREATE PROCEDURE GetAllProducts
AS
BEGIN
    SELECT * FROM Product ORDER BY dateAdded DESC, productNumber DESC
END