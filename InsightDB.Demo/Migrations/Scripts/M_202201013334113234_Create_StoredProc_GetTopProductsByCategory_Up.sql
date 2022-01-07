CREATE OR ALTER PROCEDURE sp_ProductCategory_GetTopProducts

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT * from dbo.ProductCategory 

	SELECT top 10 [Id],[Name],[Description],[CategoryId],[Price]  from [dbo].[Product]
	
END
GO