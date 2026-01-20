CREATE TABLE [dbo].[xsl_cylinder_mvtd] (
    [mvtd_id]              NUMERIC (18)  IDENTITY (100000, 1) NOT NULL,
    [mvtd_mvt]             NUMERIC (18)  NULL,
    [mvtd_cylno]           VARCHAR (255) NULL,
    [mvtd_status]          VARCHAR (255) NULL,
    [mvtd_tobeuse]         VARCHAR (255) CONSTRAINT [DF_xsl_cylinder_mvtd_mvtd_tobeuse] DEFAULT ('-') NULL,
    [mvtd_toberefilled]    VARCHAR (255) CONSTRAINT [DF_xsl_cylinder_mvtd_mvtd_toberefilled] DEFAULT ('-') NULL,
    [mvtd_tobehydrotested] VARCHAR (255) CONSTRAINT [DF_xsl_cylinder_mvtd_mvtd_tobehydrotested] DEFAULT ('-') NULL,
    [mvtd_tobeemptied]     VARCHAR (255) CONSTRAINT [DF_xsl_cylinder_mvtd_mvtd_tobeemptied] DEFAULT ('-') NULL,
    [mvtd_tobeconverted]   VARCHAR (255) CONSTRAINT [DF_xsl_cylinder_mvtd_mvtd_tobeconverted] DEFAULT ('-') NULL,
    [mvtd_tobescraped]     VARCHAR (255) CONSTRAINT [DF_xsl_cylinder_mvtd_mvtd_tobescraped] DEFAULT ('-') NULL,
    [mvtd_tobereturned]    VARCHAR (255) CONSTRAINT [DF_xsl_cylinder_mvtd_mvt_tobereturned] DEFAULT ('-') NULL,
    [mvtd_notes]           VARCHAR (MAX) CONSTRAINT [DF_xsl_cylinder_mvtd_mvtd_notes] DEFAULT ('') NULL,
    [mvtd_uniq]            ROWVERSION    NULL,
    CONSTRAINT [PK_xsl_cylinder_mvtd] PRIMARY KEY CLUSTERED ([mvtd_id] ASC),
    CONSTRAINT [FK_xsl_cylinder_mvtd_xsl_cylinder] FOREIGN KEY ([mvtd_cylno]) REFERENCES [dbo].[xsl_cylinder] ([cyl_no]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_xsl_cylinder_mvtd_xsl_cylinder_mvt] FOREIGN KEY ([mvtd_mvt]) REFERENCES [dbo].[xsl_cylinder_mvt] ([mvt_id]) ON DELETE CASCADE ON UPDATE CASCADE
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_xsl_cylinder_mvtd]
    ON [dbo].[xsl_cylinder_mvtd]([mvtd_mvt] ASC, [mvtd_cylno] ASC);

