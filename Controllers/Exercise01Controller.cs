using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson02_Startup.Controllers
{
    public class Exercise01Controller : Controller
    {
        

        public ActionResult Index()
        {
            // create a new product object with instance name glass
            Product glass = new Product("Wine glass", 160.50);
            Product kniv = new Product("Knife", 10.00);
            Product bin = new Product("Bin", 10.00);
            glass.ImageUrl = "grandcru.jpg";
            kniv.ImageUrl = "st_knife.jpg";
            bin.ImageUrl = "bin_35l.jpg";
            ViewBag.Glass = glass;
            ViewBag.Kniv = kniv;
            ViewBag.Bin = bin;
			
            return View();
        }

    }
}
