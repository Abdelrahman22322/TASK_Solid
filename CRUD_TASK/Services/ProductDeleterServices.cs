using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using crud.Data.Config;

using Infra.Entities;
using Microsoft.EntityFrameworkCore;
using ServiceContracts;

namespace Services
{
      public class ProductDeleterServices(ApplicationContext context) : IProductsDeleterServices
      {    private readonly ApplicationContext _context = context;

          public async Task<bool> DeleteProduct(int? product)
          {
              if (product == null)
              {
                  throw new ArgumentNullException(nameof(product));
              }

              var productToDelete = await _context.Products.FirstOrDefaultAsync(p => p.Id == product.Id);
              if (productToDelete == null)
                  return false;

              _context.Products.Remove(productToDelete);
              await _context.SaveChangesAsync();

              return true;
          }
    }
}
