using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrMenuAdonis.EntityLayer.Concrete
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductNameTR { get; set; }
        public string ProductNameEN { get; set; }
        public string ProductDescriptionTR { get; set; }
        public string ProductDescriptionEN { get; set; }
        public int ProductGroupID { get; set; }
        public ProductGroup ProductGroup { get; set; }
        
        public string ProductImgUrl { get; set; }
        public decimal ProductPrice { get; set; }
        public bool ProductStatus { get; set; }

    }
}
