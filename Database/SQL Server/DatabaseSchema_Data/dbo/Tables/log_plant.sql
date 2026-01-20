CREATE TABLE [dbo].[log_plant] (
    [plant_id]          CHAR (32)     NOT NULL,
    [plant_company]     CHAR (32)     NULL,
    [plant_code]        VARCHAR (10)  NULL,
    [plant_searchterm1] VARCHAR (255) NULL,
    [plant_searchterm2] VARCHAR (255) NULL,
    [plant_postalcode]  CHAR (6)      NULL,
    [plant_city]        VARCHAR (255) NULL,
    [plant_name2]       VARCHAR (255) NULL,
    [plant_name]        VARCHAR (255) NULL,
    [plant_version]     VARCHAR (255) NULL,
    [plant_description] VARCHAR (255) NULL,
    CONSTRAINT [PK_log_plant] PRIMARY KEY CLUSTERED ([plant_id] ASC),
    CONSTRAINT [FK_log_plant_man_company] FOREIGN KEY ([plant_company]) REFERENCES [dbo].[man_company] ([company_id]) ON UPDATE CASCADE
);


GO
ADD SENSITIVITY CLASSIFICATION TO
    [dbo].[log_plant].[plant_postalcode]
    WITH (LABEL = 'Confidential - GDPR', LABEL_ID = '989ADC05-3F3F-0588-A635-F475B994915B', INFORMATION_TYPE = 'Contact Info', INFORMATION_TYPE_ID = '5C503E21-22C6-81FA-620B-F369B8EC38D1');


GO
ADD SENSITIVITY CLASSIFICATION TO
    [dbo].[log_plant].[plant_city]
    WITH (LABEL = 'Confidential - GDPR', LABEL_ID = '989ADC05-3F3F-0588-A635-F475B994915B', INFORMATION_TYPE = 'Contact Info', INFORMATION_TYPE_ID = '5C503E21-22C6-81FA-620B-F369B8EC38D1');


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_name', @value = N'Confidential - GDPR', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'log_plant', @level2type = N'COLUMN', @level2name = N'plant_city';


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_id', @value = N'989ADC05-3F3F-0588-A635-F475B994915B', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'log_plant', @level2type = N'COLUMN', @level2name = N'plant_city';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_name', @value = N'Contact Info', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'log_plant', @level2type = N'COLUMN', @level2name = N'plant_city';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_id', @value = N'5C503E21-22C6-81FA-620B-F369B8EC38D1', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'log_plant', @level2type = N'COLUMN', @level2name = N'plant_city';


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_name', @value = N'Confidential - GDPR', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'log_plant', @level2type = N'COLUMN', @level2name = N'plant_postalcode';


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_id', @value = N'989ADC05-3F3F-0588-A635-F475B994915B', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'log_plant', @level2type = N'COLUMN', @level2name = N'plant_postalcode';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_name', @value = N'Contact Info', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'log_plant', @level2type = N'COLUMN', @level2name = N'plant_postalcode';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_id', @value = N'5C503E21-22C6-81FA-620B-F369B8EC38D1', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'log_plant', @level2type = N'COLUMN', @level2name = N'plant_postalcode';

