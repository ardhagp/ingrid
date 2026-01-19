-- =============================================
-- Author:		ArdhaGp
-- Create date: 20180803
-- Description:	Prosedur untuk kompresi log database
-- =============================================
CREATE PROCEDURE [sp_db_compress]
	-- Add the parameters for the stored procedure here
	AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	ALTER DATABASE db_universe_erp SET RECOVERY SIMPLE
 DBCC SHRINKFILE (db_universe_erp_Log, 1)
END