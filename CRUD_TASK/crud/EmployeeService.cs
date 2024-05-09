using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AggregratorContracts.AggregatorServices;
using Infra.Entities;

namespace crud
{
     public class EmployeeService(IEmployeeAggregatorServices employeeAggregateServices)
     {
         private readonly IEmployeeAggregatorServices _employeeAggregateServices = employeeAggregateServices;


         public async Task<Employee?> GetEmployee(int? id)
         {
             try
             {
                 var employee = await _employeeAggregateServices.EmployeeGetterServices.GetEmployeeById(id);
                 return employee;


             }
             catch (ArgumentNullException ex)
             {
                 Console.WriteLine($"Argument error: {ex.Message}");
                 throw;
             }
             catch (ArgumentOutOfRangeException ex)
             {
                 Console.WriteLine($"Argument out of range error: {ex.Message}");
                 throw;
             }
             catch (Exception ex)
             {
                 Console.WriteLine($"An error occurred: {ex.Message}");
                 throw;
             }
         }

         public async Task<List<Employee?>> GetEmployees()
         {
             try
             {
                 var employees = await _employeeAggregateServices.EmployeeGetterServices.GetAllEmployee();
                 return employees;
             }
             catch (ArgumentNullException ex)
             {
                 Console.WriteLine($"Argument error: {ex.Message}");
                 throw;
             }
             catch (ArgumentOutOfRangeException ex)
             {
                 Console.WriteLine($"Argument out of range error: {ex.Message}");
                 throw;
             }
             catch (Exception ex)
             {
                 Console.WriteLine($"An error occurred: {ex.Message}");
                 throw;
             }
         }

         public async Task<Employee?> GetEmployeeByName(string name)
         {
             try
             {
                 var employee = await _employeeAggregateServices.EmployeeGetterServices.GetEmployeeByName(name);
                 return employee;
             }
             catch (ArgumentNullException ex)
             {
                 Console.WriteLine($"Argument error: {ex.Message}");
                 throw;
             }
             catch (ArgumentOutOfRangeException ex)
             {
                 Console.WriteLine($"Argument out of range error: {ex.Message}");
                 throw;
             }
             catch (Exception ex)
             {
                 Console.WriteLine($"An error occurred: {ex.Message}");
                 throw;
             }

         }

         public async Task<bool?> AddEmployee(Employee employee)
         {
             try
             {
                 var newEmployee = await _employeeAggregateServices.EmployeeAdderServices.AddEmployee(employee);
                 return true;
             }
             catch (ArgumentNullException ex)
             {
                 Console.WriteLine($"Argument error: {ex.Message}");
                 throw;
             }
             catch (ArgumentOutOfRangeException ex)
             {
                 Console.WriteLine($"Argument out of range error: {ex.Message}");
                 throw;
             }
             catch (Exception ex)
             {
                 Console.WriteLine($"An error occurred: {ex.Message}");
                 throw;
             }
         }

         public async Task<bool?> UpdateEmployee(Employee employee)
         {
             try
             {
                 var updatedEmployee =
                     await _employeeAggregateServices.EmployeeUpdaterServices.UpdateEmployee(employee);
                 return true;
             }
             catch (ArgumentNullException ex)
             {
                 Console.WriteLine($"Argument error: {ex.Message}");
                 throw;
             }
             catch (ArgumentOutOfRangeException ex)
             {
                 Console.WriteLine($"Argument out of range error: {ex.Message}");
                 throw;
             }
             catch (Exception ex)
             {
                 Console.WriteLine($"An error occurred: {ex.Message}");
                 throw;
             }
         }

         public async Task<bool> DeleteEmployee(int? id)
         {
             try
             {
                 var result = await _employeeAggregateServices.EmployeeDeleterServices.DeleteEmployee(id);
                 return true;
             }
             catch (ArgumentNullException ex)
             {
                 Console.WriteLine($"Argument error: {ex.Message}");
                 throw;
             }
             catch (ArgumentOutOfRangeException ex)
             {
                 Console.WriteLine($"Argument out of range error: {ex.Message}");
                 throw;
             }
             catch (Exception ex)
             {
                 Console.WriteLine($"An error occurred: {ex.Message}");
                 throw;
             }
         }


     }
}
