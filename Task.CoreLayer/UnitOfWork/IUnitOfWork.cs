using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.DataAccessLayer.Models;
using Task.CoreLayer.Repository;

namespace Task.CoreLayer.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Employee> EmployeeRepository { get; }
        int Complete(); 

    }
}
