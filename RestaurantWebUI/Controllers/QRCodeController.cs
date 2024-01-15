using Microsoft.AspNetCore.Mvc;

namespace RestaurantWebUI.Controllers
{
    public class QRCodeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
