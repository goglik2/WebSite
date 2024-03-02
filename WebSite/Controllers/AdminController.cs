using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebSite.Models;

namespace WebSite.Controllers;

public class AdminController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult fesgfxcmjlkhkjfdh()
    {
        // Загружаем начальный файл, например, файл по умолчанию
        var model = new Models.FileModel 
        {
            FileName = "Index.cshtml",
            Content = System.IO.File.ReadAllText("Views/Home/Index.cshtml")
        };
        
        return View(model);
    }
    
    [HttpPost]
    public IActionResult UploadFile(IFormFile file)
    {
        if (file != null && file.Length > 0)
        {
            using (var reader = new StreamReader(file.OpenReadStream()))
            {
                var model = new FileModel
                {
                    FileName = file.FileName,
                    Content = reader.ReadToEnd()
                };

                return View("EditFile", model);
            }
        }

        return RedirectToAction("fesgfxcmjlkhkjfdh");
    }

    [HttpPost]
    public IActionResult SaveFile(FileModel model)
    {
        if (!string.IsNullOrEmpty(model.FileName))
        {
            System.IO.File.WriteAllText(model.Path + model.FileName, model.Content);
            return RedirectToAction("fesgfxcmjlkhkjfdh");
        }

        return RedirectToAction("fesgfxcmjlkhkjfdh", model);
    }
    
    public IActionResult AdminPanelCheck(string name, string password)
    {
        if (name == "Grisha" && password == "21042008")
        {
            
            return RedirectToAction("fesgfxcmjlkhkjfdh");
        }
        
        return RedirectToAction("Index");
    }
}