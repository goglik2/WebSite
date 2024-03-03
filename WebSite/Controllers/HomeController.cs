using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebSite.Models;

namespace WebSite.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Models.ExponList> modelList = new List<Models.ExponList>();

        modelList.Add(new Models.ExponList() { ID = "0", ExpName = "Название экспоната 1", ImageUrl = "https://img.tourister.ru/files/2/4/6/2/1/6/1/1/original.jpg", Description = "Описание экспоната 1" });
        modelList.Add(new Models.ExponList() { ID = "1", ExpName = "Название экспоната 2", ImageUrl = "https://i.pinimg.com/originals/d7/a4/d6/d7a4d6e3c45cb7fb4ecbb73137f3d974.jpg", Description = "Описание экспоната 2" });
        modelList.Add(new Models.ExponList() { ID = "2", ExpName = "Название экспоната 3", ImageUrl = "https://img.tourister.ru/files/2/4/6/2/1/6/1/1/original.jpg", Description = "Описание экспоната 3" });
        modelList.Add(new Models.ExponList() { ID = "3", ExpName = "Название экспоната 4", ImageUrl = "https://i.pinimg.com/originals/d7/a4/d6/d7a4d6e3c45cb7fb4ecbb73137f3d974.jpg", Description = "Описание экспоната 4" });
        modelList.Add(new Models.ExponList() { ID = "4", ExpName = "Название экспоната 5", ImageUrl = "https://img.tourister.ru/files/2/4/6/2/1/6/1/1/original.jpg", Description = "Описание экспоната 5" });
        
        return View(modelList); // передача списка моделей в представление
    }
    
    public IActionResult Index2()
    {
        List<Models.ExponList> modelList = new List<Models.ExponList>();

        modelList.Add(new Models.ExponList() { ID = "5", ExpName = "Название экспоната 6", ImageUrl = "https://img.tourister.ru/files/2/4/6/2/1/6/1/1/original.jpg", Description = "Описание экспоната 1" });
        modelList.Add(new Models.ExponList() { ID = "6", ExpName = "Название экспоната 7", ImageUrl = "https://i.pinimg.com/originals/d7/a4/d6/d7a4d6e3c45cb7fb4ecbb73137f3d974.jpg", Description = "Описание экспоната 2" });
        modelList.Add(new Models.ExponList() { ID = "7", ExpName = "Название экспоната 8", ImageUrl = "https://img.tourister.ru/files/2/4/6/2/1/6/1/1/original.jpg", Description = "Описание экспоната 3" });
        modelList.Add(new Models.ExponList() { ID = "8", ExpName = "Название экспоната 9", ImageUrl = "https://i.pinimg.com/originals/d7/a4/d6/d7a4d6e3c45cb7fb4ecbb73137f3d974.jpg", Description = "Описание экспоната 4" });
        modelList.Add(new Models.ExponList() { ID = "9", ExpName = "Название экспоната 10", ImageUrl = "https://img.tourister.ru/files/2/4/6/2/1/6/1/1/original.jpg", Description = "Описание экспоната 5" });
        
        return View(modelList); // передача списка моделей в представление
    }
    
    public IActionResult Index3()
    {
        List<Models.ExponList> modelList = new List<Models.ExponList>();

        modelList.Add(new Models.ExponList() { ID = "10", ExpName = "Название экспоната 11", ImageUrl = "https://img.tourister.ru/files/2/4/6/2/1/6/1/1/original.jpg", Description = "Описание экспоната 1" });
        modelList.Add(new Models.ExponList() { ID = "11", ExpName = "Название экспоната 12", ImageUrl = "https://i.pinimg.com/originals/d7/a4/d6/d7a4d6e3c45cb7fb4ecbb73137f3d974.jpg", Description = "Описание экспоната 2" });
        modelList.Add(new Models.ExponList() { ID = "12", ExpName = "Название экспоната 13", ImageUrl = "https://img.tourister.ru/files/2/4/6/2/1/6/1/1/original.jpg", Description = "Описание экспоната 3" });
        modelList.Add(new Models.ExponList() { ID = "13", ExpName = "Название экспоната 14", ImageUrl = "https://i.pinimg.com/originals/d7/a4/d6/d7a4d6e3c45cb7fb4ecbb73137f3d974.jpg", Description = "Описание экспоната 4" });
        modelList.Add(new Models.ExponList() { ID = "14", ExpName = "Название экспоната 15", ImageUrl = "https://img.tourister.ru/files/2/4/6/2/1/6/1/1/original.jpg", Description = "Описание экспоната 5" });
        
        return View(modelList); // передача списка моделей в представление
    }

    public IActionResult Expon()
    {
        List<Models.ExponInfoList> infolist = new List<Models.ExponInfoList>();
        
        infolist.Add(new Models.ExponInfoList() { ID = "0", Name = "Описание экспоната 1", Image = "https://img.tourister.ru/files/2/4/6/2/1/6/1/1/original.jpg",  Info = "Описание эксспоната 1"});
        infolist.Add(new Models.ExponInfoList() { ID = "1", Name = "Описание экспоната 2", Image = "https://i.pinimg.com/originals/d7/a4/d6/d7a4d6e3c45cb7fb4ecbb73137f3d974.jpg",  Info = "Описание экспоната 2"});
        infolist.Add(new Models.ExponInfoList() { ID = "2", Name = "Описание экспоната 3", Image = "https://img.tourister.ru/files/2/4/6/2/1/6/1/1/original.jpg",  Info = "Описание эксспоната 3"});
        infolist.Add(new Models.ExponInfoList() { ID = "3", Name = "Описание экспоната 4", Image = "https://i.pinimg.com/originals/d7/a4/d6/d7a4d6e3c45cb7fb4ecbb73137f3d974.jpg",  Info = "Описание экспоната 4"});
        return View(infolist);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}