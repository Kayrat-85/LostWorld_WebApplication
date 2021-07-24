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
    public class NewsController : Controller
    {
        private readonly DataManager dataManager;
        //конструктор
        public NewsController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public ActionResult NewsPage(Guid id)
        {
            if (id != default)
            {
                return View("ShowNews", dataManager.ServiceItems.GetServiceItemById(id));
            }

            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageNews");
            return View(dataManager.ServiceItems.GetServiceItems());
        }


    }
}
