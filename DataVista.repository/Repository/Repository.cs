using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataVista.DataAccess.Models;
using DataVista.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace DataVista.Repository.Repository;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly DbSet<T> _dbSet;
    public Repository(DataVistaContext db)
    {
        _dbSet = db.Set<T>();
    }
    public void Add(T entity)
    {
        _dbSet.Add(entity);
    }
    public void AddRange(IEnumerable<T> entities)
    {
        _dbSet.AddRange(entities);
    }
    public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
    {
        return await _dbSet.AnyAsync(expression);
    }
    public async Task<int> CountAsync(Expression<Func<T, bool>> expression)
    {
        return await _dbSet.CountAsync(expression);
    }
    public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> filter, string? includeProperties = null)
    {
        IQueryable<T> query = _dbSet.Where(filter);

        if (includeProperties != null)
        {
            foreach (var property in includeProperties.Split(',', StringSplitOptions.RemoveEmptyEntries))
                query = query.Include(property);
        }

        return await query.ToListAsync();
    }
    public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter, string? includeProperties = null)
    {
        IQueryable<T> query = _dbSet.Where(filter);

        if (includeProperties != null)
        {
            foreach (var property in includeProperties.Split(',', StringSplitOptions.RemoveEmptyEntries))
                query = query.Include(property);
        }

        return query.AsNoTracking().ToList();
    }
    public async Task<T?> GetFirstOrDefaultAsync(Expression<Func<T, bool>> filter, string? includeProperties = null, bool IsTracked = true)
    {
        IQueryable<T> query = IsTracked ? _dbSet : _dbSet.AsNoTracking();

        if (includeProperties != null)
        {
            foreach (var property in includeProperties.Split(',', StringSplitOptions.RemoveEmptyEntries))
                query = query.Include(property);
        }

        return await query.FirstOrDefaultAsync(filter);
    }
    public T? GetFirstOrDefault(Expression<Func<T, bool>> filter, string? includeProperties = null, bool IsTracked = true)
    {
        IQueryable<T> query = IsTracked ? _dbSet : _dbSet.AsNoTracking();

        if (includeProperties != null)
        {
            foreach (var property in includeProperties.Split(',', StringSplitOptions.RemoveEmptyEntries))
                query = query.Include(property);
        }

        return query.FirstOrDefault(filter);
    }
    public void Remove(T entity)
    {
        _dbSet.Remove(entity);
    }
    public void RemoveRange(IEnumerable<T> entities)
    {
        _dbSet.RemoveRange(entities);
    }
}
