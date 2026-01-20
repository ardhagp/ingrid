CREATE TABLE [dbo].[xsl_cylinder_e] (
    [cyl_row]    INT           NOT NULL,
    [cyl_mm]     VARCHAR (50)  CONSTRAINT [DF_xsl_cylinder_e_cyl_mm] DEFAULT ('N/A') NULL,
    [cyl_t]      VARCHAR (50)  CONSTRAINT [DF_xsl_cylinder_e_cyl_t] DEFAULT ('') NULL,
    [cyl_no]     VARCHAR (255) NULL,
    [cyl_bt]     VARCHAR (50)  CONSTRAINT [DF_xsl_cylinder_e_cyl_bt] DEFAULT ('') NULL,
    [cyl_vol]    VARCHAR (50)  CONSTRAINT [DF_xsl_cylinder_e_cyl_vol] DEFAULT ('') NULL,
    [cyl_gas]    NCHAR (50)    CONSTRAINT [DF_xsl_cylinder_e_cyl_gas] DEFAULT ('') NULL,
    [cyl_owner]  VARCHAR (50)  CONSTRAINT [DF_xsl_cylinder_e_cyl_owner] DEFAULT ('') NULL,
    [cyl_bexp]   DATE          NULL,
    [cyl_cexp]   DATE          NULL,
    [cyl_sds]    BIT           CONSTRAINT [DF_xsl_cylinder_e_cyl_sds] DEFAULT ((0)) NULL,
    [cyl_coc]    BIT           CONSTRAINT [DF_xsl_cylinder_e_cyl_coc] DEFAULT ((0)) NULL,
    [cyl_ht]     BIT           CONSTRAINT [DF_xsl_cylinder_e_cyl_ht] DEFAULT ((0)) NULL,
    [cyl_cap]    BIT           CONSTRAINT [DF_xsl_cylinder_e_cyl_cap] DEFAULT ((0)) NULL,
    [cyl_vag]    VARCHAR (10)  CONSTRAINT [DF_xsl_cylinder_e_cyl_vag] DEFAULT ('X') NULL,
    [cyl_vshc]   VARCHAR (10)  CONSTRAINT [DF_xsl_cylinder_e_cyl_vshc] DEFAULT ('X') NULL,
    [cyl_vsii]   VARCHAR (10)  CONSTRAINT [DF_xsl_cylinder_e_cyl_vsii] DEFAULT ('X') NULL,
    [cyl_mlsb]   VARCHAR (10)  CONSTRAINT [DF_xsl_cylinder_e_cyl_mlsb] DEFAULT ('X') NULL,
    [cyl_moff]   VARCHAR (10)  CONSTRAINT [DF_xsl_cylinder_e_cyl_moff] DEFAULT ('X') NULL,
    [cyl_mrgm]   VARCHAR (10)  CONSTRAINT [DF_xsl_cylinder_e_cyl_mrgm] DEFAULT ('X') NULL,
    [cyl_klsb]   VARCHAR (10)  CONSTRAINT [DF_xsl_cylinder_e_cyl_klsb] DEFAULT ('X') NULL,
    [cyl_koff]   VARCHAR (10)  CONSTRAINT [DF_xsl_cylinder_e_cyl_koff] DEFAULT ('X') NULL,
    [cyl_korf]   VARCHAR (10)  CONSTRAINT [DF_xsl_cylinder_e_cyl_korf] DEFAULT ('X') NULL,
    [cyl_ljy]    VARCHAR (10)  CONSTRAINT [DF_xsl_cylinder_e_cyl_ljy] DEFAULT ('X') NULL,
    [cyl_expiry] AS            (case when [cyl_bexp] IS NULL then case when [cyl_cexp] IS NULL then 'N/A' else case when [cyl_cexp]<getdate() then ('+'+CONVERT([varchar](255),datediff(day,[cyl_cexp],getdate()),(0)))+' DAY(S) OVERDUE' else case when [cyl_cexp]=getdate() then 'TODAY' else CONVERT([varchar](255),datediff(day,[cyl_cexp],getdate()),(0))+' DAY(S) LEFT' end end end else case when [cyl_cexp] IS NULL then case when [cyl_bexp]<getdate() then ('+'+CONVERT([varchar](255),datediff(day,[cyl_bexp],getdate()),(0)))+' DAY(S) OVERDUE' else case when [cyl_bexp]=getdate() then 'TODAY' else CONVERT([varchar](255),datediff(day,[cyl_bexp],getdate()),(0))+' DAY(S) LEFT' end end else case when [cyl_bexp]>[cyl_cexp] then case when [cyl_cexp]<getdate() then ('+'+CONVERT([varchar](255),datediff(day,[cyl_cexp],getdate()),(0)))+' DAY(S) OVERDUE' else case when [cyl_cexp]=getdate() then 'TODAY' else CONVERT([varchar](255),datediff(day,[cyl_cexp],getdate()),(0))+' DAY(S) LEFT' end end else case when [cyl_bexp]<[cyl_cexp] then case when [cyl_bexp]<getdate() then ('+'+CONVERT([varchar](255),datediff(day,[cyl_bexp],getdate()),(0)))+' DAY(S) OVERDUE' else case when [cyl_bexp]=getdate() then 'TODAY' else CONVERT([varchar](255),datediff(day,[cyl_bexp],getdate()),(0))+' DAY(S) LEFT' end end else case when [cyl_bexp]<getdate() then ('+'+CONVERT([varchar](255),datediff(day,[cyl_bexp],getdate()),(0)))+' DAY(S) OVERDUE' else case when [cyl_bexp]=getdate() then 'TODAY' else CONVERT([varchar](255),datediff(day,[cyl_bexp],getdate()),(0))+' DAY(S) LEFT' end end end end end end),
    CONSTRAINT [PK_xsl_cylinder_e] PRIMARY KEY CLUSTERED ([cyl_row] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'iif(cyl_bexp is null,
	iif(cyl_cexp is null,
		''N/A''
	,
		iif(cyl_cexp<getdate(),
			cast(datediff(day,cyl_cexp,getdate()) as varchar(255)) + '' DAY(S) OVERDUE''
		,
			iif(cyl_cexp=getdate(),
				''TODAY''
			,
				cast(datediff(day,cyl_cexp,getdate()) as varchar(255)) + '' DAY(S) LEFT''
			)
		)
	)
,
	iif(cyl_cexp is null,
		iif(cyl_bexp<getdate(),
			cast(datediff(day,cyl_bexp,getdate()) as varchar(255)) + '' DAY(S) OVERDUE''
		,
			iif(cyl_bexp=getdate(),
				''TODAY''
			,
				cast(datediff(day,cyl_bexp,getdate()) as varchar(255)) + '' DAY(S) LEFT''
			)
		)
	,
		iif(cyl_bexp>cyl_cexp,
				iif(cyl_cexp<getdate(),
					cast(datediff(day,cyl_cexp,getdate()) as varchar(255)) + '' DAY(S) OVERDUE''
				,
					iif(cyl_cexp=getdate(),
						''TODAY''
					,
						cast(datediff(day,cyl_cexp,getdate()) as varchar(255)) + '' DAY(S) LEFT''
					)
				)
		,
			iif(cyl_bexp<cyl_cexp,
				iif(cyl_bexp<getdate(),
					cast(datediff(day,cyl_bexp,getdate()) as varchar(255)) + '' DAY(S) OVERDUE''
				,
					iif(cyl_bexp=getdate(),
						''TODAY''
					,
						cast(datediff(day,cyl_bexp,getdate()) as varchar(255)) + '' DAY(S) LEFT''
					)
				)
			,
				iif(cyl_bexp<getdate(),
					cast(datediff(day,cyl_bexp,getdate()) as varchar(255)) + '' DAY(S) OVERDUE''
				,
					iif(cyl_bexp=getdate(),
						''TODAY''
					,
						cast(datediff(day,cyl_bexp,getdate()) as varchar(255)) + '' DAY(S) LEFT''
					)
				)
			)
		)
	)
)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'xsl_cylinder_e', @level2type = N'COLUMN', @level2name = N'cyl_expiry';

