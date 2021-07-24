using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using theLostWorld.Domain;
using theLostWorld.Domain.Entities;
using theLostWorld.Service;

namespace theLostWorld.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MammalsHerbivoresController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;

        public MammalsHerbivoresController(DataManager dataManager,
                        IWebHostEnvironment hostingEnvironment)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new MammalsHerbivores() :
                dataManager.MammalsHerbivores.GetMammalsById(id);
            return View(entity);
        }
        [HttpPost]
        public IActionResult Edit(MammalsHerbivores model, IFormFile titleImageFile)
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
                dataManager.MammalsHerbivores.SaveMammals(model);
                return RedirectToAction(nameof(HomeController.Index),
                                nameof(HomeController).CutController());
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.MammalsHerbivores.DeleteMammals(id);
            return RedirectToAction(nameof(HomeController.Index),
                        nameof(HomeController).CutController());
        }
    }
}
