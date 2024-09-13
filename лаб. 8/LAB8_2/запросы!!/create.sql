create database lab8oop;

use lab8oop

CREATE TABLE [dbo].[Processor] (
                [id] INT IDENTITY (1, 1) NOT NULL,
                [proizvoditel] NVARCHAR (50) NOT NULL,
                [seria] NCHAR (15) NOT NULL,
                [model] NVARCHAR (50) NOT NULL,
                [kolvoyader] INT NOT NULL,
                [chastota] INT NOT NULL, 
                [maxchastota] INT NOT NULL,
                [razrarhitect] INT NOT NULL, 
                [razmerkesha] NCHAR (15) NOT NULL,
                [ImageData] NVARCHAR(255) NULL,
                CONSTRAINT [PK__Owners__3214EC071237FB30] PRIMARY KEY CLUSTERED ([Id] ASC)
            );

drop table Processor

CREATE TABLE [dbo].[Computer] (
            [id] INT IDENTITY (11000, 1) NOT NULL,
            [ownerId] INT NOT NULL,
            [type] NVARCHAR (50) NOT NULL,
            [videocard] NVARCHAR (50) NOT NULL,
            [sizeozy] INT NULL,
            [typeozy] NVARCHAR (50) NOT NULL,
            [sizedisk] INT NULL,
            [typedisk] NVARCHAR (50) NOT NULL,
            [date] DATETIME NOT NULL,
            CONSTRAINT [PK__Account__3214EC071237FB30] PRIMARY KEY CLUSTERED ([Id] ASC),
            CONSTRAINT [FK__Account__OwnerId__267ABA7A] FOREIGN KEY ([OwnerId]) REFERENCES [dbo].[Processor] ([Id])
        );

drop table Computer

SELECT TOP 1 id
FROM Computer
ORDER BY id DESC;