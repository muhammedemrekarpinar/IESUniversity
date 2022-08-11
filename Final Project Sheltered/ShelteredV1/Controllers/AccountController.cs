using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using ShelteredV1.Entity;
using ShelteredV1.Identity;
using ShelteredV1.Models;

namespace ShelteredV1.Controllers
{
    public class AccountController : Controller
    {

        private DataContext db = new DataContext();

        private UserManager<ApplicationUser> UserManager;

        private RoleManager<ApplicationRole> RoleManager;

        public AccountController()
        {
            var userStore = 
                new UserStore<ApplicationUser>(new IdentityDataContext());

            UserManager = new UserManager<ApplicationUser>(userStore);

            var roleStore = 
                new RoleStore<ApplicationRole>(new IdentityDataContext());

            RoleManager = new RoleManager<ApplicationRole>(roleStore);
        }
        [Authorize]
        public ActionResult Index()
        {

            var orders = db.Orders
                .Where(i => i.UserName == User.Identity.Name).Select(i => new UserOrderModel()
                {
                    Id = i.Id,
                    OrderNumber = i.OrderNumber,
                    OrderTime = i.OrderTime,
                    OrderState = i.OrderState,
                    Total = i.Total
                }).OrderByDescending(i=>i.OrderTime).ToList();


            return View(orders);
        }
        [Authorize]
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
                    OrderLines = i.OrderLines.Select(o=>new OrderLineModel()
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
        
        // GET: Account
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Register model)
        {

            if (ModelState.IsValid)
            {
                //Kayıt

                var user = new ApplicationUser();
                user.Name = model.Name;
                user.Surname = model.Surname;
                user.Email = model.Email;
                user.UserName = model.UserName;

                   IdentityResult result = UserManager.Create(user, model.Password);

                   if (result.Succeeded)
                   {
                       //Kullanıcı oluşturuldu
                        if (RoleManager.RoleExists("user"))
                        {
                           UserManager.AddToRole(user.Id, "user");
                        }

                        return RedirectToAction("Login", "Account");

                   }




            }
            else
            {
                ModelState.AddModelError("RegisterUserError","Kullanıcı oluşturulamadı.");
            }
            


            return View(model);
        }



        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login model, string ReturnUrl)
        {

            if (ModelState.IsValid)
            {
                //Giriş
                var user = UserManager.Find(model.UserName, model.Password);

                if (user != null)
                {
                    //Kullanıcı Mevcut
                    //ApplicationCookie

                    var authManager = HttpContext.GetOwinContext().Authentication;

                    var identityclaims = UserManager.CreateIdentity(user, "ApplicationCookie");
                    var authProperties=new AuthenticationProperties();
                    authProperties.IsPersistent = model.RememberMe;

                    authManager.SignIn(authProperties,identityclaims);
                    if (!String.IsNullOrEmpty(ReturnUrl))
                    {
                        return Redirect(ReturnUrl);
                    }

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("LoginUserError","Mevcut kullanıcı bulunamadı.");
                }

            }

            return View(model);
        }

        // GET: Account
        public ActionResult Logout()
        {

            var authManager = HttpContext.GetOwinContext().Authentication;

            authManager.SignOut();

            return RedirectToAction("Index","Home");
        }
    }
}