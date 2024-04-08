﻿using EntityFrameWorkExample.Data;
using EntityFrameWorkExample.Helpers.Exceptions;
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
    internal class SettingService : ISettingService
    {
        private readonly AppDbContext _context;
        public SettingService()
        {
            _context = new AppDbContext();
        }
        public async Task CreateAsync(Setting setting)
        {
            await _context.AddAsync(setting);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int? id)
        {
            var data=await _context.Settings.FirstOrDefaultAsync(m => m.Id == id); 
            _context.Settings.Remove(data); 
            await _context.SaveChangesAsync();
        }

        public async Task<List<Setting>> GetAllAsync()
        {
            return await _context.Settings.ToListAsync();
        }

        public async Task<Setting> GetByIdAsync(int? id)
        {
            var data= await _context.Settings.FirstOrDefaultAsync(m => m.Id == id);
            if (data is null)  throw new NotFoundException("Data not found");
           return data;

        }

        public Task UpdateAsync(Setting setting)
        {
            throw new NotImplementedException();
        }
    }
}
