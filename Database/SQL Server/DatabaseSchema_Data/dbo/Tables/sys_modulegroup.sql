CREATE TABLE [dbo].[sys_modulegroup] (
    [modulegroup_id]          CHAR (32)     NOT NULL,
    [modulegroup_name]        VARCHAR (50)  NULL,
    [modulegroup_description] VARCHAR (255) NULL,
    [modulegroup_order]       INT           NULL,
    CONSTRAINT [PK_sys_modulegroup] PRIMARY KEY CLUSTERED ([modulegroup_id] ASC)
);

