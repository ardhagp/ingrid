CREATE TABLE [dbo].[doc_employeeactivity] (
    [employeeactivity_id]           CHAR (32)     NOT NULL,
    [employeeactivity_employee]     CHAR (32)     NULL,
    [employeeactivity_areaaffected] CHAR (32)     NULL,
    [employeeactivity_template]     CHAR (32)     NULL,
    [employeeactivity_datetime]     DATE          NULL,
    [employeeactivity_time]         TIME (7)      NULL,
    [employeeactivity_datetime_end] DATE          NULL,
    [employeeactivity_time_end]     TIME (7)      NULL,
    [employeeactivity_description]  VARCHAR (MAX) NULL,
    [employeeactivity_feedback]     VARCHAR (MAX) NULL,
    [employeeactivity_createon]     DATETIME      NULL,
    [employeeactivity_updateon]     DATETIME      NULL,
    [employeeactivity_lastupdate]   CHAR (32)     NULL,
    CONSTRAINT [PK_doc_employeeactivity] PRIMARY KEY CLUSTERED ([employeeactivity_id] ASC),
    CONSTRAINT [FK_doc_employeeactivity_man_employee] FOREIGN KEY ([employeeactivity_employee]) REFERENCES [dbo].[man_employee] ([employee_id]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_employeeactivity_areaaffected] FOREIGN KEY ([employeeactivity_areaaffected]) REFERENCES [dbo].[doc_areaaffected] ([areaaffected_id]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_employeeactivity_template] FOREIGN KEY ([employeeactivity_template]) REFERENCES [dbo].[doc_template] ([template_id]) ON DELETE CASCADE ON UPDATE CASCADE
);

