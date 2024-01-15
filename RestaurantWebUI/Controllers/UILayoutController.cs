using Microsoft.AspNetCore.Mvc;

namespace RestaurantWebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
