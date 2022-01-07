using System.Collections.Generic;

namespace InsightDB.Demo.Data
{
    public class CategoryTopProducts
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Product> TopProducts { get; set; }
    }
}
