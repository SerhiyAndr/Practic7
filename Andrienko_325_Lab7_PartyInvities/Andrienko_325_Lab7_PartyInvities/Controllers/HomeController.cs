using Andrienko_325_Lab7_PartyInvities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace Andrienko_325_Lab7_PartyInvities.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Доброе утро" : "Доброго дня";
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guest)
        {
            if (ModelState.IsValid)
                //Нужно отправить данные нового гостя по электронной почте 
                //Организатору вечеринки.
                return View("Thanks", guest);
            else
                //Обнаружена ошибка проверки достоверности
                return View();
        }
    }
}