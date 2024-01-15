using Microsoft.AspNetCore.Mvc;

namespace RestaurantWebUI.ViewComponents.LayoutComponents
{
	public class _LayoutScriptsPartialComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
