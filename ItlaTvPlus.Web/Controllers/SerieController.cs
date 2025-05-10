using ItlaTvPlus.Application.Services;
using ItlaTvPlus.Application.ViewModels.NewFolder.SeriesViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ItlaTvPlus.Web.Controllers
{
    public class SerieController : Controller
    {

        private readonly SerieService _sevice;

        public SerieController(SerieService sevice)
        {
            _sevice = sevice;
        }

        public async Task<IActionResult> Index()
        {
            var vm = await _sevice.GetSeriesWhithGenders();
            return View(vm);
        }

        public async Task<IActionResult> Create()
        {
            var almacen = await _sevice.GetSeriesWhithGendersCreate();
            return View("SaveandUpdateSerie", almacen);
        }

        [HttpPost]
        public async Task<IActionResult> Create(SaveSerieViewModel vm)
        {
            await _sevice.SaveSerieWithGenders(vm.Serie, vm.GendersId);
            return RedirectToRoute(new { controller = "Serie", action = "Index" });
        }
    }
}
