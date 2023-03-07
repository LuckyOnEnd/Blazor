using BlazzorFullStack.Shared;

namespace BlazzorFullStack.Server.Services.CarService
{
    public interface ICarService
    {
        Task<Service<List<Car>>> GetCars();
        Task<Service<Car>> GetCar(int carId);

        Task<Service<List<Car>>> GetCarsByType(string caregoryUrl);
    }
}
