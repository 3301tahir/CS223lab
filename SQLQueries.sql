CREATE TABLE Product (
    productNumber VARCHAR(10),
    inventoryNumber VARCHAR(10),
    dateAdded DATETIME,
    name VARCHAR(35),
    count INT,
    price FLOAT,
    availability BIT,
    delivery BIT,
    installation BIT
)

INSERT INTO Product VALUES ('PR-069', 'IN-01', GETDATE(), 'Chairs', 23, 39.99, 1, 0, 0);
INSERT INTO Product VALUES ('PR-071', 'IN-03', GETDATE(), 'Tables', 15, 59.99, 1, 0, 0);
INSERT INTO Product VALUES ('PR-072', 'IN-03', GETDATE(), 'Shelves', 8, 149.99, 1, 1, 1);

SELECT * FROM Product