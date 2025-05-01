using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataVista.Repository.IRepository;

public interface IUnitOfWork
{
    public IRoleRepository Role { get; }






    Task SaveAsync();
    void SaveChanges();
}
