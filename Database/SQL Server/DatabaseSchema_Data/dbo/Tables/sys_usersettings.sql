CREATE TABLE [dbo].[sys_usersettings] (
    [usersettings_id]   CHAR (32) NOT NULL,
    [usersettings_user] CHAR (32) NULL,
    CONSTRAINT [PK_[sys]]usersettings] PRIMARY KEY CLUSTERED ([usersettings_id] ASC),
    CONSTRAINT [FK_usersettings_user] FOREIGN KEY ([usersettings_user]) REFERENCES [dbo].[sys_user] ([user_id]) ON DELETE CASCADE ON UPDATE CASCADE
);

