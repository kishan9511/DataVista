using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataVista.DataAccess.Models;
using DataVista.Repository.IRepository;

namespace DataVista.Repository.Repository;

public class UnitOfWork : IUnitOfWork
{
    private readonly DataVistaContext _db;

    public UnitOfWork(DataVistaContext db)
    {
        _db = db;
    }


    #region--Role--

    private IRoleRepository? _role;
    public IRoleRepository Role
    {
        get
        {
            _role ??= new RoleRepository(_db);
            return _role;
        }
    }

    #endregion






    #region--Save and Save Chnage--
    public async Task SaveAsync()
    {
        await _db.SaveChangesAsync();
    }
    public void SaveChanges()
    {
        _db.SaveChanges();
    }

    #endregion
}
