CREATE TABLE [dbo].[tra_vehicle] (
    [vehicle_id]         INT          IDENTITY (1, 1) NOT NULL,
    [vehicletype_id]     INT          NULL,
    [vehicle_name]       VARCHAR (50) COLLATE Latin1_General_CI_AI NULL,
    [vehicle_number]     VARCHAR (50) COLLATE Latin1_General_CI_AI NULL,
    [vehicle_deadweight] INT          NULL,
    [vehicle_widht]      INT          NULL,
    [vehicle_height]     INT          NULL,
    [vehicle_long]       INT          NULL,
    [vehicle_tare]       INT          NULL,
    CONSTRAINT [PK_trns_vehicle] PRIMARY KEY CLUSTERED ([vehicle_id] ASC),
    CONSTRAINT [FK_vehicle_vehicletype] FOREIGN KEY ([vehicletype_id]) REFERENCES [dbo].[tra_vehicletype] ([vehicletype_id]) ON DELETE CASCADE
);

