﻿using QrMenuAdonis.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrMenuAdonis.DataAccessLayer.Abstract
{
    public interface IProductGroupDal : IGenericDal<ProductGroup>
    {
        List<ProductGroup> GetProductGroupsWithCategory();
    }
}
