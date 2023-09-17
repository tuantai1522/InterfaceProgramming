using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiBanDungCuHocTap.Models;

namespace WebApiBanDungCuHocTap.Controllers
{
    public class OrderController : Controller
    {
        DB_WebQuanLyBanDungCuHocTapContext da = new DB_WebQuanLyBanDungCuHocTapContext();

        //Số lượng đơn hàng đã đặt theo từng khách hàng

        [HttpGet("Total order of every customer")]
        public object TotalOrderOfEveryCustomer()
        {
            var orderTotalByEveryCustomer = da.Orders
                                        .Join(da.Customers,
                                        o => o.CustomerId,
                                        c => c.CustomerId,
                                        (o, c) => new
                                        {
                                            c.CustomerId,
                                            c.FirstName,
                                            c.LastName,
                                            o.OrderId,
                                        }
                                        )
                                        .GroupBy(item => new {
                                            item.CustomerId,
                                            item.FirstName,
                                            item.LastName,
                                        })
                                        .Select(group => new
                                        {
                                            CustomerID = group.Key.CustomerId,
                                            CustomerName = group.Key.FirstName + " " + group.Key.LastName,
                                            TotalOrder = group.Count()
                                        })
                                        .ToList();


            var res = new
            {
                Data = orderTotalByEveryCustomer,
            };
            return res;
        }


        //Nhập mã khách hàng: trả về số đơn hàng của khách hàng đó (gọi stored procedure)
        [HttpGet("Total order of one customer by using stored procedure")]
        public async Task<OkObjectResult> TotalOrderOfOneCustomer(int customerID)
        {
            var orderTotalByCustomer = await da.CustomerInfoOfTotalOrder.FromSqlRaw("orderTotalByCustomer @customerId", new SqlParameter("@customerId", customerID))
    .ToListAsync();
            var res = new
            {
                Data = orderTotalByCustomer,
            };
            return Ok(res);
        }

        //Thống kê doanh thu của top 10 sản phẩm được yêu thích nhất (Quantity lớn nhất trong bảng Order Details)
        [HttpGet("Top 10 best favorite products")]
        public object GetBest10Products()
        {
            var products = da.OrderDetails
                .Join(da.Products,
                od => od.ProductId,
                p => p.ProductId,
                (od, p) => new
                {
                    p.ProductName,
                    p.ProductId,
                    od.Quantity
                })
                .GroupBy(item => new
                {
                    item.ProductId,
                    item.ProductName,
                })
                .Select(group => new
                {
                    ProductID = group.Key.ProductId,
                    ProductName = group.Key.ProductName,
                    Quantity = group.Sum(s => s.Quantity)
                })
                .OrderByDescending(s => s.Quantity)
                .Take(10)
                .ToList();

            var data = new
            {
                Data = products,
            };
            return data;
        }

        //Thống kê doanh thu theo tháng (1 => 12)
        [HttpGet("To get revenue of every month")]
        public object getRevenueOfEveryMonth()
        {
            var lists = da.Orders
                .Join(da.OrderDetails,
                o => o.OrderId,
                od => od.OrderId,
                (o, od) => new
                {
                    o.OrderId,
                    o.OrderDate,
                    od.Quantity,
                    od.UnitPrice
                })
                .GroupBy(item => new
                {
                    Month = item.OrderDate.Value.Month,
                })
                .Select(group => new
                {
                    Month = group.Key.Month,
                    Revenue = group.Sum(s => s.Quantity * s.UnitPrice)
                });

            var data = new
            {
                Data = lists,
            };
            return data;
        }
    }
}
