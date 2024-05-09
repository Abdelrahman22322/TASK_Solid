
using Infra.Entities;

namespace ServiceContracts;

public interface IEmployeeAdderServices
{
    public Task<bool> AddEmployee(Employee? employee);

}