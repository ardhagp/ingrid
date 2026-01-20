CREATE TABLE [dbo].[log_assembly] (
    [assembly_id]        INT          IDENTITY (1, 1) NOT NULL,
    [assembly_itemccode] VARCHAR (32) COLLATE Latin1_General_CI_AI NULL,
    [assembly_itemid]    INT          NULL,
    CONSTRAINT [PK_log_assembly] PRIMARY KEY CLUSTERED ([assembly_id] ASC)
);

