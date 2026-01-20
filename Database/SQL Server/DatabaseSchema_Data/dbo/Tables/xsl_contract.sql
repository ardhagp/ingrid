CREATE TABLE [dbo].[xsl_contract] (
    [xsl_contract_mm]        VARCHAR (50) NULL,
    [xsl_contract_plan]      VARCHAR (50) NULL,
    [xsl_contract_vendor]    VARCHAR (50) NOT NULL,
    [xsl_contract_timestamp] ROWVERSION   NOT NULL
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_xsl_contract]
    ON [dbo].[xsl_contract]([xsl_contract_mm] ASC, [xsl_contract_plan] ASC);

