 CREATE TABLE [dbo].[tWyniki]
(Id INT IDENTITY(1, 1) NOT NULL
,CreatDate DATETIME DEFAULT(GETDATE()) NOT NULL
,Score BIGINT NOT NULL
,UserName VARCHAR(254) NOT NULL
,CONSTRAINT [PK_tWyniki] PRIMARY KEY CLUSTERED ([Id] ASC ) ON [PRIMARY]
)
