CREATE TABLE [dbo].[cus_task] (
    [task_id]              CHAR (32)     NOT NULL,
    [task_directive]       VARCHAR (255) NULL,
    [task_priority]        CHAR (32)     NULL,
    [task_duedate]         DATE          NULL,
    [task_description]     VARCHAR (MAX) NULL,
    [task_createdby]       CHAR (32)     NULL,
    [task_appointedperson] CHAR (32)     NULL,
    [task_completedby]     CHAR (32)     NULL,
    [task_statevalue]      INT           NULL,
    [task_iscomplete]      BIT           NULL,
    [task_completedate]    DATE          NULL,
    CONSTRAINT [PK_cus]]handover] PRIMARY KEY CLUSTERED ([task_id] ASC),
    CONSTRAINT [FK_handover_priority] FOREIGN KEY ([task_priority]) REFERENCES [dbo].[sys_priority] ([priority_id]) ON DELETE CASCADE ON UPDATE CASCADE
);

