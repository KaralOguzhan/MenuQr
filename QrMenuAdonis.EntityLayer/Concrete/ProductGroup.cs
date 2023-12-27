using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrMenuAdonis.EntityLayer.Concrete
{
    public class ProductGroup
    {
        public int ProductGroupID { get; set; }
        public string ProductGroupNameTR { get; set; }
        public string ProductGroupNameEN { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public string ProductGroupDescriptionTR { get; set; }
        public string ProductGroupDescriptionEN { get; set; }
        public string ProductGroupImgUrl { get; set; }
        public bool ProductGroupStatus { get; set; }
        public List<Product> Products { get; set; }
    }
}
