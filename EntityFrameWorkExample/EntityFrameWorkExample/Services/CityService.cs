using EntityFrameWorkExample.Data;
using EntityFrameWorkExample.Models;
using EntityFrameWorkExample.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkExample.Services
{
    internal class CityService : ICityService
    {
        private readonly AppDbContext _context;
        public CityService()
        {
            _context = new AppDbContext();
        }

        public async Task CreateAsync(City city)
        {
            await _context.AddAsync(city);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var data=await _context.Cities.FirstOrDefaultAsync(m=>m.Id==id);
             _context.Cities.Remove(data);
            await _context.SaveChangesAsync();
        }

        public async Task<List<City>> GetAllAsync()
        {
            return await _context.Cities.ToListAsync();
        }

        public async Task<List<City>> GetAllByCountryIdAsync(int id)
        {
            return await _context.Cities.Include(m=>m.Country).Where(m => m.CountryId == id).ToListAsync();
             
        }

        public async Task<City> GetByIdAsync(int id)
        {
            return await _context.Cities.FirstOrDefaultAsync(m=>m.Id==id);
        }
    }
}
