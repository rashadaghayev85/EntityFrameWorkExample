using EntityFrameWorkExample.Helpers.Exceptions;
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
    internal class SettingController
    {
        private readonly ISettingService _settingService;
        public SettingController()
        {
            _settingService=new SettingService();   
        }
        public async Task GetAllAsync()
        {
            var datas=await _settingService.GetAllAsync();
            foreach (var data in datas)
            {
                Console.WriteLine(data.Address + " " + data.Email + " " + data.Phone);
            }
        }
        public async Task GetByIdAsync()
        {
            Console.WriteLine("Add id");
            int id = Convert.ToInt32(Console.ReadLine());

            try
            {

                  var data = await _settingService.GetByIdAsync(id);
               
                Console.WriteLine(data.Address + " " + data.Email + " " + data.Phone);

            }
            catch (Exception ex)
            {
                 Console.WriteLine(ex.Message);

            }
        }
        public async Task CreateAsync()
        {
            Console.WriteLine("add address");
            string address=Console.ReadLine();
            Console.WriteLine("add email");
            string email=Console.ReadLine();
            Console.WriteLine("add phone");
            string phone=Console.ReadLine();


            //Setting setting = new();
            //setting.Address = address;// belede etmek olar
            await _settingService.CreateAsync(new Setting { Address = address, Email = email, Phone = phone });
        }

        public async Task DeleteAsync()
        {
            Console.WriteLine("add id");
            int id=Convert.ToInt32(Console.ReadLine());
            await _settingService.DeleteAsync(id);

        }
    }
}
