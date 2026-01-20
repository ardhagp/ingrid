CREATE TABLE [dbo].[sys_settings] (
    [settings_id]                BIGINT          IDENTITY (1, 1) NOT NULL,
    [settings_showprofile]       SMALLINT        CONSTRAINT [DF_[sys]]settings_settings_showprofile] DEFAULT ('false') NULL,
    [settings_showstorage]       SMALLINT        CONSTRAINT [DF_[sys]]settings_settings_showstorage] DEFAULT ('false') NULL,
    [settings_showwatermark]     SMALLINT        CONSTRAINT [DF_[sys]]settings_settings_showwatermark] DEFAULT ('false') NULL,
    [settings_showrunningtext]   SMALLINT        CONSTRAINT [DF_[sys]]settings_settings_showrunningtext] DEFAULT ('false') NULL,
    [settings_uploadphoto]       DECIMAL (18, 2) NULL,
    [settings_uploadpdf]         DECIMAL (18, 2) NULL,
    [settings_textmark]          VARCHAR (50)    NULL,
    [settings_textmarklength]    AS              (len([settings_textmark])),
    [settings_minpasswordlength] SMALLINT        NULL,
    CONSTRAINT [PK_[sys]]settings] PRIMARY KEY CLUSTERED ([settings_id] ASC)
);


GO
ADD SENSITIVITY CLASSIFICATION TO
    [dbo].[sys_settings].[settings_minpasswordlength]
    WITH (LABEL = 'Confidential', LABEL_ID = '331F0B13-76B5-2F1B-A77B-DEF5A73C73C2', INFORMATION_TYPE = 'Credentials', INFORMATION_TYPE_ID = 'C64ABA7B-3A3E-95B6-535D-3BC535DA5A59');


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_name', @value = N'Confidential', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'sys_settings', @level2type = N'COLUMN', @level2name = N'settings_minpasswordlength';


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_id', @value = N'331F0B13-76B5-2F1B-A77B-DEF5A73C73C2', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'sys_settings', @level2type = N'COLUMN', @level2name = N'settings_minpasswordlength';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_name', @value = N'Credentials', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'sys_settings', @level2type = N'COLUMN', @level2name = N'settings_minpasswordlength';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_id', @value = N'C64ABA7B-3A3E-95B6-535D-3BC535DA5A59', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'sys_settings', @level2type = N'COLUMN', @level2name = N'settings_minpasswordlength';

