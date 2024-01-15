using Microsoft.AspNetCore.Mvc;

namespace RestaurantWebUI.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
