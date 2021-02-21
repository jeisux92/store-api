USE Store
GO


CREATE OR ALTER PROCEDURE dbo.CustomerCreate
    (
    @IdentificationNumber BIGINT,
    @Name VARCHAR(250),
    @LastName VARCHAR(250),
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
    @Phone,
    1
    )
    GO