using DevFramework.Northwind.Entities.ComplexType;
using DevFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevFramework.Northwind.Business.Abstract
{
    public interface IProductService
    {

        List<Product> GetAll();

        Product GetById(int productId);

        Product Add(Product product);

        List<ProductDetail> GetProductDetails();



    }
}
