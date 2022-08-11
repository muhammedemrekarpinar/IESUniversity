using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShelteredV1.Entity;

namespace ShelteredV1.Controllers
{
    [Authorize(Roles = "admin")]
    public class UploadController : Controller
    {
        // GET: Upload
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Upload()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Upload(Product p)
        {

            if (Request.Files.Count>0)
            {
                string filename = Path.GetFileName(Request.Files[0].FileName);
                string extension = Path.GetExtension(Request.Files[0].FileName);
                string url = "~/IMG/" + filename + extension;
                Request.Files[0].SaveAs(Server.MapPath(url));
                p.Image = "/IMG/" + filename + extension;
            }

            return View();
        }
    }
}