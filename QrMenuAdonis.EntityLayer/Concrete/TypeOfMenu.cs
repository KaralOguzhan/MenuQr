using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrMenuAdonis.EntityLayer.Concrete
{
	public class TypeOfMenu
	{
        public int TypeOfMenuID { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
    }
}
