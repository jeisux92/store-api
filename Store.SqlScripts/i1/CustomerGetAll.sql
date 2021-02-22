USE Store
GO


CREATE OR ALTER PROCEDURE dbo.CustomerGetAll
    AS
SELECT * FROM [dbo].[Customer]
WHERE [State] = 1
    GO


