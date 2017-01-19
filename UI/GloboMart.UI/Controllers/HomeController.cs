using GloboMart.Business;
using GloboMart.Framwork.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GloboMart.UI.Controllers
{
    public class HomeController : Controller
    {
        public IProduct product { get; set; }

        public HomeController(IProduct product)
        {
            this.product = product;
        }

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
