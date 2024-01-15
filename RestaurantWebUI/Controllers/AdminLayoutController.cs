using Microsoft.AspNetCore.Mvc;

namespace RestaurantWebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
