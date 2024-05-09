using ServiceContracts;

namespace AggregratorContracts.AggregatorServices;

public interface ICustomerAggregatorServices
{
    ICustomerGetterServices CustomerGetterServices { get; }
    ICustomerUpdaterServices CustomerUpdaterServices { get; }
    ICustomerAdderServices CustomerAdderServices { get; }
}