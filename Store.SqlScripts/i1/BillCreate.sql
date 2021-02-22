USE Store
GO

CREATE OR ALTER PROCEDURE dbo.BillCreate
    (
    @SaleId INT,
    @ProductId INT,
	@Quantity BIGINT
    )
    AS
    INSERT INTO dbo.Bill(
    SaleId,
    ProductId,
	Quantity
    )
    VALUES(
    @SaleId,
    @ProductId,
	@Quantity
    )
    GO

