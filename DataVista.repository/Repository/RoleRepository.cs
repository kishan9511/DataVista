using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataVista.DataAccess.Models;
using DataVista.Repository.IRepository;

namespace DataVista.Repository.Repository;

public class RoleRepository : Repository<Role>, IRoleRepository
{
    private readonly DataVistaContext _db;
    public RoleRepository(DataVistaContext db) : base(db)
    {
        _db = db;
    }
}
