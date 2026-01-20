CREATE TABLE [dbo].[doc_manifest] (
    [manifest_id]                CHAR (32)     NOT NULL,
    [manifest_manifestdirection] CHAR (32)     NULL,
    [manifest_destination]       INT           NULL,
    [manifest_vessel]            INT           NULL,
    [manifest_number]            VARCHAR (255) COLLATE Latin1_General_CI_AI NULL,
    [manifest_date]              DATE          NULL,
    CONSTRAINT [PK_doc_manifest] PRIMARY KEY CLUSTERED ([manifest_id] ASC),
    CONSTRAINT [FK_manifest_manifest_direction] FOREIGN KEY ([manifest_manifestdirection]) REFERENCES [dbo].[doc_manifestdirection] ([manifestdirection_id]) ON UPDATE CASCADE
);

