using System.Collections.Generic;
using DAL.Models;

namespace DAL.Repositories
{
    public interface IBeerRepository
    {
        IEnumerable<Beer> GetAllBeers();
        Beer GetBeer(string id);
    }
}
