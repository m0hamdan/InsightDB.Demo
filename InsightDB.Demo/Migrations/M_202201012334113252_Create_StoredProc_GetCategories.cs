using FluentMigrator;
namespace InsightDB.Demo.Migrations
{
    [Migration(202201012334113252)]
    public class M_202201012334113252_Create_StoredProc_GetCategories : Migration
    {
        public override void Up()
        {
            Execute.EmbeddedScript("M_202201012334113252_Create_StoredProc_GetCategories_Up.sql");
        }

        public override void Down()
        {
            Execute.Sql("DROP PROCEDURE IF EXISTS dbo.sp_ProductCategory_GetAll;");
        }
    }
}
