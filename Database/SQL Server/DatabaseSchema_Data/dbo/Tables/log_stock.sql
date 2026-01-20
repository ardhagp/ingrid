CREATE TABLE [dbo].[log_stock] (
    [stock_id]             CHAR (32)       COLLATE Latin1_General_CI_AS NOT NULL,
    [stock_storage]        CHAR (32)       COLLATE Latin1_General_CI_AS NULL,
    [stock_material]       CHAR (32)       NULL,
    [stock_stockownership] CHAR (32)       COLLATE Latin1_General_CI_AS NULL,
    [stock_serialnumber]   VARCHAR (50)    NULL,
    [stock_onhand]         DECIMAL (18)    NULL,
    [stock_location]       VARCHAR (255)   NULL,
    [stock_note]           VARCHAR (255)   NULL,
    [stock_reorderpoint]   DECIMAL (18, 2) NULL,
    [stock_maximumstock]   DECIMAL (18, 2) NULL,
    [stock_safetystock]    DECIMAL (18, 2) NULL,
    [stock_roundingvalue]  DECIMAL (18, 2) NULL,
    [stock_totalstock]     DECIMAL (18, 2) NULL,
    [stock_uom]            CHAR (32)       NULL,
    [stock_movingprice]    DECIMAL (18, 2) NULL,
    CONSTRAINT [PK_log_stock] PRIMARY KEY CLUSTERED ([stock_id] ASC),
    CONSTRAINT [FK_log_stock_log_material] FOREIGN KEY ([stock_material]) REFERENCES [dbo].[log_material] ([material_id]) ON UPDATE CASCADE,
    CONSTRAINT [FK_log_stock_log_stocktype] FOREIGN KEY ([stock_stockownership]) REFERENCES [dbo].[log_stockownership] ([stockownership_id]) ON UPDATE CASCADE,
    CONSTRAINT [FK_log_stock_log_storage] FOREIGN KEY ([stock_storage]) REFERENCES [dbo].[log_storage] ([storage_id]) ON UPDATE CASCADE,
    CONSTRAINT [FK_stock_uom] FOREIGN KEY ([stock_uom]) REFERENCES [dbo].[log_uom] ([uom_id])
);

