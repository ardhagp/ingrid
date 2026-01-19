CREATE VIEW [dbo].[vw_vendor] AS 
SELECT        ROW_NUMBER() over(order by  vendor_name asc) as '#', vendor_name
FROM            dbo.vendor