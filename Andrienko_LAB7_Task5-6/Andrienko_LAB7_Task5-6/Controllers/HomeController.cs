using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace Andrienko_LAB7_Task5_6.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int firstVal = 10;
            int secondVal = 5;
            int result = firstVal / secondVal;
            ViewBag.Message = "Отладка приложения ASP.NET MVC!";
            return View(result);
        }
    }
}