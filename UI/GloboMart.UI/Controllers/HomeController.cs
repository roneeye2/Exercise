using GloboMart.Business;
using GloboMart.Framwork.Interface;
using GloboMart.Framwork.Interface.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GloboMart.UI.Controllers
{
    public class HomeController : Controller
    {
        public IProductDomain product { get; set; }

        public HomeController(IProductDomain product)
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
