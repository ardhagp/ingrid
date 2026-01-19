CREATE TABLE [dbo].[sys_chatmember] (
    [chatmember_id]          CHAR (32) NOT NULL,
    [chatmember_chat]        CHAR (32) NULL,
    [chatmember_employee]    CHAR (32) NULL,
    [chatmember_isadmin]     BIT       NULL,
    [chatmember_isbanned]    BIT       NULL,
    [chatmember_banneduntil] DATE      NULL,
    CONSTRAINT [PK_[sys]]chatmember] PRIMARY KEY CLUSTERED ([chatmember_id] ASC)
);

