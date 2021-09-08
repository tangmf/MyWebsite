using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Art()
        {
            return View();
        }

        public IActionResult Websites()
        {
            return View();
        }
    }
}
