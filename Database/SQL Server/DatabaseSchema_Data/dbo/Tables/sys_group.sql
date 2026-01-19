CREATE TABLE [dbo].[sys_group] (
    [group_id]            INT IDENTITY (1, 1) NOT NULL,
    [group_module]        INT NULL,
    [group_employeegroup] INT NULL,
    [group_add]           BIT NULL,
    [group_edit]          BIT NULL,
    [group_delete]        BIT NULL,
    CONSTRAINT [PK_sys_group] PRIMARY KEY CLUSTERED ([group_id] ASC)
);

