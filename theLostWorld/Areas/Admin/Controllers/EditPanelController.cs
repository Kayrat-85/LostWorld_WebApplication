using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using theLostWorld.Domain;

namespace theLostWorld.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EditPanelController : Controller
    {
        //панель редактирования - SideBar
        private readonly DataManager dataManager;

        public EditPanelController(DataManager manager)
        {
            this.dataManager = manager;
        }
        // Вкладки панели меню 
        public ActionResult News_admin()
        {
            return View(dataManager.ServiceItems.GetServiceItems());
        }

        public ActionResult Dinosaurs_admin()
        {
            return View();
        }

        public ActionResult Mammals_admin()
        {
            return View();
        }

        public ActionResult Anthropogenesis_admin()
        {
            return View();
        }

        //панель редактирования - главная страница, блоки 
        public ActionResult Homepage_admin()
        {
            return View();
        }

        public ActionResult Mesozoic_admin()
        {
            return View();
        }

        public ActionResult Cenozoic_admin()
        {
            return View();
        }

        public ActionResult Paleozoic_admin()
        {
            return View();
        }

        public ActionResult AboutMe_admin()
        {
            return View();
        }

    }
}
