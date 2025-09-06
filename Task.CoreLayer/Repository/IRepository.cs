using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Task6.CoreLayer.Repository
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(int Id);
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAllWithIncluding(params string[] include);
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
    }
}
