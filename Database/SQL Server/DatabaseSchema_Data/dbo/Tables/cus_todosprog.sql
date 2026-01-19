CREATE TABLE [dbo].[cus_todosprog] (
    [todosprog_id]       CHAR (32)     NOT NULL,
    [todosprog_date]     DATETIME      NULL,
    [todosprog_todos]    CHAR (32)     NULL,
    [todosprog_employee] CHAR (32)     NULL,
    [todosprog_oldvalue] INT           NULL,
    [todosprog_newvalue] INT           NULL,
    [todosprog_text]     VARCHAR (MAX) NULL,
    CONSTRAINT [PK_[cus]]todosprog] PRIMARY KEY CLUSTERED ([todosprog_id] ASC),
    CONSTRAINT [FK_cus_todosprog_cus_todos] FOREIGN KEY ([todosprog_todos]) REFERENCES [dbo].[cus_todos] ([todos_id]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_cus_todosprog_man_employee] FOREIGN KEY ([todosprog_employee]) REFERENCES [dbo].[man_employee] ([employee_id]) ON DELETE CASCADE ON UPDATE CASCADE
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Change To Do progress value', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'cus_todosprog';

