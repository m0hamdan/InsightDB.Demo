using FluentMigrator;
namespace InsightDB.Demo.Migrations
{
    [Migration(202201013334113234)]
    public class M_202201013334113234_Create_StoredProc_GetTopProductsByCategory : Migration
    {
        public override void Up()
        {
            Execute.EmbeddedScript("M_202201013334113234_Create_StoredProc_GetTopProductsByCategory_Up.sql");
        }

        public override void Down()
        {
            Execute.Sql("DROP PROCEDURE IF EXISTS dbo.sp_ProductCategory_GetTopProducts;");
        }
    }
}
