CREATE TABLE [dbo].[doc_areaaffected] (
    [areaaffected_id]    CHAR (32)     NOT NULL,
    [areaaffected_order] INT           NULL,
    [areaaffected_name]  VARCHAR (255) NULL,
    CONSTRAINT [PK_doc_areaafected] PRIMARY KEY CLUSTERED ([areaaffected_id] ASC)
);

