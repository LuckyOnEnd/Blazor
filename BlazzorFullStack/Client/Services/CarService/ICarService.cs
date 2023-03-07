using BlazzorFullStack.Shared;

namespace BlazzorFullStack.Client.Services.CarService
{
    public interface ICarService
    {
        List<Car> Cars { get; set; }
        Task GetCars();
        Task<Service<Car>> GetCar(int id);
    }
}
