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

        modelList.Add(new Models.ExponList() { ExpName = "Название экспоната 1", ImageUrl = "https://img.tourister.ru/files/2/4/6/2/1/6/1/1/original.jpg", Description = "Описание экспоната 1" });
        modelList.Add(new Models.ExponList() { ExpName = "Название экспоната 2", ImageUrl = "https://i.pinimg.com/originals/d7/a4/d6/d7a4d6e3c45cb7fb4ecbb73137f3d974.jpg", Description = "Описание экспоната 2" });
        modelList.Add(new Models.ExponList() { ExpName = "Название экспоната 3", ImageUrl = "https://img.tourister.ru/files/2/4/6/2/1/6/1/1/original.jpg", Description = "Описание экспоната 3" });
        modelList.Add(new Models.ExponList() { ExpName = "Название экспоната 4", ImageUrl = "https://i.pinimg.com/originals/d7/a4/d6/d7a4d6e3c45cb7fb4ecbb73137f3d974.jpg", Description = "Описание экспоната 4" });
        modelList.Add(new Models.ExponList() { ExpName = "Название экспоната 5", ImageUrl = "https://img.tourister.ru/files/2/4/6/2/1/6/1/1/original.jpg", Description = "Описание экспоната 5" });
        
        return View(modelList); // передача списка моделей в представление
    }
    
    public IActionResult Index2()
    {
        List<Models.ExponList> modelList = new List<Models.ExponList>();

        modelList.Add(new Models.ExponList() { ExpName = "Название экспоната 1", ImageUrl = "https://img.tourister.ru/files/2/4/6/2/1/6/1/1/original.jpg", Description = "Описание экспоната 1" });
        modelList.Add(new Models.ExponList() { ExpName = "Название экспоната 2", ImageUrl = "https://i.pinimg.com/originals/d7/a4/d6/d7a4d6e3c45cb7fb4ecbb73137f3d974.jpg", Description = "Описание экспоната 2" });
        modelList.Add(new Models.ExponList() { ExpName = "Название экспоната 3", ImageUrl = "https://img.tourister.ru/files/2/4/6/2/1/6/1/1/original.jpg", Description = "Описание экспоната 3" });
        modelList.Add(new Models.ExponList() { ExpName = "Название экспоната 4", ImageUrl = "https://i.pinimg.com/originals/d7/a4/d6/d7a4d6e3c45cb7fb4ecbb73137f3d974.jpg", Description = "Описание экспоната 4" });
        modelList.Add(new Models.ExponList() { ExpName = "Название экспоната 5", ImageUrl = "https://img.tourister.ru/files/2/4/6/2/1/6/1/1/original.jpg", Description = "Описание экспоната 5" });
        
        return View(modelList); // передача списка моделей в представление
    }
    
    public IActionResult Index3()
    {
        List<Models.ExponList> modelList = new List<Models.ExponList>();

        modelList.Add(new Models.ExponList() { ExpName = "Название экспоната 1", ImageUrl = "https://img.tourister.ru/files/2/4/6/2/1/6/1/1/original.jpg", Description = "Описание экспоната 1" });
        modelList.Add(new Models.ExponList() { ExpName = "Название экспоната 2", ImageUrl = "https://i.pinimg.com/originals/d7/a4/d6/d7a4d6e3c45cb7fb4ecbb73137f3d974.jpg", Description = "Описание экспоната 2" });
        modelList.Add(new Models.ExponList() { ExpName = "Название экспоната 3", ImageUrl = "https://img.tourister.ru/files/2/4/6/2/1/6/1/1/original.jpg", Description = "Описание экспоната 3" });
        modelList.Add(new Models.ExponList() { ExpName = "Название экспоната 4", ImageUrl = "https://i.pinimg.com/originals/d7/a4/d6/d7a4d6e3c45cb7fb4ecbb73137f3d974.jpg", Description = "Описание экспоната 4" });
        modelList.Add(new Models.ExponList() { ExpName = "Название экспоната 5", ImageUrl = "https://img.tourister.ru/files/2/4/6/2/1/6/1/1/original.jpg", Description = "Описание экспоната 5" });
        
        return View(modelList); // передача списка моделей в представление
    }

    public IActionResult Expon()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}