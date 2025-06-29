use DN40week2;

CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10,2)
);

INSERT INTO Products (ProductID, ProductName, Category, Price)
VALUES
(1,  'iPhone 13',         'Electronics', 999.99),
(2,  'Samsung Galaxy S22','Electronics', 899.99),
(3,  'Sony Headphones',   'Electronics', 199.99),
(4,  'MacBook Pro',       'Electronics', 1999.99),
(5,  'Dell XPS 13',       'Electronics', 1399.99),
(6,  'Leather Jacket',    'Fashion',     299.99),
(7,  'Sneakers',          'Fashion',     129.99),
(8,  'Sunglasses',        'Fashion',     79.99),
(9,  'Wrist Watch',       'Fashion',     149.99),
(10, 'Handbag',           'Fashion',     249.99),
(11, 'Dining Table',      'Furniture',   599.99),
(12, 'Sofa',              'Furniture',   899.99),
(13, 'Study Desk',        'Furniture',   399.99),
(14, 'Bookshelf',         'Furniture',   249.99),
(15, 'Bed Frame',         'Furniture',   1099.99),
(16, 'Smart TV 55"',      'Electronics', 1199.99),
(17, 'T-Shirt',           'Fashion',     39.99),
(18, 'Gaming Chair',      'Furniture',   499.99),
(19, 'Blazer',            'Fashion',     299.99),
(20, 'Tablet Pro',        'Electronics', 699.99);


select * from Products;

SELECT * FROM (
    SELECT 
        ProductID,
        ProductName,
        Category,
        Price,
        ROW_NUMBER() OVER (PARTITION BY Category ORDER BY Price DESC) AS RowNum
    FROM Products
) AS RankedProducts
WHERE RowNum <= 3;


SELECT * FROM (
    SELECT 
        ProductID,
        ProductName,
        Category,
        Price,
        RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS RankNum
    FROM Products
) AS RankedProducts
WHERE RankNum <= 3;


SELECT * FROM (
    SELECT 
        ProductID,
        ProductName,
        Category,
        Price,
        DENSE_RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS DenseRank
    FROM Products
) AS RankedProducts
WHERE DenseRank <= 3;
