using Microsoft.AspNetCore.Mvc;

namespace RestaurantWebUI.Controllers
{
    public class ProgressBarsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
