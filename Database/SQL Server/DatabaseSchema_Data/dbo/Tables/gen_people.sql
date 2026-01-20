CREATE TABLE [dbo].[gen_people] (
    [people_id]         CHAR (32)     NOT NULL,
    [people_nik]        VARCHAR (50)  NULL,
    [people_fullname]   VARCHAR (255) NULL,
    [people_firstame]   VARCHAR (50)  NULL,
    [people_middlename] VARCHAR (50)  NULL,
    [people_lastname]   VARCHAR (50)  NULL,
    [people_birthdate]  DATE          NULL,
    [people_gender]     VARCHAR (6)   NULL,
    CONSTRAINT [PK_[gen]]people] PRIMARY KEY CLUSTERED ([people_id] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Store people data used in many modules that required detailed personal data', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'gen_people';

