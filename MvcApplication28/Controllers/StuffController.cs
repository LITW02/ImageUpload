using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Image.Stuff.Data;
using MvcApplication28.Models;

namespace MvcApplication28.Controllers
{
    public class StuffController : Controller
    {
        public ActionResult Index()
        {
            var manager = new StuffManager(Properties.Settings.Default.ConStr);
            IndexViewModel viewModel = new IndexViewModel { Stuff = manager.GetStuff() };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Upload(string word, HttpPostedFileBase image)
        {
            string extension = Path.GetExtension(image.FileName);
            string fileName = Guid.NewGuid() + extension;
            image.SaveAs(Server.MapPath("~/Images/") + fileName);
            var manager = new StuffManager(Properties.Settings.Default.ConStr);
            manager.Add(word, fileName);
            return Redirect("/stuff/index");
        }

    }
}
