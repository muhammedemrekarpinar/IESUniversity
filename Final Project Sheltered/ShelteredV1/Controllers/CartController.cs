using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShelteredV1.Entity;
using ShelteredV1.Models;

namespace ShelteredV1.Controllers
{
    public class CartController : Controller
    {
        private DataContext db = new DataContext();
        // GET: Cart
        public ActionResult Index()
        {
            return View(GetCart());
        }
        public ActionResult AddToCart(int Id)
        {
            var product = db.Products.FirstOrDefault(i => i.Id == Id);

            if (product != null)
            {
                GetCart().AddProduct(product,1);
            }

            return RedirectToAction("Product","Home");
            return View();
        }
        public ActionResult BuyToCart(int Id)
        {
            var product = db.Products.FirstOrDefault(i => i.Id == Id);

            if (product != null)
            {
                GetCart().AddProduct(product, 1);
            }

            return RedirectToAction("Checkout", "Cart");
            return View();
        }

        public ActionResult RemoveFromCart(int Id)
        {
            var product = db.Products.FirstOrDefault(i => i.Id == Id);

            if (product != null)
            {
                GetCart().DeleteProduct(product);
            }

            return RedirectToAction("Index");
            return View();
        }

        public Cart GetCart()
        {
            var cart =(Cart) Session["Cart"];
            if (cart==null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }

            return cart;
        }

        public PartialViewResult Summary()
        {
            return PartialView(GetCart());
        }

        public ActionResult Checkout()
        {
            return View(new ShippingDetails());
        }

        [HttpPost]
        public ActionResult Checkout(ShippingDetails entity)
        {

            var cart = GetCart();
            if (cart.CartLines.Count==0)
            {
                ModelState.AddModelError("UrunYokError","Sepetinizde ürün bulunmamaktadır.");
            }

            if (ModelState.IsValid)
            {
                //Siparişi veritabanına kayıt et.
                SaveOrder(cart, entity);
                //işlem sonu sıfırlama
                cart.Clear();
                return View("Completed");
            }
            else
            {
                return View(entity);
            }

            return View();
        }

        private void SaveOrder(Cart cart, ShippingDetails entity)
        {
            var order = new Order();
            order.OrderNumber = "O" + (new Random()).Next(111111,999999).ToString();
            order.Total = cart.Total();
            order.OrderTime=DateTime.Now;
            order.OrderState = EnumOrderState.Bekleniyor;
            order.UserName = User.Identity.Name;
            
            order.AdresBasligi = entity.AdresBasligi;
            order.Adres = entity.Adres;
            order.Sehir = entity.Sehir;
            order.Semt = entity.Semt;
            order.Mahalle = entity.Mahalle;
            order.PostaKodu = entity.PostaKodu;

            order.OrderLines = new List<OrderLine>();
            foreach (var pr in cart.CartLines)
            {
                var orderLine = new OrderLine();

                orderLine.Quantity = pr.Quantity;
                orderLine.Price = pr.Quantity * pr.Product.Price;
                orderLine.ProductId = pr.Product.Id;

                order.OrderLines.Add(orderLine);
            }

            db.Orders.Add(order);
            db.SaveChanges();
        }
    }
}