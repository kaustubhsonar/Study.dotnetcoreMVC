using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Study.dotnetcoreMVC.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        public ViewResult AboutUs()
        {
            return View();
        }
        public ViewResult ContactUs()
        {
            return View();
        }
        public ViewResult pathtest()
        {
            return View("Views/Shared/ContactUs.cshtml");//Absolute path
            //return View("../Shared/ContactUs");//relative path
        }
    }
}
