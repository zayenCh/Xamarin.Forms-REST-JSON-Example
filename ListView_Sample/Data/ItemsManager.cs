using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ListView_Sample
{
	public class ItemsManager
	{
		IRestService restservice;
		public ItemsManager(IRestService service)
		{
			restservice = service;
		}
		public Task<List<Item>> GetTasksAsync()
		{
			return restservice.GetDataAsync();
		}
	}
}
