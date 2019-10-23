using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Register(string username,string email)
        {
            ViewBag.username = "abc";
            ViewBag.email = "gido@gmail.com";
            ViewData["chuoi~"] = username;

            return View();
        }
    }
}