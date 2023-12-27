using Microsoft.AspNetCore.Mvc;

namespace QrMenuAdonis.PresentationLayer.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
