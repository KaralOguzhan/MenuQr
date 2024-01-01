using QrMenuAdonis.EntityLayer.Concrete;

namespace QrMenuAdonis.PresentationLayer.Models
{
    public class MyModel
    {
        public List<ProductGroup> productGroups { get; set; }
        public List<Product> products { get; set; }
        public MyModel()
        {
            productGroups = new List<ProductGroup>();
            products = new List<Product>();
        }
    }
}
