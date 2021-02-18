USE Store
GO


CREATE OR ALTER PROCEDURE dbo.CustomerGetById
    @Id INT
    AS
        SELECT * FROM [dbo].[Customer]
        WHERE Id = @Id
    GO


