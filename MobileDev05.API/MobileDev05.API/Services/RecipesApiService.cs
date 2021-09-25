using MobileDev05.API.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MobileDev05.API.Services
{
    public class RecipesApiService : IRecipesApiService
    {
        private HttpClient _httpClient;
        IJsonSerializeService serializer = new JsonSerializerService();
        private const string ApiApplicationID = "8acfdcef";
        private const string ApiAccessKey = "YOUR ACCESS KEY";

        public RecipesApiService()
        {
            _httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://api.edamam.com/api/recipes/v2")
            };
        }
        public async Task<Recipe> GetRecipesAsync(string query)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"?type=public&app_id={ApiApplicationID}&app_key={ApiAccessKey}&q={query}&field=label&field=image&field=url");

            if (response.IsSuccessStatusCode)
            {
                string responseString = await response.Content.ReadAsStringAsync();
                Recipe recipeResponse = serializer.Deserialize<Recipe>(responseString);

                return recipeResponse;
            }

            return null;
        }
    }
}
