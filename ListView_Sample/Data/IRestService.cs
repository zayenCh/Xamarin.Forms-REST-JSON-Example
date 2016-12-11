using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ListView_Sample
{
	public interface IRestService
	{
		Task<List<Item>> GetDataAsync();
	}
}
