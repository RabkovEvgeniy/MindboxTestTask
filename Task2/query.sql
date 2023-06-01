SELECT p.Name as Product, c.Name as Category
FROM Product p
LEFT JOIN Product_Category pc ON pc.ProductId = p.Id
LEFT JOIN Category c ON c.Id = pc.CategoryId 

-- Результат:
-- |Product |Category|
-- |--------|--------|
-- |Чашка   |Посуда  |
-- |Чашка   |Туризм  |
-- |Ложка   |Посуда  |
-- |Ложка   |Туризм  |
-- |Кружка  |Посуда  |
-- |Кружка  |Туризм  |
-- |Вилка   |Посуда  |
-- |Тарелка |Посуда  |
-- |Палатка |Туризм  |
-- |Рюкзак  |Туризм  |
-- |Микрофон|        |