CREATE TABLE [dbo].[xsl_cylinder] (
    [cyl_mm]         VARCHAR (50)  CONSTRAINT [DF_xsl_cylinder_cyl_mm] DEFAULT ('N/A') NULL,
    [cyl_t]          VARCHAR (50)  CONSTRAINT [DF_xsl_cylinder_cyl_t] DEFAULT ('') NULL,
    [cyl_no]         VARCHAR (255) NOT NULL,
    [cyl_bt]         VARCHAR (50)  CONSTRAINT [DF_xsl_cylinder_cyl_bt] DEFAULT ('') NULL,
    [cyl_vol]        VARCHAR (50)  CONSTRAINT [DF_xsl_cylinder_cyl_vol] DEFAULT ('') NULL,
    [cyl_gas]        NCHAR (50)    CONSTRAINT [DF_xsl_cylinder_cyl_gas] DEFAULT ('') NULL,
    [cyl_owner]      VARCHAR (50)  CONSTRAINT [DF_xsl_cylinder_cyl_owner] DEFAULT ('') NULL,
    [cyl_bexp]       DATE          NULL,
    [cyl_cexp]       DATE          NULL,
    [cyl_sds]        BIT           CONSTRAINT [DF_xsl_cylinder_cyl_sds] DEFAULT ((0)) NULL,
    [cyl_coc]        BIT           CONSTRAINT [DF_xsl_cylinder_cyl_coc] DEFAULT ((0)) NULL,
    [cyl_ht]         BIT           CONSTRAINT [DF_xsl_cylinder_cyl_ht] DEFAULT ((0)) NULL,
    [cyl_cap]        BIT           CONSTRAINT [DF_xsl_cylinder_cyl_cap] DEFAULT ((0)) NULL,
    [cyl_vag]        VARCHAR (20)  CONSTRAINT [DF_xsl_cylinder_cyl_vag] DEFAULT ('X') NULL,
    [cyl_vshc]       VARCHAR (20)  CONSTRAINT [DF_xsl_cylinder_cyl_vshc] DEFAULT ('X') NULL,
    [cyl_vsii]       VARCHAR (20)  CONSTRAINT [DF_xsl_cylinder_cyl_vsii] DEFAULT ('X') NULL,
    [cyl_mlsb]       VARCHAR (20)  CONSTRAINT [DF_xsl_cylinder_cyl_mlsb] DEFAULT ('X') NULL,
    [cyl_moff]       VARCHAR (20)  CONSTRAINT [DF_xsl_cylinder_cyl_moff] DEFAULT ('X') NULL,
    [cyl_mrgm]       VARCHAR (20)  CONSTRAINT [DF_xsl_cylinder_cyl_mrgm] DEFAULT ('X') NULL,
    [cyl_klsb]       VARCHAR (20)  CONSTRAINT [DF_xsl_cylinder_cyl_klsb] DEFAULT ('X') NULL,
    [cyl_koff]       VARCHAR (20)  CONSTRAINT [DF_xsl_cylinder_cyl_koff] DEFAULT ('X') NULL,
    [cyl_korf]       VARCHAR (20)  CONSTRAINT [DF_xsl_cylinder_cyl_korf] DEFAULT ('X') NULL,
    [cyl_ljy]        VARCHAR (20)  CONSTRAINT [DF_xsl_cylinder_cyl_ljy] DEFAULT ('X') NULL,
    [cyl_expiry]     AS            (case when [cyl_bexp] IS NULL then case when [cyl_cexp] IS NULL then 'N/A' else case when [cyl_cexp]<getdate() then ('+'+CONVERT([varchar](255),datediff(day,[cyl_cexp],getdate()),(0)))+' DAY(S) OVERDUE' else case when [cyl_cexp]=getdate() then 'TODAY' else CONVERT([varchar](255),datediff(day,[cyl_cexp],getdate()),(0))+' DAY(S) LEFT' end end end else case when [cyl_cexp] IS NULL then case when [cyl_bexp]<getdate() then ('+'+CONVERT([varchar](255),datediff(day,[cyl_bexp],getdate()),(0)))+' DAY(S) OVERDUE' else case when [cyl_bexp]=getdate() then 'TODAY' else CONVERT([varchar](255),datediff(day,[cyl_bexp],getdate()),(0))+' DAY(S) LEFT' end end else case when [cyl_bexp]>[cyl_cexp] then case when [cyl_cexp]<getdate() then ('+'+CONVERT([varchar](255),datediff(day,[cyl_cexp],getdate()),(0)))+' DAY(S) OVERDUE' else case when [cyl_cexp]=getdate() then 'TODAY' else CONVERT([varchar](255),datediff(day,[cyl_cexp],getdate()),(0))+' DAY(S) LEFT' end end else case when [cyl_bexp]<[cyl_cexp] then case when [cyl_bexp]<getdate() then ('+'+CONVERT([varchar](255),datediff(day,[cyl_bexp],getdate()),(0)))+' DAY(S) OVERDUE' else case when [cyl_bexp]=getdate() then 'TODAY' else CONVERT([varchar](255),datediff(day,[cyl_bexp],getdate()),(0))+' DAY(S) LEFT' end end else case when [cyl_bexp]<getdate() then ('+'+CONVERT([varchar](255),datediff(day,[cyl_bexp],getdate()),(0)))+' DAY(S) OVERDUE' else case when [cyl_bexp]=getdate() then 'TODAY' else CONVERT([varchar](255),datediff(day,[cyl_bexp],getdate()),(0))+' DAY(S) LEFT' end end end end end end),
    [cyl_countas]    INT           CONSTRAINT [DF_xsl_cylinder_cyl_countas] DEFAULT ((1)) NULL,
    [cyl_notes]      VARCHAR (MAX) NULL,
    [cyl_timestamp]  ROWVERSION    NULL,
    [cyl_identified] AS            (case when [cyl_vag]='x' AND [cyl_vshc]='x' AND [cyl_vsii]='x' AND [cyl_mlsb]='x' AND [cyl_moff]='x' AND [cyl_mrgm]='x' AND [cyl_klsb]='x' AND [cyl_koff]='x' AND [cyl_korf]='x' AND [cyl_ljy]='x' then (0) else (1) end) PERSISTED NOT NULL,
    CONSTRAINT [PK_xsl_cylinder] PRIMARY KEY CLUSTERED ([cyl_no] ASC)
);


GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER dbo.trg_update
   ON  dbo.xsl_cylinder
   AFTER update
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	declare @c_no varchar(255),
			@c_mlsb VARCHAR(255),
			@c_klsb VARCHAR(255)

	begin
		select @c_no=i.cyl_no from inserted i;
		select @c_mlsb=i.cyl_mlsb from inserted i;
		select @c_klsb=i.cyl_klsb from inserted i;
	end

    -- Insert statements for trigger here
	if (@c_mlsb='EMPTY' OR @c_mlsb='EMPTY/XP') OR (@c_klsb='EMPTY' OR @c_klsb='EMPTY/XP')
	BEGIN
		update dbo.xsl_cylinder set cyl_cexp=null where cyl_no=@c_no
	end
END
GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'iif(cyl_vag=''x'',
		0
	,
		iif(cyl_vshc=''x'',
			0
		,
			iif(cyl_vsii=''x'',
				0
			,
				iif(cyl_mlsb=''x'',
					0
				,
					iif(cyl_moff=''x'',
						0
					,
						iif(cyl_mrgm=''x'',
							0
						,
							iif(cyl_klsb=''x'',
								0
							,
								iif(cyl_koff=''x'',
									0
								,
									iif(cyl_korf=''x'',
										0
									,
										iif(cyl_ljy=''x'',
											0
										,
											1
										)
									)
								)
							)
						)
					)
				)
			)
		)
	)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'xsl_cylinder', @level2type = N'COLUMN', @level2name = N'cyl_identified';


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
)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'xsl_cylinder', @level2type = N'COLUMN', @level2name = N'cyl_expiry';

