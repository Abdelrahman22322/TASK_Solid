using ServiceContracts;
using IEmployeeAggregatorServices = AggregratorContracts.AggregatorServices.IEmployeeAggregatorServices;

namespace AggregratorServices.AggregatorServices
{
    public class EmployeeAggregatorServices(
        IEmployeeAdderServices employeeAdderServices,
        IEmployeeGetterServices employeeGetterServices,
        IEmployeeUpdaterServices employeeUpdaterServices,
        IEmployeeDeleterServices employeeDeleterServices)
        : IEmployeeAggregatorServices
    {
        public IEmployeeAdderServices EmployeeAdderServices { get; } = employeeAdderServices;
        public IEmployeeGetterServices EmployeeGetterServices { get; } = employeeGetterServices;
        public IEmployeeUpdaterServices EmployeeUpdaterServices { get; } = employeeUpdaterServices;
        public IEmployeeDeleterServices EmployeeDeleterServices { get; } = employeeDeleterServices;
    }
}