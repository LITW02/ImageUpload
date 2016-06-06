using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication28.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase image)
        {
            string extension = Path.GetExtension(image.FileName);
            image.SaveAs(Server.MapPath("~/Images/") + Guid.NewGuid() + extension);
            return Redirect("/home/index");
        }

    }
}
