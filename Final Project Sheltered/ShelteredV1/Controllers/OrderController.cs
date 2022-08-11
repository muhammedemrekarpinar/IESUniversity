using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShelteredV1.Entity;
using ShelteredV1.Models;

namespace ShelteredV1.Controllers
{
    [Authorize(Roles = "admin") ]
    public class OrderController : Controller
    {
        DataContext db = new DataContext();
        // GET: Order
        public ActionResult Index()
        {

            var orders = db.Orders.Select(i => new AdminOrderModel
                {
                    Id = i.Id,
                    OrderNumber = i.OrderNumber,
                    OrderTime = i.OrderTime,
                    OrderState = i.OrderState,
                    Total = i.Total,
                    Count = i.OrderLines.Count
                }
            ).OrderByDescending(i=>i.OrderTime).ToList();

            return View(orders);
        }

        public ActionResult Details(int id)
        {
            var entity = db.Orders.Where(i => i.Id == id)
                .Select(i => new OrderDetailsModel()
                    {

                        OrderId = i.Id,
                        OrderNumber = i.OrderNumber,
                        Total = i.Total,
                        OrderTime = i.OrderTime,
                        OrderState = i.OrderState,
                        AdresBasligi = i.AdresBasligi,
                        Adres = i.Adres,
                        Sehir = i.Sehir,
                        Semt = i.Semt,
                        Mahalle = i.Mahalle,
                        PostaKodu = i.PostaKodu,
                        OrderLines = i.OrderLines.Select(o => new OrderLineModel()
                        {

                            ProductId = o.ProductId,
                            ProductName = o.Product.Name,
                            Image = o.Product.Image,
                            Quantity = o.Quantity,
                            Price = o.Price

                        }).ToList()

                    }
                )
                .FirstOrDefault();

            return View(entity);
        }

        public ActionResult UpdateOrderState(int OrderId, EnumOrderState OrderState)
        {

            var order = db.Orders.FirstOrDefault(i => i.Id == OrderId);
            if (order!=null)
            {
                order.OrderState = OrderState;
                db.SaveChanges();

                TempData["message"] = "Bilgileriniz Kayıt Edildi.";

                return RedirectToAction("Details",new { id = OrderId });
            }

            return RedirectToAction("Index");
        }
    }
}