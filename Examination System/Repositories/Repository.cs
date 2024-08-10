using Examination_System.Data;
using Examination_System.Interfaces;
using Examination_System.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Examination_System.Repositories
{
    public class Repository<T> : IRepository<T> where T :BaseModel 
    {
        ApplicationDbContext _context;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            //_context.Set<T>().Remove(entity);

            entity.Deleted = true;
            Update(entity);
        }

        public void Delete(int id)
        {
            T entity= _context.Find<T>(id);
            Delete(entity);
        }
        public void HardDelete(int id)
        {
            _context.Set<T>().Where(x=>x.Id==id).ExecuteDelete();
        }
        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().Where(x => !x.Deleted).AsNoTracking();
         //   return _context.Set<T>().Where(x => !x.Deleted).AsNoTrackingWithIdentityResolution();
        }

        public T GetById(int id)
        {
            return GetAll().FirstOrDefault(x=>x.Id==id);
        }

        public T GetWithTrackingById(int id)
        {
            return _context.Set<T>()
                .Where(x => !x.Deleted && x.Id == id)
                .AsTracking()
                .FirstOrDefault();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
             _context.Set<T>().Update(entity);
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return GetAll().Where(predicate);
        }
        public T  First(Expression<Func<T, bool>> predicate)
        {
            return GetAll().FirstOrDefault(predicate);
        }

        
    }
}
