using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace Given_Brittany_HW1.Controllers
{
    public class HomeController : Controller
    {
        // serving up a file from a controller, specifically my resume
        private readonly IWebHostEnvironment _environment;

        public HomeController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        // GET: /<controller>/

        public IActionResult Resume()
        {
            string path = _environment.WebRootPath + "/files/Resume.pdf";
            var stream = new FileStream(path, FileMode.Open);
            return File(stream, "application/pdf", "Resume.pdf");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Portfolio()
        {
            return View();
        }

        public IActionResult Journal()
        {
            return View();
        }

        public IActionResult Austin()
        {
            return View();
        }

        // relating to portfolio page
        public IActionResult DoubleFeature()
        {
            return View();
        }

        public IActionResult Evanesce()
        {
            return View();
        }

        public IActionResult FindingAtaraxia()
        {
            return View();
        }

        public IActionResult Ruby()
        {
            return View();
        }

    }
}
