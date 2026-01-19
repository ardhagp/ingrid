CREATE TABLE [dbo].[man_position] (
    [position_id]          CHAR (32)     NOT NULL,
    [position_departement] CHAR (32)     NULL,
    [position_code]        VARCHAR (10)  NULL,
    [position_name]        VARCHAR (50)  NULL,
    [position_description] VARCHAR (255) NULL,
    CONSTRAINT [PK_man_position] PRIMARY KEY CLUSTERED ([position_id] ASC),
    CONSTRAINT [FK_man_position_man_departement] FOREIGN KEY ([position_departement]) REFERENCES [dbo].[man_department] ([departement_id]) ON DELETE CASCADE ON UPDATE CASCADE
);

