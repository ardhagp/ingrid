CREATE TABLE [dbo].[cus_todosphoto] (
    [todosphoto_id]         CHAR (32)     NOT NULL,
    [todosphoto_date]       DATETIME      NULL,
    [todosphoto_todos]      CHAR (32)     NULL,
    [todosphoto_beforeid]   CHAR (32)     NULL,
    [todosphoto_beforetext] VARCHAR (MAX) NULL,
    [todosphoto_afterid]    CHAR (32)     NULL,
    [todosphoto_aftertext]  VARCHAR (MAX) NULL,
    CONSTRAINT [PK_[cus]]todosphoto] PRIMARY KEY CLUSTERED ([todosphoto_id] ASC),
    CONSTRAINT [FK_cus_todosphoto__cus_todos] FOREIGN KEY ([todosphoto_todos]) REFERENCES [dbo].[cus_todos] ([todos_id]) ON DELETE CASCADE ON UPDATE CASCADE
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Store To Do photo progress', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'cus_todosphoto';

