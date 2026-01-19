CREATE TABLE [dbo].[sys_notification] (
    [notification_id]       BIGINT    IDENTITY (1, 1) NOT NULL,
    [notification_datetime] DATETIME  NULL,
    [notification_employee] CHAR (32) NULL,
    [notification_isread]   BIT       NULL,
    [notification_message]  TEXT      NULL,
    CONSTRAINT [PK_sys_notification] PRIMARY KEY CLUSTERED ([notification_id] ASC)
);

