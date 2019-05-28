using Domain.Entities;
using System.Collections.Generic;

namespace Countries.Client.ViewModels
{
    public class CountriesListViewModel
    {
        public string Title { get; set; }
        public IEnumerable<Country> Countries { get; set; }
    }
}
