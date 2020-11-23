using Moq;
using NB.PartiallyCovered.Api.Controllers;
using NB.PartiallyCovered.Api.Models;
using NB.PartiallyCovered.Api.Repositories;
using NB.PartiallyCovered.Api.Responses;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace NB.PartiallyCovered.Api.Tests.Controllers
{
    public class CarControllerTest
    {
        private readonly CarController _sut;

        private readonly Mock<ICarRepository> _repositoryMock;

        public CarControllerTest()
        {
            _repositoryMock = new Mock<ICarRepository>();

            _sut = new CarController(_repositoryMock.Object);
        }

        [Fact]
        public async Task CarController_GetAll_ReturnEnumerable()
        {
            // Arrange
            _repositoryMock.Setup(x => x.GetAll()).ReturnsAsync(new CarsResponse()
            {
                Cars = new List<Car>()
                {
                    new Car()
                }
            });

            // Act
            var response = await _sut.GetAll();

            // Assert
            Assert.Single(response);
            Assert.IsType<Car>(response.FirstOrDefault());
        }
    }
}
