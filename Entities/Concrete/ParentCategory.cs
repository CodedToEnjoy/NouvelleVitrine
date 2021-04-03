using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class ParentCategory : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public GrandParentCategory GrandParentCategory { get; set; }
        public ICollection<ChildCategory> ChildCategories { get; set; }
    }
}
