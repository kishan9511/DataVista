using DataVista.DataAccess.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using DataVista.Repository.IRepository;

namespace DataVista.Web.Areas.Admin.Controllers;

public class UserController : Controller
{

    private readonly IUnitOfWork _unitOfWork;

    private readonly DataVistaContext _db;
    private readonly IWebHostEnvironment _webHostEnvironment;
    private readonly IConfiguration _configuration;
    private readonly IEmailSender _emailSender;

    public UserController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment, DataVistaContext db, IEmailSender emailSender, IConfiguration configuration)
    {
        _unitOfWork = unitOfWork;
        _webHostEnvironment = webHostEnvironment;
        _db = db;
        _configuration = configuration;
        _emailSender = emailSender;
    }
    public IActionResult User()
    {
        return View();
    }
}
