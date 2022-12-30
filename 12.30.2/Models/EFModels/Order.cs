using System;
using System.Collections.Generic;

namespace _12._30._2.Models.EFModels
{
    public partial class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int Id { get; set; }
        public int MemberId { get; set; }
        public int Total { get; set; }
        public DateTime CreatedTime { get; set; }
        /// <summary>
        /// 1=訂單成立, 2=已結案, -1=已退訂
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// 客戶是否提出退訂要求
        /// </summary>
        public bool RequestRefund { get; set; }
        public DateTime? RequestRefundTime { get; set; }
        public string Receiver { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string CellPhone { get; set; } = null!;

        public virtual Member Member { get; set; } = null!;
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
