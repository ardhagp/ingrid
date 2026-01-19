CREATE TABLE [dbo].[xsl_cylinder_mvt] (
    [mvt_id]       NUMERIC (18)  IDENTITY (100000, 1) NOT NULL,
    [mvt_manifest] VARCHAR (255) NULL,
    [mvt_date]     DATE          NULL,
    [mvt_from]     VARCHAR (255) NULL,
    [mvt_to]       VARCHAR (255) NULL,
    [mvt_uniq]     ROWVERSION    NULL,
    CONSTRAINT [PK_xsl_cylinder_mvt] PRIMARY KEY CLUSTERED ([mvt_id] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_xsl_cylinder_mvt]
    ON [dbo].[xsl_cylinder_mvt]([mvt_manifest] ASC);

