CREATE TABLE [dbo].[log_reservation] (
    [reservation_basedate]            DATE          NULL,
    [reservation_requirementdate]     DATE          NULL,
    [reservation_number]              VARCHAR (255) COLLATE Latin1_General_CI_AS NULL,
    [reservation_itemnumber]          VARCHAR (255) COLLATE Latin1_General_CI_AS NULL,
    [reservation_createdby]           VARCHAR (255) COLLATE Latin1_General_CI_AS NULL,
    [reservation_movementtype]        VARCHAR (255) COLLATE Latin1_General_CI_AS NULL,
    [reservation_plant]               VARCHAR (255) COLLATE Latin1_General_CI_AS NULL,
    [reservation_storagelocation]     VARCHAR (255) COLLATE Latin1_General_CI_AS NULL,
    [reservation_storagebin]          VARCHAR (255) COLLATE Latin1_General_CI_AS NULL,
    [reservation_material]            VARCHAR (255) COLLATE Latin1_General_CI_AS NULL,
    [reservation_materialdescription] VARCHAR (255) COLLATE Latin1_General_CI_AS NULL,
    [reservation_totalstock]          INT           NULL,
    [reservation_requirementqty]      INT           NULL,
    [reservation_withdrawnqty]        INT           NULL,
    [reservation_uom]                 VARCHAR (255) COLLATE Latin1_General_CI_AS NULL,
    [reservation_finalissued]         VARCHAR (255) COLLATE Latin1_General_CI_AS NULL,
    [reservation_deleted]             VARCHAR (255) COLLATE Latin1_General_CI_AS NULL,
    [reservation_criticalcategory]    VARCHAR (255) COLLATE Latin1_General_CI_AS NULL,
    [reservation_criticalpart]        VARCHAR (255) COLLATE Latin1_General_CI_AS NULL,
    [reservation_batch]               VARCHAR (255) COLLATE Latin1_General_CI_AS NULL,
    [reservation_movementallowed]     VARCHAR (255) COLLATE Latin1_General_CI_AS NULL,
    [reservation_accountassignment]   VARCHAR (255) COLLATE Latin1_General_CI_AS NULL,
    [reservation_costcenter]          VARCHAR (255) COLLATE Latin1_General_CI_AS NULL,
    [reservation_wbselement]          VARCHAR (255) COLLATE Latin1_General_CI_AS NULL,
    [reservation_order]               VARCHAR (255) COLLATE Latin1_General_CI_AS NULL,
    [reservation_goodsrecipient]      VARCHAR (255) COLLATE Latin1_General_CI_AS NULL,
    [reservation_text]                VARCHAR (255) COLLATE Latin1_General_CI_AS NULL
);


GO
ADD SENSITIVITY CLASSIFICATION TO
    [dbo].[log_reservation].[reservation_accountassignment]
    WITH (LABEL = 'Confidential', LABEL_ID = '331F0B13-76B5-2F1B-A77B-DEF5A73C73C2', INFORMATION_TYPE = 'Financial', INFORMATION_TYPE_ID = 'C44193E1-0E58-4B2A-9001-F7D6E7BC1373');


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_name', @value = N'Confidential', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'log_reservation', @level2type = N'COLUMN', @level2name = N'reservation_accountassignment';


GO
EXECUTE sp_addextendedproperty @name = N'sys_sensitivity_label_id', @value = N'331F0B13-76B5-2F1B-A77B-DEF5A73C73C2', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'log_reservation', @level2type = N'COLUMN', @level2name = N'reservation_accountassignment';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_name', @value = N'Financial', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'log_reservation', @level2type = N'COLUMN', @level2name = N'reservation_accountassignment';


GO
EXECUTE sp_addextendedproperty @name = N'sys_information_type_id', @value = N'C44193E1-0E58-4B2A-9001-F7D6E7BC1373', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'log_reservation', @level2type = N'COLUMN', @level2name = N'reservation_accountassignment';

