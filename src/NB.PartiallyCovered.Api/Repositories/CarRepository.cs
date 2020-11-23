using NB.PartiallyCovered.Api.Responses;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace NB.PartiallyCovered.Api.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly HttpClient _http;

        public CarRepository(HttpClient http)
        {
            _http = http;
        }

        public async Task<CarsResponse> GetAll()
        {
            var response = await _http.GetStringAsync("https://myfakeapi.com/api/cars/");

            return JsonConvert.DeserializeObject<CarsResponse>(response);
        }

        public async Task<CarResponse> GetById(int id)
        {
            var response = await _http.GetStringAsync($"https://myfakeapi.com/api/cars/{id}");

            return JsonConvert.DeserializeObject<CarResponse>(response);
        }

        public async Task<CarsResponse> GetByName(string name)
        {
            var response = await _http.GetStringAsync($"https://myfakeapi.com/api/cars/name/{name}");

            return JsonConvert.DeserializeObject<CarsResponse>(response);
        }

        public async Task<CarsResponse> GetByYear(int year)
        {
            var response = await _http.GetStringAsync($"https://myfakeapi.com/api/cars/year/{year}");

            return JsonConvert.DeserializeObject<CarsResponse>(response);
        }
    }
}
