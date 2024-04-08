using EntityFrameWorkExample.Models;
using EntityFrameWorkExample.Services;
using EntityFrameWorkExample.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkExample.Controllers
{
    internal class CityController
    {
        private readonly ICityService _cityService;
        public CityController()
        {
            _cityService = new CityService();
        }
        public async Task GetAllByCountryId()
        {
             Console.WriteLine("add country id");
            int countryId = int.Parse(Console.ReadLine());
            var cities = await _cityService.GetAllByCountryIdAsync(countryId);
            foreach (var city in cities)
            {
                 Console.WriteLine(city.Name+" "+city.Country.Name);
            }
        }


        public async Task CreateAsync()
        {
            Console.WriteLine("add city name");
            string cityName = Console.ReadLine();
            Console.WriteLine("add CountryId ");
            int countryId = Convert.ToInt32(Console.ReadLine());

            _cityService.CreateAsync(new City { Name = cityName, CountryId = countryId });


        }
        public async Task DeleteAsync()
        {
            Console.WriteLine("add id");
            int id = Convert.ToInt32(Console.ReadLine());
            await _cityService.DeleteAsync(id);

        }
        public async Task GetAllAsync()
        {
            var datas = await _cityService.GetAllAsync();
            foreach (var data in datas)
            {
                Console.WriteLine(data.Name+" "+data.CountryId);
            }
        }
        public async Task GetByIdAsync()
        {
            Console.WriteLine("Add id");
            int id = Convert.ToInt32(Console.ReadLine());



            var data = await _cityService.GetByIdAsync(id);

            Console.WriteLine(data.Name);


        }
    }
}
