using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6.DataAccessLayer.Models;
using Task6.CoreLayer.Repository;

namespace Task6.CoreLayer.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Employee> EmployeeRepository { get; }
        int Complete(); 
            
    }
}
