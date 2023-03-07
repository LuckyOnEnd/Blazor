using BlazzorFullStack.Shared;

namespace BlazzorFullStack.Client.Services.CarService
{
    public interface ICarService
    {
        event Action CarChanged;
        List<Car> Cars { get; set; }
        Task GetCars(string? categoryUrl = null);
        Task<Service<Car>> GetCar(int id);
    }
}
