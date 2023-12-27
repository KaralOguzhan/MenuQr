using Microsoft.AspNetCore.Mvc;
using QrMenuAdonis.BusinessLayer.Abstract;
using QrMenuAdonis.DataAccessLayer.Concrete;
using QrMenuAdonis.EntityLayer.Concrete;

namespace QrMenuAdonis.PresentationLayer.Controllers
{
	public class CategoryController : Controller
	{
		private readonly ICategoryService _categoryService;
		QrMenuAdonisContext context = new QrMenuAdonisContext();

		public CategoryController(ICategoryService categoryService)
		{
			_categoryService = categoryService;
		}

		public IActionResult Index()
		{
			var values = _categoryService.TGetListAll();
			return View(values);
		}
		
		[HttpGet]
		public IActionResult CreateCategory() 
		{ 
			return View();
		}
        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {
			_categoryService.TInsert(category);
			return RedirectToAction("Index");
        }


        [HttpGet]
		public IActionResult UpdateCategory(int id)
		{
			var value = _categoryService.TGetById(id);
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdateCategory(Category category)
		{
			_categoryService.TUpdate(category);
			return RedirectToAction("Index");
		}
		public IActionResult ChangeStatus(int id)
		{
			var value = context.Categories.Find(id);
			value.Status = !value.Status;
			context.SaveChanges();
			return RedirectToAction("Index");

		}
		public IActionResult DeleteCategory(int id)
		{
			var value = _categoryService.TGetById(id);
			_categoryService.TDelete(value);
			return RedirectToAction("Index");

		}
		
	}
}
