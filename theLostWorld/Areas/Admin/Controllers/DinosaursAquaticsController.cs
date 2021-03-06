using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using theLostWorld.Domain;
using theLostWorld.Domain.Entities;
using theLostWorld.Service;
using System;
using System.IO;

namespace theLostWorld.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DinosaursAquaticsController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;
        //конструктор
        public DinosaursAquaticsController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new DinosaursAquatic() : dataManager.DinosaursAquatic.GetDinosaursById(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(DinosaursAquatic model, IFormFile titleImageFile)
        {
            if (ModelState.IsValid)
            {
                if (titleImageFile != null)
                {
                    model.TitleImagePath = titleImageFile.FileName;
                    using (var stream = new FileStream(Path.Combine(hostingEnvironment.
                        WebRootPath, "images/All_images/", titleImageFile.FileName), FileMode.Create))
                    {
                        titleImageFile.CopyTo(stream);
                    }
                }
                dataManager.DinosaursAquatic.SaveDinosaurs(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.DinosaursAquatic.DeleteDinosaurs(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}
