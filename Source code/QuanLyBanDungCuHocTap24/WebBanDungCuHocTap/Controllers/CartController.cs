using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanDungCuHocTap.Models;
namespace WebBanDungCuHocTap.Controllers
{
    public class CartController : Controller
    {
        Db_WebBanDungCuHocTap da = new Db_WebBanDungCuHocTap();

        // GET: Cart of current customer
        public ActionResult getCart(int customerID)
        {
            var cart = da.Carts.FirstOrDefault(s => s.CustomerID == customerID);

            if(cart != null)
            {
                var cartDetails = da.Cart_Details.Where(cd => cd.CartID == cart.CartID);
                return View(cartDetails);
            }
            return View();
        }

        //add product into cart

        [HttpPost]
        public ActionResult addtoCart(int productID, int customerID, int quantity, string type = "normal")
        {

            //Nếu đã đăng nhập mới được thêm vào
            if (Session["User"] != null)
            {
                //Thêm vào CSDL
                try
                {
                    //Tìm xem khách hàng này đã có Cart chưa
                    var cart = da.Carts.FirstOrDefault(s => s.CustomerID == customerID);

                    //chưa tạo cart trước đó => tạo Cart
                    if(cart == null)
                    {

                        Cart newCart = new Cart()
                        {
                            CustomerID = customerID,
                        };

                        da.Carts.Add(newCart);
                        da.SaveChanges();
                    }

                    //Tạo Order Details: thêm CartID, ProductID, Quantity, UnitPrice
                    int cartID = da.Carts.FirstOrDefault(s => s.CustomerID == customerID).CartID;

                    decimal unitPrice = (decimal)da.Products.FirstOrDefault(s => s.ProductID == productID).UnitPrice;

                    //Xem coi sản phẩm đó có tồn tại trong cart của khách hàng hiện tại hay chưa
                    var cartDetails = da.Cart_Details.FirstOrDefault(s => s.CartID == cartID && s.ProductID == productID);
                    //1. Nếu chưa thì thêm
                    if(cartDetails == null)
                    {
                        Cart_Detail newCartDetail = new Cart_Detail()
                        {
                            CartID = cartID,
                            ProductID = productID,
                            Quantity = (short?)quantity,
                            UnitPrice = unitPrice
                        };

                        da.Cart_Details.Add(newCartDetail);
                    }
                    else //2. Nếu có rồi thì cộng vào số lượng
                    {
                        cartDetails.CartID = cartID;
                        cartDetails.ProductID = productID;
                        cartDetails.Quantity += (short?)quantity;
                        cartDetails.UnitPrice = unitPrice;
                    }
                    da.SaveChanges();

                    if(type == "ajax")
                    {
                        return Json(new {
                            productID, 
                            customerID,
                            quantity,
                            soLuong = da.Cart_Details.Count(s => s.CartID == cartID),
                            totalPrice = da.Cart_Details.Where(s => s.CartID == cartID).Sum(s => s.UnitPrice * s.Quantity)
                        });
                    }

                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            return RedirectToAction("../Home/Index");
        }
    
        public ActionResult deleteCart(int productID, int customerID, string type = "ajax")
        {
            var cart = da.Carts.FirstOrDefault(s => s.CustomerID == customerID);

            var cartDetailsToDelete = da.Cart_Details.FirstOrDefault(s => s.CartID == cart.CartID && s.ProductID == productID);

            da.Cart_Details.Remove(cartDetailsToDelete);

            da.SaveChanges();

            if (type == "ajax")
            {
                return Json(new
                {
                    productID,
                    customerID,
                    soLuong = da.Cart_Details.Count(s => s.CartID == cart.CartID),
                    totalPrice = da.Cart_Details.Where(s => s.CartID == cart.CartID).Sum(s => s.UnitPrice * s.Quantity)
                });
            }

            return RedirectToAction("../Home/Index");


        }


    }
}