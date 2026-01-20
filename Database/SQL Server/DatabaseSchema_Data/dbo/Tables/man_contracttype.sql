CREATE TABLE [dbo].[man_contracttype] (
    [contracttype_id]          CHAR (32)     NOT NULL,
    [contracttype_code]        VARCHAR (5)   NULL,
    [contracttype_name]        VARCHAR (50)  NULL,
    [contracttype_description] VARCHAR (255) NULL,
    CONSTRAINT [PK_man_contracttype] PRIMARY KEY CLUSTERED ([contracttype_id] ASC)
);

