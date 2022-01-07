using FluentMigrator;
namespace InsightDB.Demo.Migrations
{
    [Migration(202201012318168797)]
    public class M_202201012318168797_Seed_ProductCategories : Migration
    {
        public override void Down()
        {
            Delete.FromTable("ProductCategory").AllRows();
        }

        public override void Up()
        {
            Insert.IntoTable("ProductCategory").Row(new
            {
                Name = "Electronics"
            });
            Insert.IntoTable("ProductCategory").Row(new
            {
                Name = "Kitchenwares"
            });
            Insert.IntoTable("ProductCategory").Row(new
            {
                Name = "Clothing"
            });
            Insert.IntoTable("ProductCategory").Row(new
            {
                Name = "Grocery"
            });
            Insert.IntoTable("ProductCategory").Row(new
            {
                Name = "Shoes"
            });
            Insert.IntoTable("ProductCategory").Row(new
            {
                Name = "Books"
            });
        }
    }
}
