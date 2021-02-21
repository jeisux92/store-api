USE Store

IF NOT EXISTS (
        SELECT *
        FROM sys.objects
        WHERE object_id = OBJECT_ID(N'dbo.Product')

    )
    BEGIN

        CREATE TABLE dbo.Product(
                                    Id INT IDENTITY(1,1) NOT NULL,
                                    [Name] VARCHAR(250) NOT NULL,
                                    UnitValue BIGINT,
                                    State BIT NOT NULL
                                        CONSTRAINT PK_Id_Name PRIMARY KEY NONCLUSTERED ([Name], [Id])
        );

    END

