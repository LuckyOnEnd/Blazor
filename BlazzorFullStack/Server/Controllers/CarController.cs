using BlazzorFullStack.Server.Data;
using BlazzorFullStack.Server.Services.CarService;
using BlazzorFullStack.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Net;

namespace BlazzorFullStack.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;
        public CarController(ICarService carService)
        {
            _carService = carService;
        }
        [HttpGet]
        public async Task<ActionResult<Service<List<Car>>>> Get()
        {
            var result = await _carService.GetCars();
            return Ok(result);
        }

        [HttpGet("{carId}")]
        public async Task<ActionResult<Service<Car>>> GetCar(int carId)
        {
            var result = await _carService.GetCar(carId);
            return Ok(result);
        }

    }
}
