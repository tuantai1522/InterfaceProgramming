using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using WebBanDungCuHocTap.Models;

namespace WebBanDungCuHocTap.Controllers
{
    public class AccountController : Controller
    {
        Db_WebBanDungCuHocTap da = new Db_WebBanDungCuHocTap();
        List<string> successNotification = new List<string>
        {
            "success", "fa-circle-check", "Bạn đã đăng ký thành công"
        };

        List<string> errorNotification = new List<string>
        {
            "error", "fa-triangle-exclamation", "Đăng ký thất bại"
        };
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [Route("Home/Index")]
        public ActionResult Register(FormCollection form, Customer cus)
        {
            string confirmPassword = form["confirmPassword"];
            if(confirmPassword != cus.Password)
            {
                ViewBag.error = "Password and confirmPassword do not match";
                ViewBag.noti = errorNotification;

                return View();
            }
            if (ModelState.IsValid)
            {
                var check = da.Customers.FirstOrDefault(s => s.UserName == cus.UserName);

                if(check == null)
                {
                    da.Configuration.ValidateOnSaveEnabled = false;

                    cus = new Customer()
                    {
                        LastName = cus.LastName,
                        FirstName = cus.FirstName,
                        UserName = cus.UserName,
                        Password = Crypto.HashPassword(cus.Password),
                        City = cus.City,
                        Phone = cus.Phone,
                        Email = cus.Email
                    };
                    da.Customers.Add(cus);

                    da.SaveChanges();
                    ViewBag.noti = successNotification;

                    //return RedirectToAction("../Home/Index");
                }
                else
                {
                    ViewBag.error = "Username already exists";

                    ViewBag.noti = errorNotification;


                    return View();
                }
            }
            return View();

        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [Route("Home/Index")]
        public ActionResult Login(Customer cus)
        {
            var userName = cus.UserName;
            var passWord = cus.Password;

            var userCheck = da.Customers.SingleOrDefault(s => s.UserName.Equals(userName));

            if (userCheck != null && userName != null && passWord != null)
            {
                bool check = Crypto.VerifyHashedPassword(userCheck.Password, passWord);
                if (check)
                {
                    Session["User"] = userCheck;
                    return RedirectToAction("../Home/Index");
                }
            }
            ViewBag.LoginFail = "Đăng nhập thất bại. Vui lòng kiểm tra lại tài khoản hoặc mật khẩu";
            return View();
        }

        [Route("Home/Index")]
        public ActionResult Logout()
        {
            Session["User"] = null;
            return RedirectToAction("../Home/Index");

        }
    }
}