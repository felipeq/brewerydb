using System.Collections.Generic;
using DAL.Models;

namespace DAL.Repositories
{
    public interface IBreweryRepository
    {
        IEnumerable<Brewery> GetAllBreweries();
        Brewery GetBrewery(string id);
    }
}