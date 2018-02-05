using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ScrapySharp.Extensions;
using ScrapySharp.Network;
using HtmlAgilityPack;

namespace asp_crypto_scrape.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()

        {
            

            return View("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "";

            return View();
        }

        
    }
}