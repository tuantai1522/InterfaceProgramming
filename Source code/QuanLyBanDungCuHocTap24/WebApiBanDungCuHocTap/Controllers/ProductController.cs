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
    public class ProductController : Controller
    {
        DB_WebQuanLyBanDungCuHocTapContext da = new DB_WebQuanLyBanDungCuHocTapContext();

        [HttpGet("get all products by using stored procedure")]
        public async Task<OkObjectResult> GetAllProducts()
        {
            var ds = await da.Products.FromSqlRaw("GetAllProducts").ToListAsync();
            return Ok(ds);
        }

        [HttpGet("get product by id")]
        public IActionResult GetCategoryById(int id)
        {
            var ds = da.Products.FirstOrDefault(p => p.ProductId == id);
            return Ok(ds);
        }

        [HttpPost("Add new product")]
        public void addProduct([FromBody] Product p)
        {
            Product newProduct = new Product();
            newProduct.ProductName = p.ProductName;
            newProduct.SupplierId = p.SupplierId;
            newProduct.CategoryId = p.CategoryId;
            newProduct.UnitPrice = p.UnitPrice;
            newProduct.UnitsOnOrder = p.UnitsOnOrder;
            newProduct.UnitsInStock = p.UnitsInStock;
            newProduct.Picture = p.Picture;

            da.Products.Add(newProduct);
            da.SaveChanges();
        }

        [HttpDelete("Delete product by id")]
        public void deleteProduct(int id)
        {
            try
            {
                Product p = da.Products.FirstOrDefault(p => p.ProductId == id);
                da.Products.Remove(p);
                da.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut("Edit product by id")]
        public void editProduct(int id, [FromBody] Product product)
        {
            using (var tran = da.Database.BeginTransaction())
            {
                try
                {
                    Product editedProduct = da.Products.FirstOrDefault(p => p.ProductId == id);

                    editedProduct.ProductName = product.ProductName;
                    editedProduct.SupplierId = product.SupplierId;
                    editedProduct.CategoryId = product.CategoryId;
                    editedProduct.UnitPrice = product.UnitPrice;
                    editedProduct.UnitsOnOrder = product.UnitsOnOrder;
                    editedProduct.UnitsInStock = product.UnitsInStock;
                    editedProduct.Picture = product.Picture;

                    da.Products.Update(editedProduct);
                    da.SaveChanges();
                    tran.Commit();
                }
                catch (Exception)
                {
                    tran.Rollback();
                }
            }
        }

        [HttpPost("Search By Product's Pagination")]
        public object searchProducts(SearchReq searchProductReq)
        {
            var products = da.Products.ToList();

            var offset = (searchProductReq.page - 1) * searchProductReq.size;
            var total = products.Count();
            int totalPage = (total % searchProductReq.size) == 0 ? (int)(total / searchProductReq.size) : (int)(1 + (total / searchProductReq.size));
            var data = products.OrderBy(x => x.ProductId).Skip(offset).Take(searchProductReq.size).ToList();
            var res = new
            {
                Data = data,
                TotalRecord = total,
                TotalPages = totalPage,
                Page = searchProductReq.page,
                Size = searchProductReq.size
            };
            return res;
        }

    }
}
