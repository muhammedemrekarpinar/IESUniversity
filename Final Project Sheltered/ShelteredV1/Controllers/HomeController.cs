using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShelteredV1.Entity;
using ShelteredV1.Models;

namespace ShelteredV1.Controllers
{
    public class HomeController : Controller
    {
        DataContext _context = new DataContext();
        // GET: Home
        public ActionResult Index()
        {
            var urunler = _context.Products
                .Where(i => i.IsHome && i.IsApproved)
                .Select(i=> new ProductModel()
                    {
                        Id = i.Id,
                        Name = i.Name,
                        Description = i.Description.Length>10?i.Description.Substring(0,10):i.Description,
                        Price = i.Price,
                        Stock = i.Stock,
                        Image = i.Image ?? "NoImg.png",
                        CategoryId=i.CategoryId
                    }
                )
                .ToList();
            return View(urunler);
        }

        public ActionResult Details(int id)
        {
            return View(_context.Products.Where(i => i.Id == id).FirstOrDefault());
        }
        public ActionResult Product()
        {
            var urunler = _context.Products
                .Where(i => i.IsApproved)
                .Select(i => new ProductModel()
                    {
                        Id = i.Id,
                        Name = i.Name,
                        Description = i.Description.Length > 10 ? i.Description.Substring(0, 10) : i.Description,
                        Price = i.Price,
                        Stock = i.Stock,
                        Image = i.Image ?? "NoImg.png",
                        CategoryId = i.CategoryId
                    }
                )
                .ToList();
            return View(urunler);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}