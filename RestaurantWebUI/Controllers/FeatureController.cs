using Microsoft.AspNetCore.Mvc;

namespace RestaurantWebUI.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
