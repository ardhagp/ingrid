CREATE TABLE [dbo].[log_materialgroup] (
    [materialgroup_id]           CHAR (32)     NOT NULL,
    [materialgroup_code]         VARCHAR (20)  NULL,
    [materialgroup_description]  VARCHAR (255) NULL,
    [materialgroup_description2] VARCHAR (255) NULL,
    [materialgroup_language]     VARCHAR (5)   NULL,
    CONSTRAINT [PK_log_materialgroup] PRIMARY KEY CLUSTERED ([materialgroup_id] ASC)
);

