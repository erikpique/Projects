CREATE TABLE [dbo].[Anuncios] (
    [Id]      INT             NOT NULL,
    [Anuncio] VARCHAR(MAX) NOT NULL,
    [Autor]   VARCHAR (50)    NOT NULL,
    [Email]   VARCHAR (50)    NOT NULL,
    [Tipo]    INT             NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

