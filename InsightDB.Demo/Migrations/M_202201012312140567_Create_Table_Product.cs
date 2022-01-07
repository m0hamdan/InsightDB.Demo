using FluentMigrator;
namespace InsightDB.Demo.Migrations
{
    [Migration(202201012312140567)]
    public class M_202201012312140567_Create_Table_Product: Migration
    {
        public override void Up()
        {
            Create.Table("Product")
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey("PK_Product_Id").Identity()
                .WithColumn("Name").AsString(100).NotNullable()
                .WithColumn("Description").AsString(500).NotNullable()
                .WithColumn("CategoryId").AsInt32().NotNullable()
                .WithColumn("Price").AsCurrency().NotNullable();

            Create.ForeignKey("FK_ProductCategory_Id")
                .FromTable("Product").ForeignColumn("CategoryId")
                .ToTable("ProductCategory").PrimaryColumn("Id");
        }

        public override void Down()
        {
            Delete.Table("Product");
        }
    }
}
