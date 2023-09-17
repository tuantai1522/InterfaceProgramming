using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiBanDungCuHocTap.Models
{
    public class CustomerInfoOfTotalOrder
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public int TotalOrder { get; set; }
    }
}
