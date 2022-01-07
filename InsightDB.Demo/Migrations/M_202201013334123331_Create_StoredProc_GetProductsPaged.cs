using FluentMigrator;
namespace InsightDB.Demo.Migrations
{
    [Migration(202201013334123331)]
    public class M_202201013334123331_Create_StoredProc_GetProductsPaged : Migration
    {
        public override void Up()
        {
            Execute.EmbeddedScript("M_202201013334123331_Create_StoredProc_GetProductsPaged_Up.sql");
        }

        public override void Down()
        {
            Execute.Sql("DROP PROCEDURE IF EXISTS dbo.sp_Product_Search;");
        }
    }
}
