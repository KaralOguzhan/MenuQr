using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using QrMenuAdonis.BusinessLayer.Abstract;
using QrMenuAdonis.DataAccessLayer.Concrete;
using QrMenuAdonis.EntityLayer.Concrete;

namespace QrMenuAdonis.PresentationLayer.Controllers
{
	public class ProductGroupController : Controller
	{
		private readonly IProductGroupService _productGroupService;
        QrMenuAdonisContext context = new QrMenuAdonisContext();


        public ProductGroupController(IProductGroupService productGroupService)
		{
			_productGroupService = productGroupService;
		}

		public IActionResult Index()
		{
			var values = _productGroupService.TGetListAll();
			return View(values);
		}
		[HttpGet]
		public IActionResult CreateProductGroup() 
		{ 
			List<SelectListItem> categoryNames = (from x in context.Categories.ToList()
												  select new SelectListItem
												  {
													  Text = x.CategoryNameTR,
													  Value = x.CategoryID.ToString()
												  }).ToList();
			ViewBag.ctg = categoryNames;
			return View();
		}
		[HttpPost]
		public IActionResult CreateProductGroup(ProductGroup productGroup) 
		{ 
			_productGroupService.TInsert(productGroup);
			return RedirectToAction("IndexWithCategoryName");
		}
        public IActionResult ChangeProductGroupStatus(int id)
        {
            var value = context.ProductGroups.Find(id);
            value.ProductGroupStatus = !value.ProductGroupStatus;
            context.SaveChanges();
            return RedirectToAction("IndexWithCategoryName");

        }
		public IActionResult IndexWithCategoryName()
		{
			var values = _productGroupService.TGetProductGroupsWithCategory();
			return View(values);
		}
		public IActionResult DeleteProductGroup(int id) 
		{ 
			var value = _productGroupService.TGetById(id);
			_productGroupService.TDelete(value);
			return RedirectToAction("IndexWithCategoryName");
		}
		[HttpGet]
		public IActionResult UpdateProductGroup(int id)
		{
            List<SelectListItem> categoryNames = (from x in context.Categories.ToList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryNameTR,
                                                      Value = x.CategoryID.ToString()
                                                  }).ToList();
            ViewBag.ctg = categoryNames;
            var value = _productGroupService.TGetById(id);
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdateProductGroup(ProductGroup productGroup)
		{
			_productGroupService.TUpdate(productGroup);
			return RedirectToAction("IndexWithCategoryName");
		}

	}
}
