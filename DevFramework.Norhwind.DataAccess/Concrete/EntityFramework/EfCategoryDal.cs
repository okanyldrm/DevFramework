using DevFramework.Core.DataAccess.EntitiyFramework;
using DevFramework.Norhwind.DataAccess.Abstract;
using DevFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevFramework.Norhwind.DataAccess.Concrete.EntityFramework
{
   public  class EfCategoryDal : EfEntityRepositoryBase<Category,NorthwindContext> , ICategoryDal
    {

        //Category'e özel EfEntityrepository'de bulunmayan fonksiyonları eklemek için
        //implementasyon concrete'de


    }
}
