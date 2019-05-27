using Domain.Entities;
using Domain.Services;
using Persistence;
using System.Collections.Generic;

namespace Domain.Application
{
    public class CountriesService : ICountriesService
    {
        private readonly IRepository<Country> repository;

        public CountriesService(IRepository<Country> repository)
        {
            this.repository = repository;
        }
        IEnumerable<Country> ICountriesService.GetCountries()
        {
            return repository.GetAll();
        }

        Country ICountriesService.GetCountry(int id)
        {
           return repository.Get(id);
        }
    }
}
