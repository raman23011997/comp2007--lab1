using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab1.Controllers
{
    public class productController : Controller
    {
        // GET: product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult details(String product)
        {
            ViewBag.Message= "You selected product:"+product;

            return View();
        }
    }
}