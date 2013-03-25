using ConeBrewing.Data.Finders;
using System.Web.Mvc;

namespace ConeBrewing.MVC.Controllers
{
    public class BeerController : Controller
    {
        private readonly IBeerFinder _beerFinder;

        public BeerController(IBeerFinder beerFinder)
        {
            _beerFinder = beerFinder;
        }
        
        public ActionResult Index()
        {
            return View(_beerFinder.GetAll());
        }

        public ActionResult Details(int id)
        {
            return View(_beerFinder.Get(id));
        }
    }
}
