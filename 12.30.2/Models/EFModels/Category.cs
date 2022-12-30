using System;
using System.Collections.Generic;

namespace _12._30._2.Models.EFModels
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int DisplayOrder { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
