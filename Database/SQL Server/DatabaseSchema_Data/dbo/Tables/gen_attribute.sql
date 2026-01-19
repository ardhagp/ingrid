CREATE TABLE [dbo].[gen_attribute] (
    [attribute_id]       CHAR (32)     NOT NULL,
    [attribute_name]     VARCHAR (255) NULL,
    [attribute_category] CHAR (32)     NULL,
    CONSTRAINT [PK_[gen]]attribute] PRIMARY KEY CLUSTERED ([attribute_id] ASC),
    CONSTRAINT [FK_attribute_attributecategory] FOREIGN KEY ([attribute_category]) REFERENCES [dbo].[gen_attributecategory] ([attributecategory_id]) ON DELETE CASCADE ON UPDATE CASCADE
);

