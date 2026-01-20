CREATE TABLE [dbo].[ac_transaction] (
    [transact_id]      CHAR (32)       NOT NULL,
    [transact_account] CHAR (32)       NULL,
    [transact_date]    DATE            NULL,
    [transact_debit]   DECIMAL (18, 2) NULL,
    [transact_kredit]  DECIMAL (18, 2) NULL,
    [transact_news]    VARCHAR (255)   NULL,
    [transact_hash]    CHAR (32)       NULL,
    CONSTRAINT [PK_ac_transact] PRIMARY KEY CLUSTERED ([transact_id] ASC),
    CONSTRAINT [FK_ac_transact_ac_account] FOREIGN KEY ([transact_account]) REFERENCES [dbo].[ac_account] ([account_id]) ON DELETE CASCADE ON UPDATE CASCADE
);


GO
ADD SENSITIVITY CLASSIFICATION TO
    [dbo].[ac_transaction].[transact_account]
    WITH (LABEL = 'Confidential', LABEL_ID = '331F0B13-76B5-2F1B-A77B-DEF5A73C73C2', INFORMATION_TYPE = 'Financial', INFORMATION_TYPE_ID = 'C44193E1-0E58-4B2A-9001-F7D6E7BC1373');


GO
ADD SENSITIVITY CLASSIFICATION TO
    [dbo].[ac_transaction].[transact_debit]
    WITH (LABEL = 'Confidential', LABEL_ID = '331F0B13-76B5-2F1B-A77B-DEF5A73C73C2', INFORMATION_TYPE = 'Credit Card', INFORMATION_TYPE_ID = 'D22FA6E9-5EE4-3BDE-4C2B-A409604C4646');


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_name', @value = N'Confidential', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ac_transaction', @level2type = N'COLUMN', @level2name = N'transact_debit';


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_id', @value = N'331F0B13-76B5-2F1B-A77B-DEF5A73C73C2', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ac_transaction', @level2type = N'COLUMN', @level2name = N'transact_debit';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_name', @value = N'Credit Card', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ac_transaction', @level2type = N'COLUMN', @level2name = N'transact_debit';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_id', @value = N'D22FA6E9-5EE4-3BDE-4C2B-A409604C4646', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ac_transaction', @level2type = N'COLUMN', @level2name = N'transact_debit';


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_name', @value = N'Confidential', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ac_transaction', @level2type = N'COLUMN', @level2name = N'transact_account';


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_id', @value = N'331F0B13-76B5-2F1B-A77B-DEF5A73C73C2', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ac_transaction', @level2type = N'COLUMN', @level2name = N'transact_account';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_name', @value = N'Financial', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ac_transaction', @level2type = N'COLUMN', @level2name = N'transact_account';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_id', @value = N'C44193E1-0E58-4B2A-9001-F7D6E7BC1373', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ac_transaction', @level2type = N'COLUMN', @level2name = N'transact_account';

