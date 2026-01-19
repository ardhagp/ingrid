CREATE TABLE [dbo].[sys_module] (
    [module_id]            CHAR (32)     NOT NULL,
    [module_modulegroup]   CHAR (32)     NULL,
    [module_code]          VARCHAR (10)  NULL,
    [module_name]          VARCHAR (255) NULL,
    [module_description]   VARCHAR (255) NULL,
    [module_appminimumver] VARCHAR (10)  NULL,
    [module_ismaintenance] BIT           CONSTRAINT [DF_[sys]]module_module_ismaintenance] DEFAULT ('false') NULL,
    [module_issystem]      BIT           CONSTRAINT [DF_[sys]]module_module_issystem] DEFAULT ('false') NULL,
    [module_lockafter]     INT           CONSTRAINT [DF_[sys]]module_module_lockafter] DEFAULT ((0)) NULL,
    CONSTRAINT [PK_sys_module] PRIMARY KEY CLUSTERED ([module_id] ASC),
    CONSTRAINT [FK_sys_module_sys_modulegroup] FOREIGN KEY ([module_modulegroup]) REFERENCES [dbo].[sys_modulegroup] ([modulegroup_id]) ON DELETE CASCADE ON UPDATE CASCADE
);

