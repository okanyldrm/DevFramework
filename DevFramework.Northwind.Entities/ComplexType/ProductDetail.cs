using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevFramework.Northwind.Entities.ComplexType
{
    public class ProductDetail : IEntity
    {

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }

    }
}
