using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using theLostWorld.Domain;

namespace theLostWorld.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EditMammalsController : Controller
    {
        //панель редактирования - SideBar
        private readonly DataManager dataManager;

        public EditMammalsController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }


        public ActionResult Predators_Admin()
        {
            return View(dataManager.MammalsPredator.GetMammals());
        }

        public ActionResult Herbivores_Admin()
        {
            return View(dataManager.MammalsHerbivores.GetMammals());
        }
    }
}
