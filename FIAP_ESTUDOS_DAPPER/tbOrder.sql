CREATE TABLE [dbo].[tbOrder]
(
	[Order_Id] INT NOT NULL PRIMARY KEY,
	[Order_date] datetime,
	[Delivery_Id] int,
	[Customer_Id] int,
	FOREIGN KEY (Customer_Id) REFERENCES tbCustomer(Customer_Id),
	FOREIGN KEY (Delivery_Id) REFERENCES tbDelivery(Delivery_Id)
)
