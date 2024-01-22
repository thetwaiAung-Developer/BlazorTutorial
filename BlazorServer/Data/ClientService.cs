using Newtonsoft.Json;
using static BlazorServer.Pages.Blog;

namespace BlazorServer.Data
{
    public class ClientService
    {
        public async Task<T> GetAsync<T>(string endPoint)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(endPoint);

            if (response.IsSuccessStatusCode)
            {
                string jsonStr = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(jsonStr);
            }

            return default(T);
        }
    }
}
