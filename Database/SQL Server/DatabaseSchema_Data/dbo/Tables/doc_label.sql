CREATE TABLE [dbo].[doc_label] (
    [label_id]   INT           IDENTITY (1, 1) NOT NULL,
    [label_name] VARCHAR (255) COLLATE Latin1_General_CI_AI NULL,
    CONSTRAINT [PK_doc_label] PRIMARY KEY CLUSTERED ([label_id] ASC)
);

