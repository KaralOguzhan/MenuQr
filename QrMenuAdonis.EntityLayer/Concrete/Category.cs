using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrMenuAdonis.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryNameTR { get; set; }
        public string CategoryNameEN { get; set; }
        public string DescriptionTR { get; set; }
        public string DescriptionEN { get; set; }
        public string CategoryImgUrl { get; set; }
        public bool Status { get; set; }
        public List<ProductGroup> ProductGroups { get; set; }
        
    }
}
