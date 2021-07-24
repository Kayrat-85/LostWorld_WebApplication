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
    public class AnthropogenesisController : Controller
    {
        private readonly DataManager dataManager;
        //конструктор
        public AnthropogenesisController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public ActionResult AnthropogenesisPage(Guid id)
        {
            if (id != default)
            {
                return View("ShowAnthropogenesis", dataManager.AnthropogenesisHumans.GetAnthropogenesisById(id));
            }

            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageAnthropogenesis");
            return View(dataManager.AnthropogenesisHumans.GetAnthropogenesis());
        }
    }
}
