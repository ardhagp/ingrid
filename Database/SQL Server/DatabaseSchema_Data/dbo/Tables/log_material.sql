CREATE TABLE [dbo].[log_material] (
    [material_id]              CHAR (32)     NOT NULL,
    [material_isidentifier]    BIT           NULL,
    [material_number]          BIGINT        CONSTRAINT [DF_[log]]material_material_number] DEFAULT ((0)) NULL,
    [material_materialgroup]   CHAR (32)     NULL,
    [material_materialtype]    CHAR (32)     NULL,
    [material_name]            VARCHAR (255) NULL,
    [material_longtext]        VARCHAR (MAX) NULL,
    [material_partnumber]      VARCHAR (255) CONSTRAINT [DF_[log]]material_material_partnumber] DEFAULT ('-') NULL,
    [material_manufacturecode] VARCHAR (255) NULL,
    [material_manufacturename] VARCHAR (255) NULL,
    [material_iscarrier]       BIT           NULL,
    CONSTRAINT [PK_log_material] PRIMARY KEY CLUSTERED ([material_id] ASC),
    CONSTRAINT [FK_log_material_log_materialgroup] FOREIGN KEY ([material_materialgroup]) REFERENCES [dbo].[log_materialgroup] ([materialgroup_id]) ON UPDATE CASCADE,
    CONSTRAINT [FK_log_material_log_materialtype] FOREIGN KEY ([material_materialtype]) REFERENCES [dbo].[log_materialtype] ([materialtype_id])
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IDX_log_material]
    ON [dbo].[log_material]([material_number] ASC);

