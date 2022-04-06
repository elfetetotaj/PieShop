using Microsoft.AspNetCore.Mvc;
using PieShop.Models;
using PieShop.ViewModels;

namespace PieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepozitory;
        private readonly ICategoryRepository _categoryRepozitory;

        public PieController(IPieRepository pieRepository,ICategoryRepository categoryRepository)
        {
            _pieRepozitory = pieRepository;
            _categoryRepozitory = categoryRepository;
        }

        public ViewResult List()
        {
            PiesListViewModel piesListViewModel = new PiesListViewModel();
            piesListViewModel.Pies = _pieRepozitory.AllPies;

            piesListViewModel.CurrentCategory = "Chesse cake";
            return View(piesListViewModel);
        }
    }
}
