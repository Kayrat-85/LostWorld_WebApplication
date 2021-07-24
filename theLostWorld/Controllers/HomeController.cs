using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using theLostWorld.Models;
using theLostWorld.Domain;

namespace theLostWorld.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult AboutMe()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageAboutMe"));
        }

        //метод для ссылки в footer
        public ActionResult MyWebProject()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageMyWebProject"));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
