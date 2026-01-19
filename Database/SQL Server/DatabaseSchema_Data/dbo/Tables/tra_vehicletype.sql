CREATE TABLE [dbo].[tra_vehicletype] (
    [vehicletype_id]   INT        IDENTITY (1, 1) NOT NULL,
    [vehicletype_name] NCHAR (10) COLLATE Latin1_General_CI_AI NULL,
    CONSTRAINT [PK_trns_vehicletype] PRIMARY KEY CLUSTERED ([vehicletype_id] ASC)
);

