using Microsoft.EntityFrameworkCore;
using QrMenuAdonis.DataAccessLayer.Abstract;
using QrMenuAdonis.DataAccessLayer.Concrete;
using QrMenuAdonis.DataAccessLayer.Repositories;
using QrMenuAdonis.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrMenuAdonis.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
		public List<Product> GetProductsWithProductGroup()
		{
			var context = new QrMenuAdonisContext();
			var values = context.Products.Include(x => x.ProductGroup).ToList();
			return values;
		}
	}
}
