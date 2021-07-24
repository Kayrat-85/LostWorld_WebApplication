using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using theLostWorld.Domain;

namespace theLostWorld.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EditDinosaursController : Controller
    {
        private readonly DataManager dataManager;

        public EditDinosaursController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public ActionResult Predators_Admin()
        {
            return View(dataManager.DinosaursPredators.GetDinosaurs());
        }

        public ActionResult Herbivores_Admin()
        {
            return View(dataManager.DinosaursHerbivores.GetDinosaurs());
        }

        public ActionResult FlyingDinosaurs_Admin()
        {
            return View(dataManager.DinosaursFlying.GetDinosaurs());
        }

        public ActionResult AquaticDinosaurs_Admin()
        {
            return View(dataManager.DinosaursAquatic.GetDinosaurs());
        }
    }
}
