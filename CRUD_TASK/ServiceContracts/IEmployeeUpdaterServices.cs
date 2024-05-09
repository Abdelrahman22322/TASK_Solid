
using Infra.Entities;

namespace ServiceContracts;

public interface IEmployeeUpdaterServices
{
    public Task<bool> UpdateEmployee(Employee employee);
}