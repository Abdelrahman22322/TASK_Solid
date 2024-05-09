using ServiceContracts;

namespace AggregratorContracts.AggregatorServices;

public interface IProductAggregatorServices
{
    IProductAddersServices ProductAddersServices { get; }

    IProductGetterServices ProductGetterServices { get; }

    IProductsDeleterServices ProductDeleterServices { get; }

    IProductsUpdaterServices ProductUpdaterServices { get; }
}