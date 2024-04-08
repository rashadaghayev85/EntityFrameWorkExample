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
    internal class CountryService : ICountryService
    {
        private readonly AppDbContext _context;
        public CountryService()
        {
            _context = new AppDbContext();
        }
        public async Task CreateAsync(Country country)
        {
           await _context.AddAsync(country);
           await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var data=await _context.Countries.FirstOrDefaultAsync(m => m.Id == id);
            _context.Countries.Remove(data);
            await _context.SaveChangesAsync();  
        }

        public async Task<List<Country>> GetAllAsync()
        {
            return await _context.Countries.ToListAsync();  
        }

        public async Task<Country> GetByIdAsync(int id)
        {
           return  await _context.Countries.FirstOrDefaultAsync(m => m.Id == id);
        }
    }
}
