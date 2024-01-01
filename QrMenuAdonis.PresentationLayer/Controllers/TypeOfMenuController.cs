using Microsoft.AspNetCore.Mvc;
using QrMenuAdonis.DataAccessLayer.Concrete;

namespace QrMenuAdonis.PresentationLayer.Controllers
{
	public class TypeOfMenuController : Controller
	{
		QrMenuAdonisContext context = new QrMenuAdonisContext();

		public IActionResult Index()
		{
			var values = context.typeOfMenus.ToList();
			return View(values);
		}
		public IActionResult ChangeStatus(int id)
		{
			var values = context.typeOfMenus.ToList();
			foreach (var item in values)
			{
				item.Status = false;
			}
			var selectedList = context.typeOfMenus.Find(id);
			selectedList.Status= true;
			context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
