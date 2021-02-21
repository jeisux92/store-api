USE Store
GO


CREATE OR ALTER PROCEDURE dbo.ProductGetById
    @Id INT
    AS
SELECT * FROM [dbo].[Product]
WHERE Id = @Id
    GO


