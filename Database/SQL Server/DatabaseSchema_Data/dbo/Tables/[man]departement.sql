CREATE TABLE [dbo].[[man]]department] (
    [department_id]          CHAR (32)     NOT NULL,
    [departement_company]     CHAR (32)     NULL,
    [departement_code]        VARCHAR (10)  NULL,
    [departement_name]        VARCHAR (255) NULL,
    [departement_description] VARCHAR (50)  NULL,
    CONSTRAINT [PK_man_departement] PRIMARY KEY CLUSTERED ([department_id] ASC),
    CONSTRAINT [FK_man_departement_man_company] FOREIGN KEY ([departement_company]) REFERENCES [dbo].[[man]]company] ([company_id]) ON DELETE CASCADE ON UPDATE CASCADE
);

