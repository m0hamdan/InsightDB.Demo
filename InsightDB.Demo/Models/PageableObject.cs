using System.Collections.Generic;

namespace InsightDB.Demo.Models
{
    public class PageableObject<T>
    {
        public List<T> Records { get; set; } = new();
        public int TotalCount { get; set; }
    }
}
