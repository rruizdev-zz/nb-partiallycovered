using Microsoft.AspNetCore.Mvc;
using NB.PartiallyCovered.Api.Models;
using NB.PartiallyCovered.Api.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NB.PartiallyCovered.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        private readonly ICarRepository _repository;

        public CarController(ICarRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<Car>> GetAll()
        {
            var response = await _repository.GetAll();

            return response.Cars;
        }

        [HttpGet("{id}")]
        public async Task<Car> GetById(int id)
        {
            var response = await _repository.GetById(id);

            return response.Car;
        }

        [HttpGet("name/{name}")]
        public async Task<IEnumerable<Car>> GetByName(string name)
        {
            var response = await _repository.GetByName(name);

            return response.Cars;
        }

        [HttpGet("year/{year}")]
        public async Task<IEnumerable<Car>> GetByYear(int year)
        {
            var response = await _repository.GetByYear(year);

            return response.Cars;
        }
    }
}
