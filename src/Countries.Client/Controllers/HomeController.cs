using Countries.Client.ViewModels;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Persistence;

namespace Countries.Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository<Country> _repository;

        public HomeController(IRepository<Country> repository)
        {
            this._repository = repository;
        }
        public IActionResult Index()
        {
            
            CountriesListViewModel model=new CountriesListViewModel()
            {
                Title="Countries List",
                Countries=_repository.GetAll()
            };
            return View(model);
        }

        public ActionResult Details(int id)
        {

            CountriesDetailsViewModel model = new CountriesDetailsViewModel()
            {
                Title = "Countries Details",
                Country = _repository.Get(id)
            };
            return View(model);
        }
    }
}