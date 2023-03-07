using BlazzorFullStack.Shared;
using System.Net.Http.Json;

namespace BlazzorFullStack.Client.Services.CarService
{
    public class CarService : ICarService
    {
        private readonly HttpClient _http;
        public CarService(HttpClient http) 
        {
            _http= http;
        }
        public List<Car> Cars { get; set; } = new List<Car>();

        public event Action CarChanged;

        public async Task<Service<Car>> GetCar(int id)
        {
            var result = await _http.GetFromJsonAsync<Service<Car>>($"api/car/{id}");

            return result;
        }

        public async Task GetCars(string? categoryUrl = null)
        {
            var result = 
                categoryUrl == null ? 
                await _http.GetFromJsonAsync<Service<List<Car>>>("api/car") :
                await _http.GetFromJsonAsync<Service<List<Car>>>($"api/car/category/{categoryUrl}");

            Cars = result.Data;

            CarChanged.Invoke();
        }
    }
}
