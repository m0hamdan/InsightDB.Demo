using FluentMigrator;
namespace InsightDB.Demo.Migrations
{
    [Migration(202201012307440848)]
    public class M_202201012307440848_Create_Table_ProductCategory : Migration
    {
        public override void Up()
        {
            Create.Table("ProductCategory")
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey("PK_ProductCategory_Id").Identity()
                .WithColumn("Name").AsString(200).NotNullable();
        }

        public override void Down()
        {
            Delete.Table("ProductCategory");
        }
    }
}
