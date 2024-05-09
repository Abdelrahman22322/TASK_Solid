
using Infra.Entities;

namespace ServiceContracts;

public interface IEmployeeDeleterServices
{
     public Task<bool> DeleteEmployee(int? employee);
}