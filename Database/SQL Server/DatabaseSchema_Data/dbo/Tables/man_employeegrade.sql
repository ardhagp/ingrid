CREATE TABLE [dbo].[man_employeegrade] (
    [employeegrade_id]          CHAR (32)     NOT NULL,
    [employeegrade_position]    CHAR (32)     NULL,
    [employeegrade_code]        VARCHAR (5)   NULL,
    [employeegrade_name]        VARCHAR (50)  NULL,
    [employeegrade_description] VARCHAR (255) NULL,
    CONSTRAINT [PK_man_employeegrade] PRIMARY KEY CLUSTERED ([employeegrade_id] ASC),
    CONSTRAINT [FK_man_employeegrade_man_position] FOREIGN KEY ([employeegrade_position]) REFERENCES [dbo].[man_position] ([position_id]) ON DELETE CASCADE ON UPDATE CASCADE
);

