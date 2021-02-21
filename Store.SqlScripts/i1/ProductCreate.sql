USE Store
GO

CREATE OR ALTER PROCEDURE dbo.ProductCreate
    (

    @Name VARCHAR(250),
    @UnitValue BIGINT
    )
    AS
    INSERT INTO dbo.Product(
    Name,
    [UnitValue],
    State
    )
    VALUES(
    @Name,
    @UnitValue,
    1
    )
    GO

