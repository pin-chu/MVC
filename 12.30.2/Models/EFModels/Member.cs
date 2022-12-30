using System;
using System.Collections.Generic;

namespace _12._30._2.Models.EFModels
{
    public partial class Member
    {
        public Member()
        {
            Carts = new HashSet<Cart>();
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Account { get; set; } = null!;
        public string EncryptedPassword { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Mobile { get; set; }
        public bool IsConfirmed { get; set; }
        public string? ConfirmCode { get; set; }

        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
