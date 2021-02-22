USE Store
GO


CREATE OR ALTER PROCEDURE dbo.ProductGetAll
    AS
SELECT * FROM [dbo].[Product]
WHERE [State] = 1
    GO


