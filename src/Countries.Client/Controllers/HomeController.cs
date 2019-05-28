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
   

        public ActionResult Create()
        {
            CountriesEditViewModel vm = new CountriesEditViewModel()
            {
                Title = "Create Country",
                Country = new Country(),
                Edit=false

            };

            return View(vm);
        }

        [HttpPost]
        public ActionResult Create(Country country)
        {
            if (ModelState.IsValid)
            {
                _repository.Insert(country);
                return RedirectToAction("Index", "Home");
            }
            else
                return View(new CountriesEditViewModel()
                {
                    Title = "Create Country",
                    Country = country,
                    Edit = false

                });
        }


        public ActionResult Edit(int Id)
        {
            CountriesEditViewModel vm = new CountriesEditViewModel()
            {
                Title = "Edit Country",
                Country = _repository.Get(Id),
                Edit = true

            };

            return View("Create", vm);
        }

        [HttpPost]
        public ActionResult Edit(Country country)
        {
            if (ModelState.IsValid)
            {
                _repository.Update(country);
                _repository.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
                return View(new CountriesEditViewModel()
                {
                    Title = "Edit Country",
                    Country = country,
                    Edit = true

                });
        }

        public ActionResult Delete(int Id)
        {
            var c=_repository.Get(Id);
            if(c!=null)
                _repository.Delete(c);

            return RedirectToAction("Index", "Home");
        }





    }
}