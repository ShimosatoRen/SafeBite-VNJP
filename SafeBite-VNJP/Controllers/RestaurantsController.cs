using Microsoft.AspNetCore.Mvc;

namespace SafeBite_VNJP.Controllers
{
    public class RestaurantsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}
