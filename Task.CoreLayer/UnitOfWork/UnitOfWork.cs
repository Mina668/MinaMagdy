using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.CoreLayer.Repository;
using Task.DataAccessLayer;
using Task.DataAccessLayer.Models;

namespace Task.CoreLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TaskDbContext _context;

        public IRepository<Employee> EmployeeRepository { get; }
        public UnitOfWork(TaskDbContext taskDbContext)
        {
             _context = taskDbContext;
              EmployeeRepository = new Repository<Employee>(_context);
        }
        public int Complete()
        {
            var rows = _context.SaveChanges();
            return rows;
        }

        public void Dispose()
        {
           _context.Dispose();
        }
    }
}
