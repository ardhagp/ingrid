CREATE TABLE [dbo].[sys_priority] (
    [priority_id]          CHAR (32)    NOT NULL,
    [priority_module]      CHAR (32)    NULL,
    [priority_number]      INT          NULL,
    [priority_description] VARCHAR (50) COLLATE Latin1_General_CI_AI NULL,
    CONSTRAINT [PK_doc_priority] PRIMARY KEY CLUSTERED ([priority_id] ASC)
);

