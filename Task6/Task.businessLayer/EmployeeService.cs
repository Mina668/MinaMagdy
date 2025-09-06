using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6.CoreLayer.UnitOfWork;
using Task6.DataAccessLayer.Models;

namespace Task6.businessLayer
{
    public class EmployeeService : IEmployeeServices
    {
        private readonly IUnitOfWork _unitOfWork;
        public EmployeeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IEnumerable<Employee> GetEmployees()
        {
            return _unitOfWork.EmployeeRepository.GetAll();
        }
        public Employee GetEmployeeById(int id)
        {
            return _unitOfWork.EmployeeRepository.GetById(id);
        }

        public void AddEmployee(Employee employee)
        {
            _unitOfWork.EmployeeRepository.Add(employee);
           _unitOfWork.Complete();
        }
        public void UpdateEmployee(Employee employee)
        {
            _unitOfWork.EmployeeRepository.Update(employee);
            _unitOfWork.Complete();
        }

        public void DeleteEmployee(int id)
        {
            var existingEmployee = _unitOfWork.EmployeeRepository.GetById(id);
            if (existingEmployee != null)
            {
                _unitOfWork.EmployeeRepository.Delete(id);
                _unitOfWork.Complete();
            }
        }

        public int GetEmployeeCount()
        {
            return _unitOfWork.EmployeeRepository.GetAll().Count();
        }

      

      
    }
}
