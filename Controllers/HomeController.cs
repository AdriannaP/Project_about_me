using Microsoft.AspNetCore.Mvc;
using ProjectAboutMe.Services.Interfaces;
using System.Threading.Tasks;

namespace ProjectAboutMe.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISquareService _squareService;

        public HomeController(ISquareService squareService)
        {
            _squareService = squareService;
        }
        public async Task<IActionResult> Index()
        {
            var squareViewModels = await _squareService.GetAllActiveSquareViewModelsAsync();
            return View(squareViewModels);
        }
        public async Task<IActionResult> Details(int id)
        {
            return View(await _squareService.GetSquareViewModelByIdAsync(id));
        }
    }
}
