using System.Diagnostics;
using AspNetCoreViewModelSample.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AspNetCoreViewModelSample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HomeViewModel viewModel = GetHomeViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Index(SearchInputModel inputModel)
        {
            var viewModel = GetHomeViewModel();
            viewModel.InputModel = inputModel;
            return View(viewModel);
        }

        private HomeViewModel GetHomeViewModel()
        {
            return new HomeViewModel
            {
                Title = "Titolo della pagina",
                Text = "Benvenuto nel nostro sito web!",
                InputModel = new SearchInputModel()
            };
        }
    }
}
