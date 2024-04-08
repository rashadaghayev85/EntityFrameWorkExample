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
    internal class CountryController
    {
        private readonly ICountryService _countryService;
        public CountryController()
        {
            _countryService = new CountryService();       
        }

        public async Task CreateAsync()
        {
             Console.WriteLine("add Country name");
            string countryName=Console.ReadLine();
            Console.WriteLine("add Country population");
            int population = Convert.ToInt32(Console.ReadLine());

            _countryService.CreateAsync(new Country { Name=countryName,Population=population});


        }
        public async Task DeleteAsync()
        {
            Console.WriteLine("add id");
            int id = Convert.ToInt32(Console.ReadLine());
            await _countryService.DeleteAsync(id);

        }
        public async Task GetAllAsync()
        {
            var datas = await _countryService.GetAllAsync();
            foreach (var data in datas)
            {
                Console.WriteLine(data.Name+" "+data.Population);
            }
        }
        public async Task GetByIdAsync()
        {
            Console.WriteLine("Add id");
            int id = Convert.ToInt32(Console.ReadLine());

           

                var data = await _countryService.GetByIdAsync(id);

                Console.WriteLine(data.Name);

           
        }
    }
}
