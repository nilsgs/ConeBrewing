using System.Web.Mvc;

namespace ConeBrewing.MVC.Controllers
{
    public class CalculatorController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Abv()
        {
            return PartialView("_AbvCalc");
        }

        public ActionResult Ibu()
        {
            return PartialView("_IbuCalc");
        }
    }
}
