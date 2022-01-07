using Insight.Database;
using InsightDB.Demo.Data;
using InsightDB.Demo.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InsightDB.Demo.Repositories
{
    [Sql(Schema = "dbo")]
    public interface IProductRepository
    {
        [Sql("sp_Product_Get")]
        Task<Product> GetProduct(int id);
        [Sql("sp_Product_ByCategory")]
        Task<IList<Product>> GetProductsByCategory(int categoryId);

        [Sql("sp_ProductCategory_GetAll")]
        Task<IList<ProductCategory>> GetProductsCategories();
 
        [Recordset(1, typeof(Product), Id = nameof(ProductCategory.Id), GroupBy = nameof(Product.CategoryId), Into = "TopProducts", IsChild = true)]

        [Sql("sp_ProductCategory_GetTopProducts", System.Data.CommandType.StoredProcedure)]
        Task<IList<CategoryTopProducts>> GetCategoriesIncludeTopProducts();

        [Sql("sp_Product_Search", System.Data.CommandType.StoredProcedure)]
        Task<PagedData<Product>> GetProductsPaged(int startIndex, int pageSize);

        [Sql("select * from Product", System.Data.CommandType.Text)]
        Task<IList<Product>> GetProducts();

    }
}
