CREATE TABLE [dbo].[tbOrderProducts]
(
	[OrderProduct_Id] INT NOT NULL PRIMARY KEY,
	[Product_Id] int,
	[Order_Id] int
	FOREIGN KEY (Product_Id) REFERENCES tbProduct(Product_Id),
	FOREIGN KEY (Order_Id) REFERENCES tbOrder(Order_Id),
)
