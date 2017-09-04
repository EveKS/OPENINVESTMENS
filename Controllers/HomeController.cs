using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OPENINVESTMENS.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Investors()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Rules()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Faq()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult News()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
