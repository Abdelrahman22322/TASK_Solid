using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using crud.Data.Config;

using Infra.Entities;
using Microsoft.EntityFrameworkCore;
using ServiceContracts;

namespace Services
{
    public class EmployeeGetterServices(ApplicationContext context) : IEmployeeGetterServices
    {
        private readonly ApplicationContext _context = context;

        


        public async Task<Employee> GetEmployeeById(int? id)
        {
            if (id != null)
            {
                throw new ArgumentNullException(nameof(id));
            }


            if (!_context.Employees.Any(e => e.Id == id))
            {
                return null;
            }
            
           
            return await _context.Employees.FirstOrDefaultAsync(e => e.Id == id);


            }

        public async Task<Employee> GetEmployeeByName(string name)
        {
            if (name is null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (!_context.Employees.Any(e => e.Name == name))
            {
                return null;
            }
            return await _context.Employees.FirstOrDefaultAsync(e => e.Name == name);
        }

        public async Task<List<Employee?>> GetAllEmployee()
        {
            return await _context.Employees.ToListAsync();
        }
    }
}
