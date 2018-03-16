using DAL.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Website.Controllers
{
    public class BreweryController : Controller
    {
        readonly IBreweryRepository _breweryRepository;

        public BreweryController(IBreweryRepository breweryRepository)
        {
            _breweryRepository = breweryRepository;
        }
        // GET: Brewery
        public ActionResult Index()
        {
            return View(_breweryRepository.GetAllBreweries());
        }

        // GET: Brewery/Details/5
        public ActionResult Details(string id)
        {
            return View(_breweryRepository.GetBrewery(id));
        }
    }
}