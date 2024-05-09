using ServiceContracts;
using IOrderAggregatorServices = AggregratorContracts.AggregatorServices.IOrderAggregatorServices;

namespace AggregratorServices.AggregatorServices
{
    public class OrderAggregatorServices(
        IOrderAdderServices orderAdderServices,
        IOrderGetterServices orderGetterServices,
        IOrderUpdaterServices orderUpdaterServices)
        : IOrderAggregatorServices
    {
        public IOrderAdderServices OrderAdderServices { get; } = orderAdderServices;
        public IOrderGetterServices OrderGetterServices { get; } = orderGetterServices;
        public IOrderUpdaterServices OrderUpdaterServices { get; } = orderUpdaterServices;
    }
}