CREATE TABLE [dbo].sto_filefeedback (
    [filefeedback_id]       BIGINT        IDENTITY (1, 1) NOT NULL,
    [filefeedback_datetime] DATETIME      NULL,
    [filefeedback_file]     CHAR (32)     NULL,
    [filefeedback_employee] CHAR (32)     NULL,
    [filefeedback_type]     VARCHAR (10)  NULL,
    [filefeedback_value]    INT           NULL,
    [filefeedback_text]     VARCHAR (MAX) NULL,
    CONSTRAINT [PK_[sto]]filefeedback_1] PRIMARY KEY CLUSTERED ([filefeedback_id] ASC),
    CONSTRAINT [FK_[sto]]filefeedback_[sto]]file] FOREIGN KEY ([filefeedback_file]) REFERENCES [dbo].sto_file ([file_id]) ON DELETE CASCADE ON UPDATE CASCADE
);

