CREATE TABLE [dbo].[log_storage] (
    [storage_id]          CHAR (32)     COLLATE Latin1_General_CI_AS NOT NULL,
    [storage_plant]       CHAR (32)     NULL,
    [storage_code]        VARCHAR (10)  NULL,
    [storage_description] VARCHAR (255) NULL,
    CONSTRAINT [PK_log_storage] PRIMARY KEY CLUSTERED ([storage_id] ASC),
    CONSTRAINT [FK_log_storage_log_plant] FOREIGN KEY ([storage_plant]) REFERENCES [dbo].[log_plant] ([plant_id]) ON UPDATE CASCADE
);

