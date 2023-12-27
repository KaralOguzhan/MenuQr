using Microsoft.AspNetCore.Mvc;
using QrMenuAdonis.BusinessLayer.Abstract;
using QrMenuAdonis.EntityLayer.Concrete;
using QrMenuAdonis.PresentationLayer.Models;

namespace QrMenuAdonis.PresentationLayer.Controllers
{
    public class MenuController : Controller
    {
        private readonly IProductGroupService _productGroupService;
        
        private readonly IProductService _productService;

        public MenuController(IProductService productService , IProductGroupService productGroupService)
        {
            _productService = productService;
            _productGroupService = productGroupService;
        }

        

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult MenuWithImage()
        {
            var productProductGroupList = _productService.TGetListAll();
            var values = _productGroupService.TGetListAll();
            var returnValue = new MyModel( values , productProductGroupList);
            return View(returnValue);
        }
        
    }
    
}
