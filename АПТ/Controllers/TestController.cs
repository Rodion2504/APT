using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace АПТ.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            ViewBag.Message = "Hello world!";
            return View("Index");
        }
    }
}