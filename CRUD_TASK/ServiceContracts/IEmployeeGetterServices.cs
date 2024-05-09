using Infra.Entities;

namespace ServiceContracts;
using System.Threading.Tasks;
 using   Infra.Entities;

public interface IEmployeeGetterServices
{
    public Task<Employee> GetEmployeeById(int? id);
    public  Task<Employee> GetEmployeeByName(string name);
    public  Task<List<Employee?>> GetAllEmployee();


}