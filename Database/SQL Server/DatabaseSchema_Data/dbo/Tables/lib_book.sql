CREATE TABLE [dbo].[lib_book] (
    [book_id]         CHAR (32)     NOT NULL,
    [book_identifier] VARCHAR (150) NULL,
    [book_title]      VARCHAR (255) NULL,
    [book_subtitle]   VARCHAR (255) NULL,
    [book_synopsis]   VARCHAR (MAX) NULL,
    [book_totalpages] INT           NULL,
    [book_author]     VARCHAR (MAX) NULL,
    [book_publisher]  VARCHAR (MAX) NULL,
    [book_keyword]    VARCHAR (255) NULL,
    CONSTRAINT [PK_[kb]]book] PRIMARY KEY CLUSTERED ([book_id] ASC)
);

