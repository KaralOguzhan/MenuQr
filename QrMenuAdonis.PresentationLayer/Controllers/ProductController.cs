using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using QrMenuAdonis.BusinessLayer.Abstract;
using QrMenuAdonis.DataAccessLayer.Concrete;
using QrMenuAdonis.EntityLayer.Concrete;

namespace QrMenuAdonis.PresentationLayer.Controllers
{
	public class ProductController : Controller
	{
		private readonly IProductService _productService;
		QrMenuAdonisContext context = new QrMenuAdonisContext();

		public ProductController(IProductService productService)
		{
			_productService = productService;
		}

		public IActionResult Index()
		{
			var values = _productService.TGetListAll();
			return View(values);
		}
		[HttpGet]
		public IActionResult CreateProduct()
		{
			List<SelectListItem> productGroupNames = (from x in context.ProductGroups.ToList()
												  select new SelectListItem
												  {
													  Text = x.ProductGroupNameTR,
													  Value = x.ProductGroupID.ToString()
												  }).ToList();
			ViewBag.pgn = productGroupNames;
			return View();
		}
		[HttpPost]
		public IActionResult CreateProduct(Product product)
		{
			_productService.TInsert(product);
			return RedirectToAction("IndexWithProductGroupName");
		}
		public IActionResult IndexWithProductGroupName()
		{
			var values = _productService.TGetProductsWithProductGroup();
			return View(values);
		}
		public IActionResult ChangeProductStatus(int id)
		{
			var value = context.Products.Find(id);
			value.ProductStatus = !value.ProductStatus;
			context.SaveChanges();
			return RedirectToAction("IndexWithProductGroupName");
		}
		public IActionResult DeleteProduct(int id)
		{
			var value = _productService.TGetById(id);
			_productService.TDelete(value);
			return RedirectToAction("IndexWithProductGroupName");
		}
		[HttpGet]
		public IActionResult UpdateProduct(int id)
		{
			List<SelectListItem> productGroupNames = (from x in context.ProductGroups.ToList()
													  select new SelectListItem
													  {
														  Text = x.ProductGroupNameTR,
														  Value = x.ProductGroupID.ToString()
													  }).ToList();
			ViewBag.pgn = productGroupNames;
			var value = _productService.TGetById(id);
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdateProduct(Product product)
		{
			_productService.TUpdate(product);
			return RedirectToAction("IndexWithProductGroupName");
		}

	}
}
