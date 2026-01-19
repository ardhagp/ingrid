CREATE TABLE [dbo].[log_uom] (
    [uom_id]          CHAR (32)     NOT NULL,
    [uom_name]        VARCHAR (50)  NULL,
    [uom_description] VARCHAR (255) NULL,
    CONSTRAINT [PK_log_uom] PRIMARY KEY CLUSTERED ([uom_id] ASC)
);

