using FluentMigrator;

namespace InsightDB.Demo.Migrations
{
    [Migration(202201012332284599)]
    public class M_202201012332284599_Create_StoredProc_GetProduct : Migration
    {
        public override void Down()
        {
            Execute.EmbeddedScript("M_202201012332284599_Create_StoredProc_GetProduct_Down.sql");
        }

        public override void Up()
        {
            Execute.EmbeddedScript("M_202201012332284599_Create_StoredProc_GetProduct_Up.sql");
        }
    }
}
