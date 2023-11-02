using Lesson02_Startup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;

namespace Lesson02_Startup.Controllers
{
    public class Exercise02Controller : Controller
    {
        //
        // GET: /Exercise02/
        public ActionResult Index()
        {
            Person p1 = new Person("Kristoffer", "Enevoldsen","Bøgevej 3","8000","Aarhus C");
            Person p2 = new Person("Kurt", "Hansen", "Vandvej 3", "6000", "Kolding");
            Person p3 = new Person("Ole", "Larsen", "Hammervej 3", "8200", "Aarhus N");

            p1.Birthday = new DateTime(2000,06,19);
            p2.Birthday = new DateTime(1905,12,20);
            p3.Birthday = new DateTime(1904,10,29);

            p1.addPhoneNumber("12345678");
            p1.addPhoneNumber("12345000");
            p1.addPhoneNumber("12000000");

            p2.addPhoneNumber("87654321");
            p2.addPhoneNumber("45553454");

            p3.addPhoneNumber("10101010");

            ViewBag.p1 = p1;
            ViewBag.p2 = p2;
            ViewBag.p3 = p3;

            List<Person> list = new List<Person>();
            list.Add(p1);
            list.Add(p2);
            list.Add(p3);

            return View(list);
        }
    }
}
