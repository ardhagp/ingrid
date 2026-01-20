CREATE TABLE [dbo].sto_file (
    [file_id]           CHAR (32)       NOT NULL,
    [file_parent]       CHAR (32)       NULL,
    [file_filename]     VARCHAR (255)   CONSTRAINT [DF_[sto]]file_file_filename] DEFAULT ('-') NULL,
    [file_filetype]     VARCHAR (5)     NULL,
    [file_content]      VARBINARY (MAX) NULL,
    [file_content_size] AS              (datalength([file_content])/(1024)),
    [file_tag]          VARCHAR (MAX)   NULL,
    [file_datetime]     DATETIME        NULL,
    [file_attribute]    VARCHAR (MAX)   NULL,
    [file_score]        INT             CONSTRAINT [DF_[sto]]file_file_score] DEFAULT ((0)) NULL,
    [file_uploader]     CHAR (32)       NULL,
    [file_parentdate]   DATE            NULL,
    CONSTRAINT [PK_[sto]]file] PRIMARY KEY CLUSTERED ([file_id] ASC)
);




GO
CREATE NONCLUSTERED INDEX [IX_[sto]]file]
    ON [dbo].sto_file([file_filename] ASC);

