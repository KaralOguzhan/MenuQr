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
    public class EfProductGroupDal : GenericRepository<ProductGroup>, IProductGroupDal
    {
        public List<ProductGroup> GetProductGroupsWithCategory()
        {
            var context = new QrMenuAdonisContext();
            var values = context.ProductGroups.Include(x => x.Category).ToList();
            return values;
        }
    }
}
