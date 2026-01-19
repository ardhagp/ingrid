CREATE TABLE [dbo].[ac_group] (
    [group_id]     CHAR (32)    NOT NULL,
    [group_name]   VARCHAR (50) NULL,
    [group_inline] CHAR (1)     NULL,
    [group_order]  INT          NULL,
    CONSTRAINT [PK_ac_group] PRIMARY KEY CLUSTERED ([group_id] ASC)
);

