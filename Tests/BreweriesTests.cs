using System.Linq;
using DAL.Repositories;
using Xunit;

namespace Tests
{
    public class BreweriesTests
    {

        readonly IBreweryRepository _breweryRepository = new BreweryRepository();
        [Fact]
        public void Breweries_GetAll_FoundBreweries()
        {
            var breweries = _breweryRepository.GetAllBreweries();
            Assert.True(breweries.Any());
        }
        [Fact]
        public void Breweries_GetOne_FoundBrewery()
        {
            var breweries = _breweryRepository.GetAllBreweries();
            var foundBreweryId = breweries.FirstOrDefault()?.id;
            Assert.True(!string.IsNullOrEmpty(foundBreweryId), "Brewery Id is not valid!");
            var brewery = _breweryRepository.GetBrewery(foundBreweryId);
            Assert.True(brewery?.id.Equals(foundBreweryId));
        }

    }

}
