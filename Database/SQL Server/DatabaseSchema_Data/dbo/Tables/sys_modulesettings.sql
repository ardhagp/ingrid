CREATE TABLE [dbo].[sys_modulesettings] (
    [modulesettings_id]        CHAR (32)     NOT NULL,
    [modulesettings_module]    CHAR (32)     NULL,
    [modulesettings_user]      CHAR (32)     NULL,
    [modulesettings_attribute] VARCHAR (255) NULL,
    [modulesettings_value]     VARCHAR (255) NULL,
    CONSTRAINT [PK_sys_modulesettings] PRIMARY KEY CLUSTERED ([modulesettings_id] ASC)
);

