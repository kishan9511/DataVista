using Microsoft.AspNetCore.Mvc;

namespace DataVista.Web.Areas.Admin.Controllers;

public class CredentialController : Controller
{
    public IActionResult Login()
    {
        return View();
    }
}
