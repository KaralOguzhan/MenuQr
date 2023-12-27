using QrMenuAdonis.BusinessLayer.Abstract;
using QrMenuAdonis.DataAccessLayer.Abstract;
using QrMenuAdonis.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrMenuAdonis.BusinessLayer.Concrete
{
    public class ProductGroupManager : IProductGroupService
    {
        private readonly IProductGroupDal _productGroupDal;

        public ProductGroupManager(IProductGroupDal productGroupDal)
        {
            _productGroupDal = productGroupDal;
        }

        public void TDelete(ProductGroup entity)
        {
            _productGroupDal.Delete(entity);
        }

        public ProductGroup TGetById(int id)
        {
            return _productGroupDal.GetById(id);
        }

        public List<ProductGroup> TGetListAll()
        {
            return _productGroupDal.GetListAll();
        }

        public List<ProductGroup> TGetProductGroupsWithCategory()
        {
            return _productGroupDal.GetProductGroupsWithCategory();
        }

        public void TInsert(ProductGroup entity)
        {
            _productGroupDal.Insert(entity);
        }

        public void TUpdate(ProductGroup entity)
        {
            _productGroupDal.Update(entity);
        }
    }
}
