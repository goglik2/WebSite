using Microsoft.AspNetCore.Mvc;

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
        return View();
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