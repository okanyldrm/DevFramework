using DevFramework.Core.DataAccess;
using DevFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevFramework.Norhwind.DataAccess.Abstract
{
   public  interface ICategoryDal : IEntityRepository<Category>
    {
    }
}
