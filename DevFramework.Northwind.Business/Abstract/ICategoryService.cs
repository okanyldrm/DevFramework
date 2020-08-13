using DevFramework.Core.DataAccess;
using DevFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevFramework.Northwind.Business.Abstract
{
    public interface ICategoryService 
    {

        List<Category> GetAll();

        Category GetById(int productId);


    }
}
