using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.DataAccessLayer.Models;
namespace Task.businessLayer
{
    public interface IEmployeeServices
    {
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployeeById(int id);
        void AddEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int id);
        int GetEmployeeCount();
    }
}
