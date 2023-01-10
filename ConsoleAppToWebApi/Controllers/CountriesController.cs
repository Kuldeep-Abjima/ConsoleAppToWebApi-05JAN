using ConsoleAppToWebApi.Custom_Model_Binders;
using ConsoleAppToWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleAppToWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[BindProperties]
    public class CountriesController : ControllerBase
    {
        // [BindProperty(SupportsGet = true)]
        // public CountryModel CountryModelCountry { get; set; }

        // public int MyProperty { get; set; }
        //[HttpGet("{name}/{area}")]
        //public IActionResult AddCountry(string name, int postalCode)
        //{
        //    return Ok($"Name of country {name}, PostalCode {postalCode}");
        //}
        //public IActionResult AddCountry()
        //{
        //    return Ok($"Name of country {this.CountryModelCountry.Name}, PostalCode {this.CountryModelCountry.PostalCode}, CountryPopulation {this.CountryModelCountry.CountryPopulation}");
        //}
        //[HttpPost("")]
        //public IActionResult AddCountry()
        //{
        //    return Ok($"Name {this.CountryModelCountry.Name}");
        //}
        //[HttpPost("")]
        //public IActionResult AddCountry([FromQuery] int id, [FromQuery] CountryModel country)
        //{
        //    return Ok($"Name {country.Name}");
        //}
        //[HttpPost("{name}/{postalCode}/{countryPopulation}")]
        //public IActionResult AddCountry([FromRoute] CountryModel country, [FromQuery] int id)
        //{
        //    return Ok($"Name {country.Name}");
        //}
        [HttpGet("search")]
          public IActionResult SearchCountries([ModelBinder(typeof(CustomBinder))] string[] countries)
        {
            return Ok(countries);
        }
        [HttpGet("{id}")]
        public IActionResult CountryDetail([ModelBinder(Name = "Id")]CountryModel country)
        {
            return Ok(country);
        }
    }
}
