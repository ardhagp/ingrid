CREATE TABLE [dbo].[man_employee] (
    [employee_id]           CHAR (32)     NOT NULL,
    [employee_personalid]   VARCHAR (16)  NULL,
    [employee_fullname]     VARCHAR (255) NULL,
    [employee_lastname]     VARCHAR (50)  NULL,
    [employee_firstname]    VARCHAR (50)  NULL,
    [employee_birthdate]    DATE          NULL,
    [employee_birthplace]   VARCHAR (255) NULL,
    [employee_gender]       VARCHAR (6)   CONSTRAINT [DF_[man]]employee_employee_gender] DEFAULT ('MALE') NULL,
    [employee_address]      VARCHAR (MAX) NULL,
    [employee_number]       VARCHAR (20)  NULL,
    [employee_nickname]     VARCHAR (5)   NULL,
    [employee_position]     CHAR (32)     NULL,
    [employee_grade]        INT           NULL,
    [employee_contracttype] CHAR (32)     NULL,
    [employee_active]       BIT           NULL,
    CONSTRAINT [PK_man_employee] PRIMARY KEY CLUSTERED ([employee_id] ASC),
    CONSTRAINT [FK_man_employee_man_contracttype] FOREIGN KEY ([employee_contracttype]) REFERENCES [dbo].[man_contracttype] ([contracttype_id]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_man_employee_man_position] FOREIGN KEY ([employee_position]) REFERENCES [dbo].[man_position] ([position_id]) ON DELETE CASCADE ON UPDATE CASCADE
);


GO
ADD SENSITIVITY CLASSIFICATION TO
    [dbo].[man_employee].[employee_lastname]
    WITH (LABEL = 'Confidential - GDPR', LABEL_ID = '989ADC05-3F3F-0588-A635-F475B994915B', INFORMATION_TYPE = 'Name', INFORMATION_TYPE_ID = '57845286-7598-22F5-9659-15B24AEB125E');


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_name', @value = N'Confidential - GDPR', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'man_employee', @level2type = N'COLUMN', @level2name = N'employee_lastname';


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_id', @value = N'989ADC05-3F3F-0588-A635-F475B994915B', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'man_employee', @level2type = N'COLUMN', @level2name = N'employee_lastname';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_name', @value = N'Name', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'man_employee', @level2type = N'COLUMN', @level2name = N'employee_lastname';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_id', @value = N'57845286-7598-22F5-9659-15B24AEB125E', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'man_employee', @level2type = N'COLUMN', @level2name = N'employee_lastname';

