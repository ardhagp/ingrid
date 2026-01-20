CREATE TABLE [dbo].[ext_vendor] (
    [vendor_id]                         CHAR (32)       COLLATE Latin1_General_CI_AI NOT NULL,
    [vendor_code]                       VARCHAR (50)    COLLATE Latin1_General_CI_AI NULL,
    [vendor_name]                       VARCHAR (255)   COLLATE Latin1_General_CI_AI NULL,
    [vendor_address]                    VARCHAR (255)   COLLATE Latin1_General_CI_AI NULL,
    [vendor_country]                    VARCHAR (10)    COLLATE Latin1_General_CI_AI NULL,
    [vendor_postalcode]                 VARCHAR (10)    COLLATE Latin1_General_CI_AI NULL,
    [vendor_city]                       VARCHAR (50)    COLLATE Latin1_General_CI_AI NULL,
    [vendoraccountgroup_id]             VARCHAR (255)   COLLATE Latin1_General_CI_AI NULL,
    [vendor_searchterm]                 VARCHAR (255)   COLLATE Latin1_General_CI_AI NULL,
    [vendor_centralprocessingblock]     VARCHAR (255)   COLLATE Latin1_General_CI_AI NULL,
    [vendor_blockfunction]              VARCHAR (255)   COLLATE Latin1_General_CI_AI NULL,
    [vendor_centraldeletionflag]        VARCHAR (255)   COLLATE Latin1_General_CI_AI NULL,
    [vendor_onetimeaccount]             VARCHAR (255)   COLLATE Latin1_General_CI_AI NULL,
    [vendor_termofpayment]              VARCHAR (255)   COLLATE Latin1_General_CI_AI NULL,
    [vendor_incoterms]                  VARCHAR (255)   COLLATE Latin1_General_CI_AI NULL,
    [vendor_incoterms2]                 VARCHAR (255)   COLLATE Latin1_General_CI_AI NULL,
    [vendor_purchasingblock]            VARCHAR (255)   COLLATE Latin1_General_CI_AI NULL,
    [vendor_deleteflagforpurchasingorg] VARCHAR (255)   COLLATE Latin1_General_CI_AI NULL,
    [vendor_minimumordervalue]          DECIMAL (18, 2) NULL,
    [vendor_ordercurrency]              VARCHAR (255)   COLLATE Latin1_General_CI_AI NULL,
    [vendor_salesperson]                VARCHAR (255)   COLLATE Latin1_General_CI_AI NULL,
    [vendor_telephone]                  VARCHAR (255)   COLLATE Latin1_General_CI_AI NULL,
    [vendor_purchasingorg]              VARCHAR (255)   COLLATE Latin1_General_CI_AI NULL,
    [vendor_numberofpurchasingorg]      VARCHAR (255)   COLLATE Latin1_General_CI_AI NULL,
    CONSTRAINT [PK_ext_vendor] PRIMARY KEY CLUSTERED ([vendor_id] ASC)
);


GO
ADD SENSITIVITY CLASSIFICATION TO
    [dbo].[ext_vendor].[vendor_address]
    WITH (LABEL = 'Confidential - GDPR', LABEL_ID = '989ADC05-3F3F-0588-A635-F475B994915B', INFORMATION_TYPE = 'Contact Info', INFORMATION_TYPE_ID = '5C503E21-22C6-81FA-620B-F369B8EC38D1');


GO
ADD SENSITIVITY CLASSIFICATION TO
    [dbo].[ext_vendor].[vendor_postalcode]
    WITH (LABEL = 'Confidential - GDPR', LABEL_ID = '989ADC05-3F3F-0588-A635-F475B994915B', INFORMATION_TYPE = 'Contact Info', INFORMATION_TYPE_ID = '5C503E21-22C6-81FA-620B-F369B8EC38D1');


GO
ADD SENSITIVITY CLASSIFICATION TO
    [dbo].[ext_vendor].[vendor_city]
    WITH (LABEL = 'Confidential - GDPR', LABEL_ID = '989ADC05-3F3F-0588-A635-F475B994915B', INFORMATION_TYPE = 'Contact Info', INFORMATION_TYPE_ID = '5C503E21-22C6-81FA-620B-F369B8EC38D1');


GO
ADD SENSITIVITY CLASSIFICATION TO
    [dbo].[ext_vendor].[vendoraccountgroup_id]
    WITH (LABEL = 'Confidential', LABEL_ID = '331F0B13-76B5-2F1B-A77B-DEF5A73C73C2', INFORMATION_TYPE = 'Financial', INFORMATION_TYPE_ID = 'C44193E1-0E58-4B2A-9001-F7D6E7BC1373');


GO
ADD SENSITIVITY CLASSIFICATION TO
    [dbo].[ext_vendor].[vendor_onetimeaccount]
    WITH (LABEL = 'Confidential', LABEL_ID = '331F0B13-76B5-2F1B-A77B-DEF5A73C73C2', INFORMATION_TYPE = 'Financial', INFORMATION_TYPE_ID = 'C44193E1-0E58-4B2A-9001-F7D6E7BC1373');


GO
ADD SENSITIVITY CLASSIFICATION TO
    [dbo].[ext_vendor].[vendor_termofpayment]
    WITH (LABEL = 'Confidential', LABEL_ID = '331F0B13-76B5-2F1B-A77B-DEF5A73C73C2', INFORMATION_TYPE = 'Credit Card', INFORMATION_TYPE_ID = 'D22FA6E9-5EE4-3BDE-4C2B-A409604C4646');


GO
ADD SENSITIVITY CLASSIFICATION TO
    [dbo].[ext_vendor].[vendor_ordercurrency]
    WITH (LABEL = 'Confidential', LABEL_ID = '331F0B13-76B5-2F1B-A77B-DEF5A73C73C2', INFORMATION_TYPE = 'Financial', INFORMATION_TYPE_ID = 'C44193E1-0E58-4B2A-9001-F7D6E7BC1373');


GO
ADD SENSITIVITY CLASSIFICATION TO
    [dbo].[ext_vendor].[vendor_telephone]
    WITH (LABEL = 'Confidential - GDPR', LABEL_ID = '989ADC05-3F3F-0588-A635-F475B994915B', INFORMATION_TYPE = 'Contact Info', INFORMATION_TYPE_ID = '5C503E21-22C6-81FA-620B-F369B8EC38D1');


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_name', @value = N'Confidential - GDPR', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ext_vendor', @level2type = N'COLUMN', @level2name = N'vendor_telephone';


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_id', @value = N'989ADC05-3F3F-0588-A635-F475B994915B', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ext_vendor', @level2type = N'COLUMN', @level2name = N'vendor_telephone';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_name', @value = N'Contact Info', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ext_vendor', @level2type = N'COLUMN', @level2name = N'vendor_telephone';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_id', @value = N'5C503E21-22C6-81FA-620B-F369B8EC38D1', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ext_vendor', @level2type = N'COLUMN', @level2name = N'vendor_telephone';


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_name', @value = N'Confidential', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ext_vendor', @level2type = N'COLUMN', @level2name = N'vendor_ordercurrency';


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_id', @value = N'331F0B13-76B5-2F1B-A77B-DEF5A73C73C2', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ext_vendor', @level2type = N'COLUMN', @level2name = N'vendor_ordercurrency';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_name', @value = N'Financial', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ext_vendor', @level2type = N'COLUMN', @level2name = N'vendor_ordercurrency';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_id', @value = N'C44193E1-0E58-4B2A-9001-F7D6E7BC1373', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ext_vendor', @level2type = N'COLUMN', @level2name = N'vendor_ordercurrency';


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_name', @value = N'Confidential', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ext_vendor', @level2type = N'COLUMN', @level2name = N'vendor_termofpayment';


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_id', @value = N'331F0B13-76B5-2F1B-A77B-DEF5A73C73C2', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ext_vendor', @level2type = N'COLUMN', @level2name = N'vendor_termofpayment';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_name', @value = N'Credit Card', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ext_vendor', @level2type = N'COLUMN', @level2name = N'vendor_termofpayment';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_id', @value = N'D22FA6E9-5EE4-3BDE-4C2B-A409604C4646', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ext_vendor', @level2type = N'COLUMN', @level2name = N'vendor_termofpayment';


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_name', @value = N'Confidential', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ext_vendor', @level2type = N'COLUMN', @level2name = N'vendor_onetimeaccount';


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_id', @value = N'331F0B13-76B5-2F1B-A77B-DEF5A73C73C2', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ext_vendor', @level2type = N'COLUMN', @level2name = N'vendor_onetimeaccount';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_name', @value = N'Financial', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ext_vendor', @level2type = N'COLUMN', @level2name = N'vendor_onetimeaccount';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_id', @value = N'C44193E1-0E58-4B2A-9001-F7D6E7BC1373', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ext_vendor', @level2type = N'COLUMN', @level2name = N'vendor_onetimeaccount';


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_name', @value = N'Confidential', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ext_vendor', @level2type = N'COLUMN', @level2name = N'vendoraccountgroup_id';


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_id', @value = N'331F0B13-76B5-2F1B-A77B-DEF5A73C73C2', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ext_vendor', @level2type = N'COLUMN', @level2name = N'vendoraccountgroup_id';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_name', @value = N'Financial', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ext_vendor', @level2type = N'COLUMN', @level2name = N'vendoraccountgroup_id';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_id', @value = N'C44193E1-0E58-4B2A-9001-F7D6E7BC1373', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ext_vendor', @level2type = N'COLUMN', @level2name = N'vendoraccountgroup_id';


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_name', @value = N'Confidential - GDPR', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ext_vendor', @level2type = N'COLUMN', @level2name = N'vendor_city';


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_id', @value = N'989ADC05-3F3F-0588-A635-F475B994915B', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ext_vendor', @level2type = N'COLUMN', @level2name = N'vendor_city';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_name', @value = N'Contact Info', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ext_vendor', @level2type = N'COLUMN', @level2name = N'vendor_city';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_id', @value = N'5C503E21-22C6-81FA-620B-F369B8EC38D1', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ext_vendor', @level2type = N'COLUMN', @level2name = N'vendor_city';


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_name', @value = N'Confidential - GDPR', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ext_vendor', @level2type = N'COLUMN', @level2name = N'vendor_postalcode';


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_id', @value = N'989ADC05-3F3F-0588-A635-F475B994915B', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ext_vendor', @level2type = N'COLUMN', @level2name = N'vendor_postalcode';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_name', @value = N'Contact Info', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ext_vendor', @level2type = N'COLUMN', @level2name = N'vendor_postalcode';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_id', @value = N'5C503E21-22C6-81FA-620B-F369B8EC38D1', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ext_vendor', @level2type = N'COLUMN', @level2name = N'vendor_postalcode';


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_name', @value = N'Confidential - GDPR', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ext_vendor', @level2type = N'COLUMN', @level2name = N'vendor_address';


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_id', @value = N'989ADC05-3F3F-0588-A635-F475B994915B', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ext_vendor', @level2type = N'COLUMN', @level2name = N'vendor_address';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_name', @value = N'Contact Info', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ext_vendor', @level2type = N'COLUMN', @level2name = N'vendor_address';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_id', @value = N'5C503E21-22C6-81FA-620B-F369B8EC38D1', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ext_vendor', @level2type = N'COLUMN', @level2name = N'vendor_address';

