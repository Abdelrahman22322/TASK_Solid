using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using crud.Data.Config;
using Infra.Entities;
using ServiceContracts;

namespace Services
{
     public class EmployeeAdderServices(ApplicationContext context) : IEmployeeAdderServices
     {
        private readonly ApplicationContext _context = context;

        public async Task<bool> AddEmployee(Employee? employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee));
            }

            if (employee.Id == 0)
            {
                throw new ArgumentException("Employee Id cannot be 0");
            }

            if (string.IsNullOrEmpty(employee.Name))
            {
                throw new ArgumentException("Employee Name cannot be null or empty");
            }

            if (_context.Employees.Any(e => e.Name == employee.Name))
            {
                throw new ArgumentException("Employee Name already exists");
                return false;
            }
            
            await _context.Employees.AddAsync(employee);
            return true;
        }
    }
}
