SELECT
    Product.Name AS Product,
    COALESCE(Category.Name, 'Without category') AS Category
FROM 
    Product
LEFT JOIN 
    (Category INNER JOIN ProductCategories ON Category.ID = ProductCategories.CategoryID) ON Product.ID = ProductCategories.ProductID
ORDER BY 
    Product.Name;