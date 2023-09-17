using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBanDungCuHocTap.Models
{
    public partial class CartDetail
    {
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public short? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }

        public virtual Cart Cart { get; set; }
        public virtual Product Product { get; set; }
    }
}
