using Microsoft.AspNetCore.Mvc;

namespace RestaurantWebUI.Controllers
{
    public class StatisticController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
