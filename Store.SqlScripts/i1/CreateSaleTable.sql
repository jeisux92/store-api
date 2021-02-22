USE Store


IF NOT EXISTS (
    SELECT *
    FROM sys.objects
    WHERE object_id = OBJECT_ID(N'dbo.Sale')

)
BEGIN

CREATE TABLE dbo.Sale(
    Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    CustomerId BIGINT NOT NULL,
    Total BIGINT NOT NULL,	
	CreatedOn DATETIME DEFAULT GETDATE(),
	CONSTRAINT FK_SalesCustomer FOREIGN KEY (CustomerId) REFERENCES Customer(IdentificationNumber)
)

END