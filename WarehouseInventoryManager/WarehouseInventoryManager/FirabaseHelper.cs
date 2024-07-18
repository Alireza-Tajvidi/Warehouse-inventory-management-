using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WarehouseInventoryManager
{
    internal class FirabaseHelper
    {
        private static readonly HttpClient client = new HttpClient();
        private static readonly string baseUrl = "https://<your-database-name>.firebaseio.com/";

        public static async Task AddDataAsync<T>(string path, T data)
        {
            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{baseUrl}{path}.json", content);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Data added successfully");
            }
            else
            {
                Console.WriteLine("Error adding data");
            }
        }

        public static async Task<T> GetDataAsync<T>(string path)
        {
            var response = await client.GetAsync($"{baseUrl}{path}.json");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(json);
            }
            else
            {
                Console.WriteLine("Error getting data");
                return default(T);
            }
        }
    }
}
