using System.Linq;
using DAL.Repositories;
using Xunit;

namespace Tests
{

    public class BeersTests
    {
        // No point to pull whole db just to find working id, maybe caching it
        readonly IBeerRepository _beerRepository = new BeerRepository();
        [Fact]
        public void Beers_GetAll_FoundBeers()
        {
            var beers = _beerRepository.GetAllBeers();
            Assert.True(beers.Any());
        }
        [Fact]
        public void Beers_GetOne_FoundBeer()
        {
            var beers = _beerRepository.GetAllBeers();
            var foundBeerId = beers.FirstOrDefault()?.id;
            Assert.True(!string.IsNullOrEmpty(foundBeerId), "Beer Id is not valid!");
            var beer = _beerRepository.GetBeer(foundBeerId);
            Assert.True(beer?.id.Equals(foundBeerId));
        }

    }
}