CREATE TABLE [dbo].[Event] (
    [Id]            INT        IDENTITY (1, 1) NOT NULL,
    [EventName]    NCHAR (20) NOT NULL,
    [Category]     NCHAR (20) NOT NULL,
    [Team] NCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

