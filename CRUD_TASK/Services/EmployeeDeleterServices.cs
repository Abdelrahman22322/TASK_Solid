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
      public class EmployeeDeleterServices(ApplicationContext context) : IEmployeeDeleterServices
      {
          public async Task<bool> DeleteEmployee(int? employee)
        {
           var e = context.Employees.Remove(employee);
           await context.SaveChangesAsync();
           return true;
        }
    }
}
