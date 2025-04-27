using Microsoft.AspNetCore.Mvc;

namespace DataVista.Web.Areas.Admin.Controllers;

public class UserController : Controller
{
    public IActionResult User()
    {
        return View();
    }
}
