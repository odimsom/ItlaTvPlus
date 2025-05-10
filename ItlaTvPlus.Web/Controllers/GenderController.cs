using ItlaTvPlus.Application.Services;
using ItlaTvPlus.Application.ViewModels.NewFolder.GenderViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ItlaTvPlus.Web.Controllers
{
    public class GenderController : Controller
    {

        private readonly GenderService _service;

        public GenderController(GenderService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var vm = await _service.GetAll();
            return View(vm);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("SaveGender", new GenderViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Create(GenderViewModel vm)
        {
            await _service.Save(vm);
            return RedirectToRoute(new { controller = "Gender", action = "Index" });
        }

        public async Task<IActionResult> Delete([FromRoute]int id)
        {
            await _service.Delete(id);
            return RedirectToRoute(new { controller = "Gender", action = "Index" });
        }
    }
}
