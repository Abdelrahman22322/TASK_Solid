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
     public class ProductAdderServices(ApplicationContext context) : IProductAddersServices
     {
        private readonly ApplicationContext _context = context;

        public async Task<Product> AddProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }

            if (string.IsNullOrWhiteSpace(product.Name))
            {
                throw new ArgumentException("Product name cannot be empty", nameof(product.Name));
            }

            if (product.Price <= 0)
            {
                throw new ArgumentException("Product price cannot be less than or equal to zero", nameof(product.Price));
            }

            var existingProduct = await _context.Products.FirstOrDefaultAsync(x => x.Name == product.Name);
            if (existingProduct != null)
            {
                throw new InvalidOperationException("Product with this name already exists");
            }

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            return product;
        }

    }
}
