
using EntityFrameWorkExample.Controllers;
using EntityFrameWorkExample.Data;

//AppDbContext context = new AppDbContext();
//void GetAllSettings()
//{
//    var datas = context.Settings.ToList();
//    foreach (var data in datas)
//    {
//        Console.WriteLine(data.Address + " " + data.Email + " " + data.Phone);
//    }

//}


//void GetById(int id)
//{
//    var data = context.Settings.FirstOrDefault(m => m.Id == id);

//    Console.WriteLine(data.Address + " " + data.Email + " " + data.Phone);

//}
//GetAllSettings();
//Console.WriteLine("---------------");
//GetById(2);


SettingController settingController = new SettingController();

//await settingController.GetAllAsync();
//await settingController.GetByIdAsync();
//await settingController.CreateAsync();
//Console.WriteLine("----------");
//await settingController.GetAllAsync();
//await settingController.DeleteAsync();
//await settingController.GetAllAsync();


CityController cityController = new CityController();
//await cityController.GetAllByCountryId();
//await cityController.GetAllAsync();
//await cityController.CreateAsync();   
// await cityController.DeleteAsync();
//await cityController.GetAllAsync();
//await cityController.GetByIdAsync();


CountryController countryController = new CountryController();  
//await countryController.GetByIdAsync();
//await countryController.GetAllAsync();
//awaitcountryController.DeleteAsync();
//await countryController.CreateAsync();
