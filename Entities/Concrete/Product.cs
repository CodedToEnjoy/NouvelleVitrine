using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public short Stock { get; set; }
        public ChildCategory ChildCategory { get; set; }
        public ICollection<ProductAttribute> ProductAttribute { get; set; }


    }
}
