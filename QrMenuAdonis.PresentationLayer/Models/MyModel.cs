using QrMenuAdonis.EntityLayer.Concrete;

namespace QrMenuAdonis.PresentationLayer.Models
{
    public class MyModel
    {
        public List<ProductGroup> productGroups { get; set; }
        public List<Product> products { get; set; }
        public MyModel(List<ProductGroup> productGroups, List<Product> products)
        {
            this.productGroups = productGroups;
            this.products = products;
        }
    }
}
