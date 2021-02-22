USE Store


IF NOT EXISTS (
    SELECT *
    FROM sys.objects
    WHERE object_id = OBJECT_ID(N'dbo.Customer')

)
BEGIN

CREATE TABLE dbo.Customer(
    Id INT IDENTITY(1,1) NOT NULL,
    IdentificationNumber BIGINT NOT NULL PRIMARY KEY,
    [Name] VARCHAR(250) NOT NULL,
    LastName VARCHAR(250) NOT NULL,
    Phone BIGINT,
    State BIT NOT NULL
);

END