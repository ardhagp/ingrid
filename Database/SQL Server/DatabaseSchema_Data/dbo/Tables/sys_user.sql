CREATE TABLE [dbo].[sys_user] (
    [user_id]          CHAR (32)     NOT NULL,
    [user_employee]    CHAR (32)     NULL,
    [user_username]    VARCHAR (10)  NULL,
    [user_password]    VARCHAR (255) NULL,
    [user_datecreated] DATETIME      NULL,
    [user_lastlogin]   DATETIME      NULL,
    [user_locked]      BIT           NULL,
    [user_root]        BIT           NULL,
    CONSTRAINT [PK_sys_user] PRIMARY KEY CLUSTERED ([user_id] ASC),
    CONSTRAINT [FK_sys_user_man_employee] FOREIGN KEY ([user_employee]) REFERENCES [dbo].[man_employee] ([employee_id]) ON DELETE CASCADE ON UPDATE CASCADE
);


GO
ADD SENSITIVITY CLASSIFICATION TO
    [dbo].[sys_user].[user_username]
    WITH (LABEL = 'Confidential', LABEL_ID = '331F0B13-76B5-2F1B-A77B-DEF5A73C73C2', INFORMATION_TYPE = 'Credentials', INFORMATION_TYPE_ID = 'C64ABA7B-3A3E-95B6-535D-3BC535DA5A59');


GO
ADD SENSITIVITY CLASSIFICATION TO
    [dbo].[sys_user].[user_password]
    WITH (LABEL = 'Confidential', LABEL_ID = '331F0B13-76B5-2F1B-A77B-DEF5A73C73C2', INFORMATION_TYPE = 'Credentials', INFORMATION_TYPE_ID = 'C64ABA7B-3A3E-95B6-535D-3BC535DA5A59');


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_name', @value = N'Confidential', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'sys_user', @level2type = N'COLUMN', @level2name = N'user_password';


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_id', @value = N'331F0B13-76B5-2F1B-A77B-DEF5A73C73C2', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'sys_user', @level2type = N'COLUMN', @level2name = N'user_password';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_name', @value = N'Credentials', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'sys_user', @level2type = N'COLUMN', @level2name = N'user_password';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_id', @value = N'C64ABA7B-3A3E-95B6-535D-3BC535DA5A59', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'sys_user', @level2type = N'COLUMN', @level2name = N'user_password';


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_name', @value = N'Confidential', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'sys_user', @level2type = N'COLUMN', @level2name = N'user_username';


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_id', @value = N'331F0B13-76B5-2F1B-A77B-DEF5A73C73C2', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'sys_user', @level2type = N'COLUMN', @level2name = N'user_username';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_name', @value = N'Credentials', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'sys_user', @level2type = N'COLUMN', @level2name = N'user_username';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_id', @value = N'C64ABA7B-3A3E-95B6-535D-3BC535DA5A59', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'sys_user', @level2type = N'COLUMN', @level2name = N'user_username';

