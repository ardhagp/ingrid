CREATE TABLE [dbo].[ac_book] (
    [book_id]          CHAR (32)    NOT NULL,
    [book_company]     CHAR (32)    NULL,
    [book_code]        VARCHAR (10) NULL,
    [book_bookname]    VARCHAR (50) NULL,
    [book_datecreated] DATETIME     NULL,
    CONSTRAINT [PK_ac_book] PRIMARY KEY CLUSTERED ([book_id] ASC),
    CONSTRAINT [FK_ac_book_man_company] FOREIGN KEY ([book_company]) REFERENCES [dbo].[man_company] ([company_id]) ON DELETE CASCADE ON UPDATE CASCADE
);

