using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.Entities.ComplexType;
using DevFramework.Northwind.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace DevFramework.Northwind.WebApi.Controllers
{

    [Route("api/[controller]/")]
    public class ProductsController : Controller
    {

        private IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public List<Product> Get()
        {
            return _productService.GetAll();
        }

        [HttpGet("getproductdetail")]
        public List<ProductDetail> GetProductDetails()
        {
            return _productService.GetProductDetails();
        }

        [HttpGet("{id}")]
        public Product GetProduct(int id)
        {
            return _productService.GetById(id);
        }






    }
}