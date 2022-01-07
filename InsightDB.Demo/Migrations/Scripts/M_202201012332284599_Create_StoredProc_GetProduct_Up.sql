CREATE or ALTER PROCEDURE sp_Product_Get
	-- Add the parameters for the stored procedure here
@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT * from dbo.Product where Id = @Id
END
GO
