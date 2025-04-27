using Microsoft.AspNetCore.Mvc;

namespace DataVista.Web.Areas.Admin.Controllers;

public class ConfigurationController : Controller
{
    public IActionResult Role()
    {
        return View();
    }
}
