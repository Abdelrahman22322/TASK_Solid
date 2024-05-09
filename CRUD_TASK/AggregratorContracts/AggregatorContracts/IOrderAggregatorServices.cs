using ServiceContracts;

namespace AggregratorContracts.AggregatorServices;

public interface IOrderAggregatorServices
{
     IOrderAdderServices OrderAdderServices { get; }
      
     IOrderGetterServices OrderGetterServices { get; }

     IOrderUpdaterServices OrderUpdaterServices { get; }

    
}