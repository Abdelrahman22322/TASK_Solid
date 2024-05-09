using ServiceContracts;

namespace AggregratorContracts.AggregatorServices;

public interface IEmployeeAggregatorServices
{
    IEmployeeAdderServices EmployeeAdderServices { get; }

    IEmployeeGetterServices EmployeeGetterServices { get; }

    IEmployeeUpdaterServices EmployeeUpdaterServices { get; }
     
   IEmployeeDeleterServices EmployeeDeleterServices { get; }
}