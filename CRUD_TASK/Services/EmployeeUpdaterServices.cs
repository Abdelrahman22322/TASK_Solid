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
        public class EmployeeUpdaterServices(ApplicationContext context) : IEmployeeUpdaterServices
        {        private readonly ApplicationContext _context = context;

        public async Task<bool> UpdateEmployee(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee));
            }

            if (employee.Name is null)
            {
                throw new ArgumentNullException(nameof(employee.Name));

            }

            if (employee.Salary < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(employee.Salary));
            }

            if (_context.Employees.FindAsync(employee.Id) == null)
                
            {
                throw new InvalidOperationException("Employee not found");
                return false;

            }
            _context.Employees.Update(employee);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
