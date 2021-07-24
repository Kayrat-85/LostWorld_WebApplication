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
    public class Paleozoic_Era : Controller
    {
        private readonly DataManager dataManager;

        public Paleozoic_Era(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Cambrian_period()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageCambrian"));
        }

        public IActionResult Ordovician_period()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageOrdovician"));
        }

        public IActionResult Silurian_period()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageSilurian"));
        }

        public IActionResult Devonian_period()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageDevonian"));
        }

        public IActionResult Carboniferous_period()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageCarboniferous"));
        }

        public IActionResult Permian_period()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PagePermian"));
        }
    }
}
