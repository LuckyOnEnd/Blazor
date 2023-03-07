using BlazzorFullStack.Shared;
using System.Net.Http.Json;

namespace BlazzorFullStack.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _http;
        public CategoryService(HttpClient http) 
        {
            _http= http;
        }

        public List<Category> Categories { get; set ; } = new List<Category>(); 

        public async Task GetCategories()
        {
            var response = await _http.GetFromJsonAsync<Service<List<Category>>>("api/category");

            Categories = response.Data;
        }
    }
}
