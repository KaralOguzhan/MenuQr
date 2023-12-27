﻿using QrMenuAdonis.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrMenuAdonis.BusinessLayer.Abstract
{
    public interface IProductGroupService : IGenericService<ProductGroup>
    {
        List<ProductGroup> TGetProductGroupsWithCategory();

    }
}
