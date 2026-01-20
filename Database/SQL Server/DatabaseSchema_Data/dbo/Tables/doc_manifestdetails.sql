CREATE TABLE [dbo].[doc_manifestdetails] (
    [manifestlist_id]       CHAR (32) NOT NULL,
    [manifestlist_manifest] BIGINT    NULL,
    [manifestlist_vendor]   BIGINT    NULL,
    CONSTRAINT [PK_doc_manifestdetails] PRIMARY KEY CLUSTERED ([manifestlist_id] ASC)
);

