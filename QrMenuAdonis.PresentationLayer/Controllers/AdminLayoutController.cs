using Microsoft.AspNetCore.Mvc;

namespace QrMenuAdonis.PresentationLayer.Controllers
{
	public class AdminLayoutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
