CREATE TABLE [dbo].[cus_todos] (
    [todos_id]             CHAR (32)     NOT NULL,
    [todos_ispublic]       BIT           NULL,
    [todos_isreminder]     BIT           NULL,
    [todos_name]           VARCHAR (255) NULL,
    [todos_datestart]      DATE          NULL,
    [todos_timestart]      TIME (7)      NULL,
    [todos_dateend]        DATE          NULL,
    [todos_timeend]        TIME (7)      NULL,
    [todos_dayleft]        AS            (case when [todos_isreminder]=(1) then case when [todos_iscomplete]=(0) then datediff(day,[todos_dateend],getdate()) else (0) end else case when [todos_iscomplete]=(0) then case when getdate()>[todos_dateend] then datediff(day,[todos_dateend],getdate()) else case when getdate()=[todos_dateend] then (0) else datediff(day,[todos_dateend],getdate()) end end else case when [todos_datecomplete]>[todos_dateend] then datediff(day,[todos_dateend],[todos_datecomplete]) else case when [todos_datecomplete]=[todos_dateend] then (0) else datediff(day,[todos_dateend],[todos_datecomplete]) end end end end),
    [todos_dayleftext]     VARCHAR (50)  NULL,
    [todos_priority]       INT           NULL,
    [todos_currentvalue]   INT           NULL,
    [todos_totalvalue]     INT           NULL,
    [todos_percentage]     AS            (([todos_currentvalue]*(100))/[todos_totalvalue]),
    [todos_instruction]    VARCHAR (MAX) NULL,
    [todos_createon]       DATETIME      NULL,
    [todos_createdby]      CHAR (32)     NULL,
    [todos_iscomplete]     BIT           NULL,
    [todos_datecomplete]   DATE          NULL,
    [todos_completedby]    CHAR (32)     NULL,
    [todos_isverified]     BIT           NULL,
    [todos_dateverified]   DATE          NULL,
    [todos_verifiedby]     CHAR (32)     NULL,
    [todos_occurencegroup] CHAR (32)     NULL,
    CONSTRAINT [PK_[cus]]todos] PRIMARY KEY CLUSTERED ([todos_id] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Set occurence group', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'cus_todos', @level2type = N'COLUMN', @level2name = N'todos_occurencegroup';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Kolom untuk menyimpan perhitungan persentase antara :
currentvalue / totalvalue.', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'cus_todos', @level2type = N'COLUMN', @level2name = N'todos_percentage';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'iif(todos_isreminder=1,
	iif(todos_iscomplete=0,
		datediff(day, todos_dateend, getdate())
	,
		0
	)
,
	iif(todos_iscomplete=0,
		iif(getdate()>todos_dateend,
			datediff(day, todos_dateend, getdate())
		,
			iif(getdate()=todos_dateend,
				0
			,
				datediff(day, todos_dateend, getdate())
			)
		)
	,
		iif(todos_datecomplete>todos_dateend,
			datediff(day, todos_dateend, todos_datecomplete)
		,
			iif(todos_datecomplete=todos_dateend,
				0
			,
				datediff(day, todos_dateend, todos_datecomplete)
			)
		)
	)
)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'cus_todos', @level2type = N'COLUMN', @level2name = N'todos_dayleft';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Tabel untuk menyimpan data reminder / todos.', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'cus_todos';

