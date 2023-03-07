using BlazzorFullStack.Server.Data;
using BlazzorFullStack.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazzorFullStack.Server.Services.CarService
{
    public class CarService : ICarService
    {
        private readonly ApplicationDbContext _db;
        public CarService(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Service<Car>> GetCar(int carId)
        {
            var response = new Service<Car>();
            var car = await _db.Cars.FindAsync(carId);
            if (car == null)
            {
                response.Success = false;
                response.Message = "Not founded";
            }
            else
            {
                response.Data = car;
            }

            return response;
        }

        public async Task<Service<List<Car>>> GetCars()
        {
            var response = new Service<List<Car>>
            {
                Data = await _db.Cars.ToListAsync()
            };
            return response;
        }
    }
}
