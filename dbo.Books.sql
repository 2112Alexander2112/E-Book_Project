CREATE TABLE [dbo].[Books] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [GenreId]     INT             NOT NULL,
    [CategoryId]  INT             NOT NULL,
    [AuthorId]    INT             NOT NULL,
    [BookName]    NVARCHAR (MAX)  NULL,
    [AlterName]   NVARCHAR (MAX)  NULL,
    [Published]   DATETIME        NOT NULL,
    [PublisherId] INT             NOT NULL,
    [BookInfoId]  INT             NOT NULL,
    [Price]       DECIMAL (18, 2) NOT NULL,
    [IconPath]    NVARCHAR (MAX)  NULL,
    --[Book_Id]     INT             NULL,
    CONSTRAINT [PK_dbo.Books] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.Books_dbo.Authors_AuthorId] FOREIGN KEY ([AuthorId]) REFERENCES [dbo].[Authors] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.Books_dbo.BookInfoes_BookInfoId] FOREIGN KEY ([BookInfoId]) REFERENCES [dbo].[BookInfoes] ([Id]) ON DELETE CASCADE,
    --CONSTRAINT [FK_dbo.Books_dbo.Books_Book_Id] FOREIGN KEY ([Book_Id]) REFERENCES [dbo].[Books] ([Id]),
    CONSTRAINT [FK_dbo.Books_dbo.Categories_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Categories] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.Books_dbo.Genres_GenreId] FOREIGN KEY ([GenreId]) REFERENCES [dbo].[Genres] ([Id]),
    CONSTRAINT [FK_dbo.Books_dbo.Publishers_PublisherId] FOREIGN KEY ([PublisherId]) REFERENCES [dbo].[Publishers] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_GenreId]
    ON [dbo].[Books]([GenreId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CategoryId]
    ON [dbo].[Books]([CategoryId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_AuthorId]
    ON [dbo].[Books]([AuthorId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_PublisherId]
    ON [dbo].[Books]([PublisherId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_BookInfoId]
    ON [dbo].[Books]([BookInfoId] ASC);


GO
--CREATE NONCLUSTERED INDEX [IX_Book_Id]
--   ON [dbo].[Books]([Book_Id] ASC);

