CREATE TABLE [dbo].[doc_manifestdirection] (
    [manifestdirection_id]   CHAR (32)    NOT NULL,
    [manifestdirection_code] VARCHAR (3)  COLLATE Latin1_General_CI_AI NULL,
    [manifestdirection_name] VARCHAR (50) COLLATE Latin1_General_CI_AI NULL,
    CONSTRAINT [PK_doc_manifestdirection] PRIMARY KEY CLUSTERED ([manifestdirection_id] ASC)
);

