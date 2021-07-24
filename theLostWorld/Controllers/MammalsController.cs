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
    public class MammalsController : Controller
    {
        private readonly DataManager dataManager;

        public MammalsController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public ActionResult PredatorsMammals(Guid id)
        {
            if (id != default)
            {
                return View("ShowPredators", dataManager.MammalsPredator.GetMammalsById(id));
            }

            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageMammalsPredators");
            return View(dataManager.MammalsPredator.GetMammals());
        }

        public ActionResult HerbivoresMammals(Guid id)
        {
            if (id != default)
            {
                return View("ShowHerbivores", dataManager.MammalsHerbivores.GetMammalsById(id));
            }

            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageMammalsHerbivores");
            return View(dataManager.MammalsHerbivores.GetMammals());
        }
    }
}
