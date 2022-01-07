CREATE OR ALTER PROCEDURE sp_ProductCategory_GetAll

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT * from dbo.ProductCategory 
END
GO