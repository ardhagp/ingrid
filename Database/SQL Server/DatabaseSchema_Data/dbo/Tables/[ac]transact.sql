


GO
ADD SENSITIVITY CLASSIFICATION TO
    [dbo].[[ac]]transact].[transact_account]
    WITH (LABEL = 'Confidential', LABEL_ID = '331F0B13-76B5-2F1B-A77B-DEF5A73C73C2', INFORMATION_TYPE = 'Financial', INFORMATION_TYPE_ID = 'C44193E1-0E58-4B2A-9001-F7D6E7BC1373');


GO
ADD SENSITIVITY CLASSIFICATION TO
    [dbo].[[ac]]transact].[transact_debit]
    WITH (LABEL = 'Confidential', LABEL_ID = '331F0B13-76B5-2F1B-A77B-DEF5A73C73C2', INFORMATION_TYPE = 'Credit Card', INFORMATION_TYPE_ID = 'D22FA6E9-5EE4-3BDE-4C2B-A409604C4646');


GO



GO



GO



GO



GO



GO



GO



GO
