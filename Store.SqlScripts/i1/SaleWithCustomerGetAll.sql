	USE Store
	GO


	CREATE OR ALTER PROCEDURE dbo.SaleWithCustomerGetAll
		AS
	SELECT CustomerId,[Name] + ' ' + LastName AS CustomerName,CreatedOn,Total FROM [dbo].[Sale] S
	JOIN Customer C ON C.IdentificationNumber = S.CustomerId
	ORDER BY CreatedOn DESC 
	GO
