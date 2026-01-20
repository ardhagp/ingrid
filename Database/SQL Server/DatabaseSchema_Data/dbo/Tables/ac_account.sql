CREATE TABLE [dbo].[ac_account] (
    [account_id]     CHAR (32)     NOT NULL,
    [account_book]   CHAR (32)     NULL,
    [account_group]  CHAR (32)     NULL,
    [account_num]    VARCHAR (7)   NULL,
    [account_name]   VARCHAR (255) NULL,
    [account_enable] BIT           CONSTRAINT [DF_acaccount_acaccount_enable] DEFAULT ((1)) NULL,
    CONSTRAINT [PK_ac_account] PRIMARY KEY CLUSTERED ([account_id] ASC),
    CONSTRAINT [FK_ac_account_ac_book] FOREIGN KEY ([account_book]) REFERENCES [dbo].[ac_book] ([book_id]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_ac_account_ac_group] FOREIGN KEY ([account_group]) REFERENCES [dbo].[ac_group] ([group_id]) ON DELETE CASCADE ON UPDATE CASCADE
);


GO
ADD SENSITIVITY CLASSIFICATION TO
    [dbo].[ac_account].[account_id]
    WITH (LABEL = 'Confidential', LABEL_ID = '331F0B13-76B5-2F1B-A77B-DEF5A73C73C2', INFORMATION_TYPE = 'Financial', INFORMATION_TYPE_ID = 'C44193E1-0E58-4B2A-9001-F7D6E7BC1373');


GO
ADD SENSITIVITY CLASSIFICATION TO
    [dbo].[ac_account].[account_book]
    WITH (LABEL = 'Confidential', LABEL_ID = '331F0B13-76B5-2F1B-A77B-DEF5A73C73C2', INFORMATION_TYPE = 'Financial', INFORMATION_TYPE_ID = 'C44193E1-0E58-4B2A-9001-F7D6E7BC1373');


GO
ADD SENSITIVITY CLASSIFICATION TO
    [dbo].[ac_account].[account_group]
    WITH (LABEL = 'Confidential', LABEL_ID = '331F0B13-76B5-2F1B-A77B-DEF5A73C73C2', INFORMATION_TYPE = 'Financial', INFORMATION_TYPE_ID = 'C44193E1-0E58-4B2A-9001-F7D6E7BC1373');


GO
ADD SENSITIVITY CLASSIFICATION TO
    [dbo].[ac_account].[account_num]
    WITH (LABEL = 'Confidential', LABEL_ID = '331F0B13-76B5-2F1B-A77B-DEF5A73C73C2', INFORMATION_TYPE = 'Financial', INFORMATION_TYPE_ID = 'C44193E1-0E58-4B2A-9001-F7D6E7BC1373');


GO
ADD SENSITIVITY CLASSIFICATION TO
    [dbo].[ac_account].[account_name]
    WITH (LABEL = 'Confidential', LABEL_ID = '331F0B13-76B5-2F1B-A77B-DEF5A73C73C2', INFORMATION_TYPE = 'Financial', INFORMATION_TYPE_ID = 'C44193E1-0E58-4B2A-9001-F7D6E7BC1373');


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_name', @value = N'Confidential', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ac_account', @level2type = N'COLUMN', @level2name = N'account_name';


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_id', @value = N'331F0B13-76B5-2F1B-A77B-DEF5A73C73C2', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ac_account', @level2type = N'COLUMN', @level2name = N'account_name';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_name', @value = N'Financial', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ac_account', @level2type = N'COLUMN', @level2name = N'account_name';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_id', @value = N'C44193E1-0E58-4B2A-9001-F7D6E7BC1373', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ac_account', @level2type = N'COLUMN', @level2name = N'account_name';


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_name', @value = N'Confidential', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ac_account', @level2type = N'COLUMN', @level2name = N'account_num';


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_id', @value = N'331F0B13-76B5-2F1B-A77B-DEF5A73C73C2', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ac_account', @level2type = N'COLUMN', @level2name = N'account_num';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_name', @value = N'Financial', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ac_account', @level2type = N'COLUMN', @level2name = N'account_num';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_id', @value = N'C44193E1-0E58-4B2A-9001-F7D6E7BC1373', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ac_account', @level2type = N'COLUMN', @level2name = N'account_num';


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_name', @value = N'Confidential', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ac_account', @level2type = N'COLUMN', @level2name = N'account_group';


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_id', @value = N'331F0B13-76B5-2F1B-A77B-DEF5A73C73C2', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ac_account', @level2type = N'COLUMN', @level2name = N'account_group';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_name', @value = N'Financial', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ac_account', @level2type = N'COLUMN', @level2name = N'account_group';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_id', @value = N'C44193E1-0E58-4B2A-9001-F7D6E7BC1373', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ac_account', @level2type = N'COLUMN', @level2name = N'account_group';


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_name', @value = N'Confidential', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ac_account', @level2type = N'COLUMN', @level2name = N'account_book';


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_id', @value = N'331F0B13-76B5-2F1B-A77B-DEF5A73C73C2', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ac_account', @level2type = N'COLUMN', @level2name = N'account_book';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_name', @value = N'Financial', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ac_account', @level2type = N'COLUMN', @level2name = N'account_book';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_id', @value = N'C44193E1-0E58-4B2A-9001-F7D6E7BC1373', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ac_account', @level2type = N'COLUMN', @level2name = N'account_book';


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_name', @value = N'Confidential', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ac_account', @level2type = N'COLUMN', @level2name = N'account_id';


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_id', @value = N'331F0B13-76B5-2F1B-A77B-DEF5A73C73C2', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ac_account', @level2type = N'COLUMN', @level2name = N'account_id';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_name', @value = N'Financial', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ac_account', @level2type = N'COLUMN', @level2name = N'account_id';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_id', @value = N'C44193E1-0E58-4B2A-9001-F7D6E7BC1373', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ac_account', @level2type = N'COLUMN', @level2name = N'account_id';

