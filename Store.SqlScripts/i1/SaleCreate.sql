USE Store
GO

CREATE OR ALTER PROCEDURE dbo.SaleCreate
    (

    @CustomerId BIGINT,
    @Total BIGINT
    )
    AS
    INSERT INTO dbo.Sale(
    CustomerId,
    Total
    )
    VALUES(
    @CustomerId,
    @Total
    )
    GO

