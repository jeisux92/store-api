USE Store
GO


CREATE OR ALTER PROCEDURE dbo.CustomerCreate
(
    @IdentificationNumber BIGINT NOT NULL,
    @Name VARCHAR(250) NOT NULL,
    @LastName VARCHAR(250) NOT NULL,
    @Phone BIGINT   
)
    
AS
INSERT INTO dbo.Customer(
    IdentificationNumber,
    Name,
    LastName,
    Phone,
    State
)
VALUES(
    @IdentificationNumber,
    @Name,
    @LastName,
    @Phone BIGINT,
    1
)
GO