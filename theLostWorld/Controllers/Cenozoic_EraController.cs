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
    public class Cenozoic_EraController : Controller
    {
        private readonly DataManager dataManager;

        public Cenozoic_EraController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public ActionResult Paleogene_period()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PagePaleogene"));
        }

        public ActionResult Neogene_period()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageNeogene"));
        }
        public ActionResult Quaternary_period()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageQuaternary"));
        }
    }
}
