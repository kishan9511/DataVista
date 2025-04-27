using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataVista.Repository.IRepository;

public interface IRepository<T> where T : class
{
    Task<T?> GetFirstOrDefaultAsync(Expression<Func<T, bool>> filter, string? includeProperties = null, bool IsTracked = true);
    T? GetFirstOrDefault(Expression<Func<T, bool>> filter, string? includeProperties = null, bool IsTracked = true);
    Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> filter, string? includeProperties = null);
    IEnumerable<T> GetAll(Expression<Func<T, bool>> filter, string? includeProperties = null);
    void Add(T entity);
    void AddRange(IEnumerable<T> entities);
    void Remove(T entity);
    void RemoveRange(IEnumerable<T> entities);
    Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
    Task<int> CountAsync(Expression<Func<T, bool>> expression);
}
