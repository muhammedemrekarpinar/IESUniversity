using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using ShelteredV1.Identity;

namespace ShelteredV1.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        
        // GET: Admin
        private UserManager<ApplicationUser> UserManager;

        private RoleManager<ApplicationRole> RoleManager;

        public AdminController()
        {
            var userStore =
                new UserStore<ApplicationUser>(new IdentityDataContext());

            UserManager = new UserManager<ApplicationUser>(userStore);

            var roleStore =
                new RoleStore<ApplicationRole>(new IdentityDataContext());

            RoleManager = new RoleManager<ApplicationRole>(roleStore);
        }




        // GET: Admin
        public ActionResult Index()
        {
            return View(UserManager.Users);
        }
    }
}