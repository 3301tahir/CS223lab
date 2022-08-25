DROP TABLE Product

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

INSERT INTO Product VALUES ('PR-097', 'IN-08', GETDATE(), 'OnePlus 10T', 1500, 799.99, 1, 1, 1);
INSERT INTO Product VALUES ('PR-091', 'IN-08', GETDATE(), 'OnePlus 10 Pro', 1700, 899.99, 1, 1, 1);
INSERT INTO Product VALUES ('PR-090', 'IN-08', '2022-01-15', 'OnePlus 10', 950, 749.99, 1, 1, 1);
INSERT INTO Product VALUES ('PR-081', 'IN-05', '2021-08-11', 'Oneplus 9T/R', 800, 799.99, 1, 1, 1);
INSERT INTO Product VALUES ('PR-078', 'IN-07', '2021-02-01', 'Oneplus 9', 800, 699.99, 0, 1, 0);
INSERT INTO Product VALUES ('PR-079', 'IN-07', '2020-10-19', 'Oneplus Nord', 50, 349.99, 0, 0, 0);
INSERT INTO Product VALUES ('PR-069', 'IN-06', '2019-12-21', 'Oneplus 8', 95, 399.99, 1, 0, 0);

SELECT * FROM Product