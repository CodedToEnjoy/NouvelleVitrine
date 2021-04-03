using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class ProductAttribute : IEntity
    {
        public string Value { get; set; }
        public int ProductId { get; set; }
        public int AttributeId { get; set; }
        public Product Product { get; set; }
        public Attribute Attribute { get; set; }
    }
}
