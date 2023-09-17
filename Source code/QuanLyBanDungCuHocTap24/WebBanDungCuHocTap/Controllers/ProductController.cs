using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanDungCuHocTap.Models;
using PagedList;

namespace WebBanDungCuHocTap.Controllers
{
    public class ProductController : Controller
    {
        Db_WebBanDungCuHocTap da = new Db_WebBanDungCuHocTap();

        //Lấy danh sách sản phẩm dựa trên categoryID
        public ActionResult getCategories(int id, int page = 1)
        {
            //to get list of categories
            ViewBag.listCategories = da.Categories.Select(s => s);


            //to get list of products based on CategoryID
            try
            { 
                page = page < 1 ? 1 : page;

                int pageSize = 9;

                var list = da.Products
                .Where(s => s.CategoryID == id) // Lọc theo CategoryID
                .OrderBy(s => s.ProductID)
                .ToPagedList(page, pageSize);
                return View(list);


            }
            catch (Exception e)
            {
                throw e;
            }
            return View();


        }

        //Lấy sản phẩm dựa trên productID
        public ActionResult getProduct(int id)
        {
            ViewBag.listCategories = da.Categories.Select(s => s);

            var p = da.Products.FirstOrDefault(s => s.ProductID == id);

            return View(p);
        }
    }
}