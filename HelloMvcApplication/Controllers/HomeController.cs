using HelloMvcApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloMvcApplication.Controllers
{
    public class HomeController : Controller
    {
        BookContext bookContext=new BookContext();
        public JsonResult Index()
        {
           return Json(bookContext.Books.ToList(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}