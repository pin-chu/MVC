using System;
using System.Collections.Generic;

namespace _12._30._2.Models.EFModels
{
    public partial class Cart
    {
        public Cart()
        {
            CartItems = new HashSet<CartItem>();
        }

        public int Id { get; set; }
        public string MemberAccount { get; set; } = null!;

        public virtual Member MemberAccountNavigation { get; set; } = null!;
        public virtual ICollection<CartItem> CartItems { get; set; }
    }
}
