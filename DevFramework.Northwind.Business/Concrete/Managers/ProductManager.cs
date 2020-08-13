using DevFramework.Norhwind.DataAccess.Abstract;
using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.Entities.ComplexType;
using DevFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevFramework.Northwind.Business.Concrete.Managers
{
    public class ProductManager : IProductService
    {

        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public Product Add(Product product)
        {
            _productDal.Add(product);
            return product;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public Product GetById(int productId)
        {
            return _productDal.Get(p => p.ProductId == productId);

        }

        public List<ProductDetail> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }



    }
}
