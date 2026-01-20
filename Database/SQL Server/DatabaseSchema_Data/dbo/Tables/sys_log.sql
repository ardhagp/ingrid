CREATE TABLE [dbo].[sys_log] (
    [log_id]      BIGINT        IDENTITY (1, 1) NOT NULL,
    [log_user]    CHAR (32)     NULL,
    [log_date]    DATETIME      NULL,
    [log_message] VARCHAR (MAX) NULL,
    [log_machine] VARCHAR (255) NULL,
    [log_os]      VARCHAR (255) NULL,
    [log_appver]  VARCHAR (255) NULL,
    [log_address] VARCHAR (12)  NULL,
    [log_mac]     VARCHAR (255) NULL,
    CONSTRAINT [PK_[sys]]log] PRIMARY KEY CLUSTERED ([log_id] ASC)
);


GO
ADD SENSITIVITY CLASSIFICATION TO
    [dbo].[sys_log].[log_address]
    WITH (LABEL = 'Highly Confidential', LABEL_ID = 'b82ce05b-60a9-4cf3-8a8a-d6a0bb76e903', INFORMATION_TYPE = 'Contact Info', INFORMATION_TYPE_ID = '5C503E21-22C6-81FA-620B-F369B8EC38D1');


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_name', @value = N'Highly Confidential', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'sys_log', @level2type = N'COLUMN', @level2name = N'log_address';


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_id', @value = N'b82ce05b-60a9-4cf3-8a8a-d6a0bb76e903', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'sys_log', @level2type = N'COLUMN', @level2name = N'log_address';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_name', @value = N'Contact Info', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'sys_log', @level2type = N'COLUMN', @level2name = N'log_address';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_id', @value = N'5C503E21-22C6-81FA-620B-F369B8EC38D1', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'sys_log', @level2type = N'COLUMN', @level2name = N'log_address';

