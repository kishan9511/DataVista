using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataVista.Utility;

public class STATIC_DATASETS
{

    #region---ROLES---

    public const string KeyRole = "RoleId";
    public const string KeyUser = "UserId";

    public const int RoleIdAdmin = 1;


    #endregion

    #region--TOASTR NOTIFICATIONS--


    public const string MSave = "DATA SAVE SUCCESSFULLY!";
    public const string MUpdate = "DATA UPDATE!";
    public const string MDelete = "DELETE SUCCESSFULLY!";
    public const string MDuplicate = "DUPLICATE DATA!";
    public const string MNotFound = "NOT FOUND!";
    public const string MCantDelete = "YOU CAN NOT DELETE THIS DATA BECAUSE IT MAPPED!";
    public const string MError = "SOMETHING WENT WRONG, PLEASE TRY AGAIN!";
    public const string MActionNotAllowed = "Unable to execute the operation, YOUR ACCESS HAS BEEN DENIED!!";
    public const string MInvalidLogin = "Invalid Credential, try again !";
    #endregion

    #region--ACTION ACCESS CONTROL TYPE--

    public const int Add = 1;
    public const int EditOrUpdate = 2;
    public const int Delete = 3;
    public const int View = 4;
    public const int Cancel = 5;


    #endregion


}