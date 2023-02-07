using Microsoft.AspNetCore.Mvc;
using Mission04_cji23.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission04_cji23.Controllers
{
    // pages controller
    public class PagesController : Controller
    {
        // index
        public IActionResult Index()
        {
            return View();
        }

        // grade calculator
        [HttpGet]
        public IActionResult GradeCalculator()
        {
            return View();
        }

        // grade calculator w/ model
        [HttpPost]
        public IActionResult GradeCalculator(GradeCalculatorModel model)
        {
            return View();
        }
    }
}
