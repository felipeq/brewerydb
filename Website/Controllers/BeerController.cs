using DAL.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Website.Controllers
{
    public class BeerController : Controller
    {
        // DI logging
        readonly IBeerRepository _beerRepository;

        public BeerController(IBeerRepository beerRepository)
        {
            _beerRepository = beerRepository;
        }
        // GET: Beer
        public ActionResult Index()
        {

            return View(_beerRepository.GetAllBeers());
        }

        // GET: Beer/Details/5
        public ActionResult Details(string id)
        {
            return View(_beerRepository.GetBeer(id));
        }
    }
}