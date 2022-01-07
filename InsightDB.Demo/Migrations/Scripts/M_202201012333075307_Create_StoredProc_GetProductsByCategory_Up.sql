CREATE OR ALTER PROCEDURE sp_Product_ByCategory
	-- Add the parameters for the stored procedure here
@CategoryId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT * from dbo.Product where [CategoryId] = @CategoryId
END
GO