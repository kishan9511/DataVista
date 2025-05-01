using System.Threading.Tasks;
using DataVista.DataAccess.Models;
using DataVista.Models.ViewModels;
using DataVista.Repository.IRepository;
using DataVista.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace DataVista.Web.Areas.Admin.Controllers;

public class ConfigurationController : Controller
{
    #region--Constructor--

    private readonly DataVistaContext _db;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IWebHostEnvironment _webHostEnvironment;
    public ConfigurationController(DataVistaContext db, IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
    {
        _db = db;
        _unitOfWork = unitOfWork;
        _webHostEnvironment = webHostEnvironment;
    }

    #endregion


    #region--Role--

    #region--GET METHOD--
    public async Task<IActionResult> Role(int? id)
    {
        var roleVM = new RoleVM();
        if (id.HasValue && id != 0)
        {
            var rol = await _unitOfWork.Role.GetFirstOrDefaultAsync(ro => ro.IsDeleted == false && ro.Id == id, IsTracked: false);
            if (rol == null)
            {
                TempData["error"] = STATIC_DATASETS.MError;
                return RedirectToAction();
            }
            roleVM.Role = rol;
        }
        return View(roleVM);
    }

    #endregion

    #region--View Table--
    public async Task<IActionResult> GetAllRole()
    {
        var dataList = await _unitOfWork.Role.GetAllAsync(r => r.IsDeleted == false);
        return Json(new { data = dataList });
    }

    #endregion

    #region--Delete--

    [HttpDelete]
    public async Task<IActionResult> DeleteRole(int id)
    {

        //------------Delete Data Code Below-----------
        var objFromDb = await _unitOfWork.Role
         .GetFirstOrDefaultAsync(r => r.IsDeleted == false && r.Id == id);

        if (objFromDb == null)
        {
            return Json(new { success = false, message = STATIC_DATASETS.MNotFound });
        }
        objFromDb.IsDeleted = true;
        //_unitOfWork.Role.Update(objFromDb);
        await _unitOfWork.SaveAsync();
        return Json(new { success = true, message = STATIC_DATASETS.MDelete });

    }

    #endregion




    #endregion


}
