CREATE TABLE [dbo].[log_stockownership] (
    [stockownership_id]          CHAR (32)    COLLATE Latin1_General_CI_AS NOT NULL,
    [stockownership_code]        VARCHAR (20) COLLATE Latin1_General_CI_AS NULL,
    [stockownership_description] VARCHAR (50) NULL,
    CONSTRAINT [PK_log_stockownership] PRIMARY KEY CLUSTERED ([stockownership_id] ASC)
);

