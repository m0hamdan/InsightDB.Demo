using FluentMigrator;
namespace InsightDB.Demo.Migrations
{
    [Migration(202201012333075307)]
    public class M_202201012333075307_Create_StoredProc_GetProductsByCategory : Migration
    {
        public override void Up()
        {
            Execute.EmbeddedScript("M_202201012333075307_Create_StoredProc_GetProductsByCategory_Up.sql");
        }

        public override void Down()
        {
            Execute.Sql("DROP PROCEDURE IF EXISTS dbo.sp_Product_ByCategory;");
        }
    }
}
