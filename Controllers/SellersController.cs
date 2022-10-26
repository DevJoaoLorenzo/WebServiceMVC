using Microsoft.AspNetCore.Mvc;

namespace WebServiceMVC.Controllers;

public class SellersController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}