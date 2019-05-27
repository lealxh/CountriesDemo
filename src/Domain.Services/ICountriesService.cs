using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Services
{
    public interface ICountriesService
    {
        IEnumerable<Country> GetCountries();
        Country GetCountry(int id) ;
    }
}
