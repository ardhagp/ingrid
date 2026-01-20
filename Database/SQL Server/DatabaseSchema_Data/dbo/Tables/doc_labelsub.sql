CREATE TABLE [dbo].[doc_labelsub] (
    [labelsub_id]      INT IDENTITY (1, 1) NOT NULL,
    [labelsub_labelid] INT NULL,
    [labelsub_itemid]  INT NULL,
    CONSTRAINT [PK_doc_labelsub] PRIMARY KEY CLUSTERED ([labelsub_id] ASC),
    CONSTRAINT [FK_labelsub_label] FOREIGN KEY ([labelsub_labelid]) REFERENCES [dbo].[doc_label] ([label_id]) ON UPDATE CASCADE
);

