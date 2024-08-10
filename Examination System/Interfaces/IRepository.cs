using System.Linq.Expressions;

namespace Examination_System.Interfaces
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAll();
        IQueryable<T> Get(Expression<Func<T,bool>> predicate);
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(int id);
        void HardDelete(int id);
        T GetWithTrackingById(int id);
        void SaveChanges();
        T First(Expression<Func<T, bool>> predicate);
    }
}
