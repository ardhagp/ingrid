CREATE TABLE [dbo].[man_company] (
    [company_id]          CHAR (32)     NOT NULL,
    [company_code]        VARCHAR (10)  NOT NULL,
    [company_name]        VARCHAR (255) NULL,
    [company_searchterm1] VARCHAR (255) NULL,
    [company_searchterm2] VARCHAR (50)  NULL,
    [company_description] VARCHAR (255) NULL,
    CONSTRAINT [PK_man_company] PRIMARY KEY CLUSTERED ([company_id] ASC)
);

