using AggregratorContracts.AggregatorServices;
using ServiceContracts;

namespace AggregratorServices.AggregatorServices
{
public class ProductAggregatorServices(
    IProductAddersServices productAddersServices,
    IProductGetterServices productGetterServices,
    IProductsDeleterServices productDeleterServices,
    IProductsUpdaterServices productUpdaterServices)
    : IProductAggregatorServices
{
    public IProductAddersServices ProductAddersServices { get; } = productAddersServices;
    public IProductGetterServices ProductGetterServices { get; } = productGetterServices;
    public IProductsDeleterServices ProductDeleterServices { get; } = productDeleterServices;
    public IProductsUpdaterServices ProductUpdaterServices { get; } = productUpdaterServices;
}
}