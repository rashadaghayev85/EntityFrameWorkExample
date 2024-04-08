using EntityFrameWorkExample.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkExample.Data
{
    internal class AppDbContext:DbContext
    {
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Country>Countries { get; set; }
        public DbSet<City>Cities { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=RASHAD8088\\SQLEXPRESS;DataBase=EntityFrameWorkPb101Db;Trusted_Connection=true;TrustServerCertificate=true");   
        }
    }
}
