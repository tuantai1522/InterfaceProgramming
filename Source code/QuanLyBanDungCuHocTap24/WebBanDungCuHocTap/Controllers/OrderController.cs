using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanDungCuHocTap.Models;

namespace WebBanDungCuHocTap.Controllers
{
    public class OrderController : Controller
    {
        Db_WebBanDungCuHocTap da = new Db_WebBanDungCuHocTap();

        public ActionResult getOrder(int customerID)
        {
            var order = da.Orders.Where(s => s.CustomerID == customerID);

            return View(order);
        }

        public ActionResult getOrderToCheckOut(int customerID)
        {
            var cart = da.Carts.FirstOrDefault(s => s.CustomerID == customerID);

            if (cart != null)
            {
                var cartDetails = da.Cart_Details.Where(cd => cd.CartID == cart.CartID);
                return View(cartDetails);
            }
            return View();
        }

        [HttpPost]
        public ActionResult addToOrder(
            int customerID,
            string shipAddress,
            string shipCity,
            string shipCountry,
            List<int> productValues,
            List<int> quantityValues,
            List<double> unitPriceValues
            )
        {
            try
            {

            //Thêm vào bảng Order
            using (var transaction = da.Database.BeginTransaction())
            {
                try
                {
                    Order order = new Order()
                    {
                        CustomerID = customerID,
                        EmployeeID = 1,
                        OrderDate = DateTime.Now,
                        ShippedDate = DateTime.Now.AddDays(3),
                        ShipAddress = shipAddress,
                        ShipCity = shipCity,
                        ShipCountry = shipCountry,
                    };
                    da.Orders.Add(order);
                    da.SaveChanges();

                    transaction.Commit();
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    throw e;
                }
            }

            //Thêm vào bảng Order Details

            using (var transaction = da.Database.BeginTransaction())
            {
                try
                {
                    int orderID = da.Orders.OrderByDescending(s => s.OrderID).FirstOrDefault().OrderID;

                    int length = productValues.Count();

                    for (int i = 0; i < length; ++i)
                    {
                        int OrderID = orderID;
                        int ProductID = productValues[i];
                        decimal? UnitPrice = (decimal?)unitPriceValues[i];
                        short? Quantity = (short?)quantityValues[i];

                        Order_Detail orderDetail = new Order_Detail()
                        {
                            OrderID = OrderID,
                            ProductID = ProductID,
                            UnitPrice = UnitPrice,
                            Quantity = Quantity
                        };

                        da.Order_Details.Add(orderDetail);
                    }

                    da.SaveChanges();
                    transaction.Commit();

                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    throw e;
                }
            }

            //Xóa toàn bộ sản phẩm hiện tại của khách hàng ở trong Cart

            var cartsToDelete = da.Carts.Where(s => s.CustomerID == customerID);
            da.Carts.RemoveRange(cartsToDelete);


            da.SaveChanges();

            return View();
            }

            catch (Exception e)
            {
                throw e;
            }
        }
    }
}