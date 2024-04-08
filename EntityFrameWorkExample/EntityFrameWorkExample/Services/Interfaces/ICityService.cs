using EntityFrameWorkExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkExample.Services.Interfaces
{
    internal interface ICityService
    {
        Task<List<City>> GetAllByCountryIdAsync(int id);
        Task<List<City>> GetAllAsync();
        Task<City> GetByIdAsync(int id);
        Task CreateAsync(City city);
        Task DeleteAsync(int id);
    }
}
