CREATE TABLE [dbo].[tbProduct]
(
	[Product_Id] INT NOT NULL PRIMARY KEY,
	[Product_Name] varchar(50),
	[Category_Id] int,
	FOREIGN KEY (Category_Id) REFERENCES tbCategories(Category_Id),

)
