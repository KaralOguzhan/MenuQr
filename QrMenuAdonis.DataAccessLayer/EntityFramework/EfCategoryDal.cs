using QrMenuAdonis.DataAccessLayer.Abstract;
using QrMenuAdonis.DataAccessLayer.Repositories;
using QrMenuAdonis.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrMenuAdonis.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal:GenericRepository<Category>,ICategoryDal
    {
    }
}
