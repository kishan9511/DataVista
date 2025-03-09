using Microsoft.AspNetCore.Mvc;

namespace DataVista.Web.Controllers;

public class AdminController : Controller
{
    public IActionResult DashBoard()
    {
        return View();
    }


    public IActionResult UserRegistration()
    {
        return View();
    }

}
