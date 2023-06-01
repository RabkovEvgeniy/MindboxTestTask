INSERT INTO Product 
	(Name)
VALUES
	(N'Чашка'),
	(N'Ложка'),
	(N'Кружка'),
	(N'Вилка'),
	(N'Тарелка'),
	(N'Палатка'),
	(N'Рюкзак'),
	(N'Микрофон');

INSERT INTO Category
	(Name)
VALUES
	(N'Посуда'),
	(N'Туризм');

INSERT INTO Product_Category 
	(ProductId, CategoryId)
VALUES
	(1,1),
	(1,2),
	(2,1),
	(2,2),
	(3,1),
	(3,2),
	(4,1),
	(5,1),
	(6,2),
	(7,2);