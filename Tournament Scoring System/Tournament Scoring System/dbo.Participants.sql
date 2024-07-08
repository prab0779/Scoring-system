CREATE TABLE [dbo].[Participants] (
    [Id]             INT        IDENTITY (1, 1) NOT NULL,
    [FirstName]      NCHAR (20) NOT NULL,
    [LastName]       NCHAR (20) NOT NULL,
    [Team] NCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

