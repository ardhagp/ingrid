CREATE TABLE [dbo].[cus_todosworker] (
    [todosworker_id]       CHAR (32) NOT NULL,
    [todosworker_todos]    CHAR (32) NULL,
    [todosworker_employee] CHAR (32) NULL,
    CONSTRAINT [PK_[cus]]todosworker] PRIMARY KEY CLUSTERED ([todosworker_id] ASC),
    CONSTRAINT [FK_cus_todosworker_cus_todos] FOREIGN KEY ([todosworker_todos]) REFERENCES [dbo].[cus_todos] ([todos_id]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_cus_todosworker_man_employee] FOREIGN KEY ([todosworker_employee]) REFERENCES [dbo].[man_employee] ([employee_id]) ON DELETE CASCADE ON UPDATE CASCADE
);

