using DevFramework.Core.DataAccess;
using DevFramework.Northwind.Entities.ComplexType;
using DevFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace DevFramework.Norhwind.DataAccess.Abstract
{
   public  interface IProductDal : IEntityRepository<Product>
    {
        //Product'a özgü kapalı fonksiyonlar yazabilmek için (IEntityRepository'de olmayan fonksiyonları!)
        //joinler buraya

        List<ProductDetail> GetProductDetails();


    }
}
