using Microsoft.AspNetCore.Mvc;
using QrMenuAdonis.BusinessLayer.Abstract;
using QrMenuAdonis.DataAccessLayer.Concrete;
using QrMenuAdonis.EntityLayer.Concrete;
using QrMenuAdonis.PresentationLayer.Models;

namespace QrMenuAdonis.PresentationLayer.Controllers
{
    public class MenuController : Controller
    {
        private readonly IProductGroupService _productGroupService;
        
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
		QrMenuAdonisContext context = new QrMenuAdonisContext();

		public MenuController(IProductService productService, IProductGroupService productGroupService, ICategoryService categoryService)
		{
			_productService = productService;
			_productGroupService = productGroupService;
			_categoryService = categoryService;
		}



		public IActionResult Index(int id)
        {
			var controlMenu = context.typeOfMenus.ToList();
			foreach (var menu in controlMenu)
			{
				if (menu.Status==true)
				{
					var model = new MyModel();
					model.productGroups = _productGroupService.TGetListAll();
					model.products = _productService.TGetListAll();
					var type = 1;
					if (type == 1)
					{
						return View(menu.Name, model);
					}

				}
			}
			
			//var productProductGroupList = _productService.TGetListAll();
			//var values = _productGroupService.TGetListAll();
			//var returnValue = new MyModel( values , productProductGroupList);
			//return View(returnValue);
			return View();
			
		}
        
        
        
        
    }
    
}
