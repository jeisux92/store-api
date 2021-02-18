USE Store


IF NOT EXISTS (
    SELECT *
    FROM sys.objects
    WHERE object_id = OBJECT_ID(N'dbo.Customer')

)
BEGIN

CREATE TABLE dbo.Customer(
    Id INT IDENTITY(1,1) NOT NULL,
    IdentificationNumber BIGINT NOT NULL,
    [Name] VARCHAR(250) NOT NULL,
    LastName VARCHAR(250) NOT NULL,
    Phone BIGINT,
    State BIT NOT NULL,
    CONSTRAINT PK_Id_IdentificationNumber PRIMARY KEY NONCLUSTERED ([IdentificationNumber], [Id])
);

END