CREATE TABLE [dbo].[doc_delivery] (
    [delivery_id]       BIGINT        IDENTITY (1, 1) NOT NULL,
    [delivery_vendorid] INT           NULL,
    [delivery_number]   VARCHAR (255) COLLATE Latin1_General_CI_AI NULL,
    [delivery_date]     DATE          NULL,
    [delivery_note]     VARCHAR (255) COLLATE Latin1_General_CI_AI NULL,
    CONSTRAINT [PK_doc_delivery] PRIMARY KEY CLUSTERED ([delivery_id] ASC)
);

