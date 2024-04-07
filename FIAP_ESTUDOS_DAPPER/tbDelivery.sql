CREATE TABLE [dbo].[tbDelivery]
(
	[Delivery_Id] INT NOT NULL PRIMARY KEY,
	[DeliveryType_Id] int,
	[Status] bit
	FOREIGN KEY (DeliveryType_Id) REFERENCES tbDeliveryType(DeliveryType_Id)

)
