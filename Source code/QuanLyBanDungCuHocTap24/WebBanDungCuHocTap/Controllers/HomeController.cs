using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanDungCuHocTap.Models;

namespace WebBanDungCuHocTap.Controllers
{
    public class HomeController : Controller
    {
        Db_WebBanDungCuHocTap da = new Db_WebBanDungCuHocTap();

        public ActionResult Index()
        {
            //Get categories
            ViewBag.listCategories = da.Categories.Select(s => s);

            //Get "Đồ dùng học sinh"
            ViewBag.listDoDungHocSinh = da.Products.Where(s => s.CategoryID == 1).Take(10);

            //Get "Bìa"
            ViewBag.listBia = da.Products.Where(s => s.CategoryID == 2).Take(10);

            //Get "Kẹp giấy"
            ViewBag.listKimBam = da.Products.Where(s => s.CategoryID == 5).Take(10);


            return View();
        }
    }
}