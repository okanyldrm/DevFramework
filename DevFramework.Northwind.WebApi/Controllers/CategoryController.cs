using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace DevFramework.Northwind.WebApi.Controllers
{

    [Route("api/[controller]")]
    public class CategoryController : Controller
    {


        private ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }


        [HttpGet("{id}")]
        public Category Get(int id)
        {
            return _categoryService.GetById(id);
        }
    }
}