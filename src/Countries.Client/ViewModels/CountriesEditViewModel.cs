using Domain.Entities;

namespace Countries.Client.ViewModels
{
    public class CountriesEditViewModel
    {
        public string Title { get; set; }

        public bool Edit { get; set; }

        public Country Country { get; set; }
    }
}
