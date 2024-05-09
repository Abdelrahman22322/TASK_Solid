using ServiceContracts;
using ICustomerAggregatorServices = AggregratorContracts.AggregatorServices.ICustomerAggregatorServices;


namespace AggregratorServices.AggregatorServices;

public class CustomerAggregatorServices(
    ICustomerGetterServices customerGetterServices,
    ICustomerUpdaterServices customerUpdaterServices,
    ICustomerAdderServices customerAdderServices)
    : ICustomerAggregatorServices
{
    public ICustomerGetterServices CustomerGetterServices { get; } = customerGetterServices;
    public ICustomerUpdaterServices CustomerUpdaterServices { get; } = customerUpdaterServices;
    public ICustomerAdderServices CustomerAdderServices { get; } = customerAdderServices;
}