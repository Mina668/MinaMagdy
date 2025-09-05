using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Task.DataAccessLayer;

namespace Task.CoreLayer.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly TaskDbContext _context;
        private readonly DbSet<T> _dbSet;   
        public Repository(TaskDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            try
            {
                return _dbSet.AsNoTracking().ToList();
            }
            catch (Exception)
            {
                return Enumerable.Empty<T>(); // never return null
            }
        }

        public T GetById(int id)
        {
            var keyName = _context.Model.FindEntityType(typeof(T))
                .FindPrimaryKey().Properties.Select(keyName => keyName.Name).Single();
            return _dbSet.AsNoTracking().FirstOrDefault(t => EF.Property<int>(t,keyName) == id);
        }

        

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }
        public void Update(T entity)
        {
            var entityType = _context.Model.FindEntityType(typeof(T));
            var keyName = entityType.FindPrimaryKey().Properties
                                    .Select(p => p.Name)
                                    .Single();

            // Get entity key value using reflection
            var entityId = entity.GetType().GetProperty(keyName).GetValue(entity);

            // Check if EF is already tracking an entity with this ID
            var local = _dbSet.Local
                .FirstOrDefault(e => e.GetType().GetProperty(keyName).GetValue(e).Equals(entityId));

            if (local != null)
            {
                // Detach the existing tracked entity
                _context.Entry(local).State = EntityState.Detached;
            }

            // Attach new entity and mark as modified
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(int Id)
        {
            var selectEntity = _dbSet.Find(Id);
            if (selectEntity != null)  {_dbSet.Remove(selectEntity);}
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate).AsNoTracking().ToList();
        }

        public IEnumerable<T> GetAllWithIncluding(params string[] include)
        {
            IQueryable<T> query = _dbSet.AsNoTracking();
            foreach (var includeProperty in include)
            {
                query = query.Include(includeProperty);
            }
            return query.AsNoTracking().ToList();
        }


       
    }
}
