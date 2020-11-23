using Microsoft.AspNetCore.Mvc;
using NB.PartiallyCovered.Api.Responses;
using System.Threading.Tasks;

namespace NB.PartiallyCovered.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        public CarController()
        {
        }

        [HttpGet]
        public async Task<CarsResponse> Get()
        {
            return new CarsResponse();
        }

        [HttpGet("{id}")]
        public async Task<CarResponse> GetBy(int id)
        {
            return new CarResponse();
        }
    }
}
