CREATE TABLE [dbo].[log_materialtype] (
    [materialtype_id]          CHAR (32)     NOT NULL,
    [materialtype_code]        VARCHAR (20)  NULL,
    [materialtype_description] VARCHAR (255) NULL,
    [materialtype_default]     BIT           CONSTRAINT [DF_[log]]materialtype_materialtype_default] DEFAULT ('False') NULL,
    CONSTRAINT [PK_log_materialtype] PRIMARY KEY CLUSTERED ([materialtype_id] ASC)
);

