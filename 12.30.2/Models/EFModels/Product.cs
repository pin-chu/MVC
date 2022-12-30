using System;
using System.Collections.Generic;

namespace _12._30._2.Models.EFModels
{
    public partial class Product
    {
        public Product()
        {
            CartItems = new HashSet<CartItem>();
            OrderItems = new HashSet<OrderItem>();
        }

        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; } = null!;
        public int Price { get; set; }
        public string Description { get; set; } = null!;
        /// <summary>
        /// 1=可購買;0=已下架
        /// </summary>
        public bool? Status { get; set; }
        public string ProductImage { get; set; } = null!;
        /// <summary>
        /// 庫存量
        /// </summary>
        public int Stock { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual ICollection<CartItem> CartItems { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
