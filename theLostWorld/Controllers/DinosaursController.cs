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
    public class DinosaursController : Controller
    {
        private readonly DataManager dataManager;
        
        public DinosaursController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public ActionResult Predators(Guid id)
        {
            if (id != default)
            {
                return View("ShowPredators", dataManager.DinosaursPredators.GetDinosaursById(id));
            }

            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageDinosaursPredators");
            return View(dataManager.DinosaursPredators.GetDinosaurs());
        }

        public ActionResult Herbivores(Guid id)
        {
            if (id != default)
            {
                return View("ShowHerbivores", dataManager.DinosaursHerbivores.GetDinosaursById(id));
            }

            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageDinosaursHerbivores");
            return View(dataManager.DinosaursHerbivores.GetDinosaurs());
        }

        public ActionResult FlyingDinosaurs(Guid id)
        {
            if (id != default)
            {
                return View("ShowFlyings", dataManager.DinosaursFlying.GetDinosaursById(id));
            }

            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageDinosaursFlyings");
            return View(dataManager.DinosaursFlying.GetDinosaurs());
        }

        public ActionResult AquaticDinosaurs(Guid id)
        {
            if (id != default)
            {
                return View("ShowAquatic", dataManager.DinosaursAquatic.GetDinosaursById(id));
            }

            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageDinosaursAquatic");
            return View(dataManager.DinosaursAquatic.GetDinosaurs());
        }
    }
}
