using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using theLostWorld.Models;
using theLostWorld.Domain;

namespace theLostWorld.Controllers
{
    public class Mesozoic_EraController : Controller
    {
        private readonly DataManager dataManager;

        public Mesozoic_EraController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public ActionResult Triassic_period()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageTriassic"));
        }

        public ActionResult Jurassic_period()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageJurassic"));
        }

        public ActionResult Cretaceous_period()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageCretaceous"));
        }
        
    }
}
