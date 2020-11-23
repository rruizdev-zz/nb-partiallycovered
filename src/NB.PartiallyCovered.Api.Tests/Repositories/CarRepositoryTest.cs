using Moq;
using NB.PartiallyCovered.Api.Repositories;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace NB.PartiallyCovered.Api.Tests.Repositories
{
    public class CarRepositoryTest
    {
        private readonly Mock<HttpClient> _mockHttp;

        private readonly ICarRepository _sut;

        public CarRepositoryTest()
        {
            _mockHttp = new Mock<HttpClient>();

            _sut = new CarRepository(_mockHttp.Object);
        }

        [Fact]
        public async Task CarRepository_GetAll_ReturnsResponse()
        {
            // Arrange


            // Act
            var response = _sut.GetAll();

            // Assert
        }
    }
}
