CREATE TABLE [dbo].[doc_manifesttype] (
    [manifesttype_code]        VARCHAR (3)   COLLATE Latin1_General_CI_AI NOT NULL,
    [manifesttype_name]        VARCHAR (50)  COLLATE Latin1_General_CI_AI NULL,
    [manifesttype_description] VARCHAR (255) COLLATE Latin1_General_CI_AI NULL,
    CONSTRAINT [PK_doc_manifesttype] PRIMARY KEY CLUSTERED ([manifesttype_code] ASC)
);

