CREATE TABLE [dbo].[sys_chat] (
    [chat_id]          CHAR (32)     NOT NULL,
    [chat_createddate] DATETIME      NULL,
    [chat_isgroup]     BIT           NULL,
    [chat_groupname]   VARCHAR (255) NULL,
    CONSTRAINT [PK_[sys]]chat] PRIMARY KEY CLUSTERED ([chat_id] ASC)
);

