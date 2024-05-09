using AggregratorServices.AggregatorServices;
using Infra.Entities;

namespace crud;

public class ProductService(ProductAggregatorServices productAggregatorServices)
{
    private readonly ProductAggregatorServices _productAggregatorServices = productAggregatorServices;



    public async Task<Product?> GetProduct(int? id)
    {
        try
        {
            var product = await _productAggregatorServices.ProductGetterServices.GetProduct(id);
            return product;
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine($"Argument error: {ex.Message}");
            throw;
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Argument out of range error: {ex.Message}");
            throw;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            throw;
        }
    }

    public async Task<List<Product?>> GetProducts()
    {
        try
        {
            var products = await _productAggregatorServices.ProductGetterServices.GetAllProducts();
            return products;
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine($"Argument error: {ex.Message}");
            throw;
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Argument out of range error: {ex.Message}");
            throw;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            throw;
        }
    }

    //public async Task<Product?> GetProductByName(string name)
    //{
    //    try
    //    {
    //        var product = await _productAggregatorServices.ProductGetterServices.GetProductByName(name);
    //        return product;
    //    }
    //    catch (ArgumentNullException ex)
    //    {
    //        Console.WriteLine($"Argument error: {ex.Message}");
    //        throw;
    //    }
    //    catch (ArgumentOutOfRangeException ex)
    //    {
    //        Console.WriteLine($"Argument out of range error: {ex.Message}");
    //        throw;
    //    }
    //    catch (Exception ex)
    //    {
    //        Console.WriteLine($"An error occurred: {ex.Message}");
    //        throw;
    //    }
    //}

    public async Task<bool> AddProduct(Product? product)
    {
        try
        {
            var result = await _productAggregatorServices.ProductAddersServices.AddProduct(product);

            return true;
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine($"Argument error: {ex.Message}");
            throw;
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Argument out of range error: {ex.Message}");
            throw;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            throw;
        }
    }


    public async Task<bool?> UpdateProduct(Product product)
    {
        try
        {
            var updatedProduct =
                await _productAggregatorServices.ProductUpdaterServices.UpdateProduct(product);
            return true;
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine($"Argument error: {ex.Message}");
            throw;
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Argument out of range error: {ex.Message}");
            throw;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            throw;
        }
    }

    public async Task<bool> DeleteProduct(int? id)
    {
        try
        {
            var result = await _productAggregatorServices.ProductDeleterServices.DeleteProduct(id);
            return true;
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine($"Argument error: {ex.Message}");
            throw;
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Argument out of range error: {ex.Message}");
            throw;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            throw;
        }
    }


}