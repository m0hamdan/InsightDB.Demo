using Insight.Database;
using InsightDB.Demo.Data;
using System.Collections.Generic;
using System.Linq;

namespace InsightDB.Demo.Data
{
	public class PagedData<T> : Results<T, int>
	{
		//Set1 : First result set
		public IList<T> Records { get { return Set1; } }
		//Set2: second result set, retrieve only the first row since we know before hand it's going to return total count
		public int TotalCount { get { return Set2.First(); } }
	}

	public class PagedProducts: Results<Product, int>
    {
		public IList<Product> Records { get { return Set1; } }
		public int TotalCount { get { return Set2.First(); } }
	}

}
