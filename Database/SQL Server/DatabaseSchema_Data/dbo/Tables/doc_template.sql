CREATE TABLE [dbo].[doc_template] (
    [template_id]        CHAR (32)     NOT NULL,
    [template_module]    CHAR (32)     NULL,
    [template_title]     VARCHAR (255) NULL,
    [template_text1]     VARCHAR (MAX) NULL,
    [template_text2]     VARCHAR (MAX) NULL,
    [template_text3]     VARCHAR (MAX) NULL,
    [template_parameter] VARCHAR (MAX) NULL,
    CONSTRAINT [PK_doc_template] PRIMARY KEY CLUSTERED ([template_id] ASC),
    CONSTRAINT [FK_doc_template_sys_module] FOREIGN KEY ([template_module]) REFERENCES [dbo].[sys_module] ([module_id]) ON UPDATE CASCADE
);

