using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class GrandParentCategory : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ParentCategory> ParentCategories { get; set; }
    }
}
