using NB.PartiallyCovered.Api.Responses;
using System.Threading.Tasks;

namespace NB.PartiallyCovered.Api.Repositories
{
    public interface ICarRepository
    {
        Task<CarsResponse> GetAll();

        Task<CarResponse> GetById(int id);

        Task<CarsResponse> GetByName(string name);

        Task<CarsResponse> GetByYear(int year);
    }
}
