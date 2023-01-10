using ConsoleAppToWebApi.Custom_Model_Binders;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleAppToWebApi.Models
{
    [ModelBinder(typeof(CustomBinderCountryDetails))]
    public class CountryModel
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string CountryPopulation { get; set; }
        public string PostalCode { get; set; }

    }
}
