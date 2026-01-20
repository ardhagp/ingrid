CREATE TABLE [dbo].[sys_useraccess] (
    [useraccess_id]      CHAR (32) NOT NULL,
    [useraccess_user]    CHAR (32) NULL,
    [useraccess_module]  CHAR (32) NULL,
    [useraccess_view]    BIT       NULL,
    [useraccess_add]     BIT       NULL,
    [useraccess_edit]    BIT       NULL,
    [useraccess_delete]  BIT       NULL,
    [useraccess_reports] BIT       CONSTRAINT [DF_[sys]]useraccess_useraccess_special] DEFAULT ('false') NULL,
    CONSTRAINT [PK_sys_useraccess] PRIMARY KEY CLUSTERED ([useraccess_id] ASC),
    CONSTRAINT [FK_sys_useraccess_sys_module] FOREIGN KEY ([useraccess_module]) REFERENCES [dbo].[sys_module] ([module_id]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_sys_useraccess_sys_user] FOREIGN KEY ([useraccess_user]) REFERENCES [dbo].[sys_user] ([user_id]) ON DELETE CASCADE ON UPDATE CASCADE
);


GO
ADD SENSITIVITY CLASSIFICATION TO
    [dbo].[sys_useraccess].[useraccess_id]
    WITH (LABEL = 'Confidential', LABEL_ID = '331F0B13-76B5-2F1B-A77B-DEF5A73C73C2', INFORMATION_TYPE = 'Credentials', INFORMATION_TYPE_ID = 'C64ABA7B-3A3E-95B6-535D-3BC535DA5A59');


GO
ADD SENSITIVITY CLASSIFICATION TO
    [dbo].[sys_useraccess].[useraccess_user]
    WITH (LABEL = 'Confidential', LABEL_ID = '331F0B13-76B5-2F1B-A77B-DEF5A73C73C2', INFORMATION_TYPE = 'Credentials', INFORMATION_TYPE_ID = 'C64ABA7B-3A3E-95B6-535D-3BC535DA5A59');


GO
ADD SENSITIVITY CLASSIFICATION TO
    [dbo].[sys_useraccess].[useraccess_module]
    WITH (LABEL = 'Confidential', LABEL_ID = '331F0B13-76B5-2F1B-A77B-DEF5A73C73C2', INFORMATION_TYPE = 'Credentials', INFORMATION_TYPE_ID = 'C64ABA7B-3A3E-95B6-535D-3BC535DA5A59');


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Allow user to modify / delete another user entry.', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'sys_useraccess', @level2type = N'COLUMN', @level2name = N'useraccess_reports';


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_name', @value = N'Confidential', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'sys_useraccess', @level2type = N'COLUMN', @level2name = N'useraccess_module';


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_id', @value = N'331F0B13-76B5-2F1B-A77B-DEF5A73C73C2', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'sys_useraccess', @level2type = N'COLUMN', @level2name = N'useraccess_module';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_name', @value = N'Credentials', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'sys_useraccess', @level2type = N'COLUMN', @level2name = N'useraccess_module';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_id', @value = N'C64ABA7B-3A3E-95B6-535D-3BC535DA5A59', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'sys_useraccess', @level2type = N'COLUMN', @level2name = N'useraccess_module';


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_name', @value = N'Confidential', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'sys_useraccess', @level2type = N'COLUMN', @level2name = N'useraccess_user';


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_id', @value = N'331F0B13-76B5-2F1B-A77B-DEF5A73C73C2', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'sys_useraccess', @level2type = N'COLUMN', @level2name = N'useraccess_user';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_name', @value = N'Credentials', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'sys_useraccess', @level2type = N'COLUMN', @level2name = N'useraccess_user';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_id', @value = N'C64ABA7B-3A3E-95B6-535D-3BC535DA5A59', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'sys_useraccess', @level2type = N'COLUMN', @level2name = N'useraccess_user';


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_name', @value = N'Confidential', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'sys_useraccess', @level2type = N'COLUMN', @level2name = N'useraccess_id';


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_id', @value = N'331F0B13-76B5-2F1B-A77B-DEF5A73C73C2', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'sys_useraccess', @level2type = N'COLUMN', @level2name = N'useraccess_id';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_name', @value = N'Credentials', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'sys_useraccess', @level2type = N'COLUMN', @level2name = N'useraccess_id';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_id', @value = N'C64ABA7B-3A3E-95B6-535D-3BC535DA5A59', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'sys_useraccess', @level2type = N'COLUMN', @level2name = N'useraccess_id';

