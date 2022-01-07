CREATE OR ALTER PROCEDURE sp_Product_Search
	-- Add the parameters for the stored procedure here
@StartIndex INT, @PageSize INT
AS
BEGIN

	SET NOCOUNT ON;
	--first result set
	SELECT  [Id],[Name],[Description],[CategoryId],[Price]  from [dbo].[Product]
	ORDER BY
		CategoryId
	OFFSET @StartIndex
	ROWS FETCH NEXT @PageSize ROWS ONLY

	--second result set
	SELECT
		TotalCount = COUNT(Id) from [dbo].[Product]

	
END
GO