using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Diagnostics;

namespace ListView_Sample
{
	public class RestService:IRestService
	{
		HttpClient client;
		public List<Item> Items{ get; set;}

		public RestService()
		{
			client = new HttpClient();
		}

		public async Task<List<Item>> GetDataAsync()
		{
			Items = new List<Item>();
			//var uri = new Uri(string.Format(Constants.RestUrl, string.Empty));
			var uri = new Uri(Constants.RestUrl);
			try
			{
				var response = await client.GetAsync(uri);
				if (response.IsSuccessStatusCode)
				{
					var content = await response.Content.ReadAsStringAsync();
					Items = JsonConvert.DeserializeObject<List<Item>>(content);
					Debug.WriteLine("CONNECTION OK");
				}
			}
			catch (Exception ex){ Debug.WriteLine("CONNECTION ERROR "+ex.Message);}
			return Items;
		}

	}
}
