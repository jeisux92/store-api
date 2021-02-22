USE Store


IF NOT EXISTS (
    SELECT *
    FROM sys.objects
    WHERE object_id = OBJECT_ID(N'dbo.Bill')

)
BEGIN

CREATE TABLE dbo.Bill(
    Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    SaleId INT ,
    ProductId INT NOT NULL,
    Quantity BIGINT NOT NULL,
	CONSTRAINT FK_SaleBill FOREIGN KEY (SaleId) REFERENCES Sale(Id)
    
)

END