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
    public class ProductGetterServices(ApplicationContext context) : IProductGetterServices
    {
        private readonly ApplicationContext _context = context;

        public async Task<Product> GetProduct(int? id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Id cannot be less than or equal to zero", nameof(id));
            }
            var existingProduct = await _context.Products.FindAsync(id);
            if (existingProduct == null)
            {
                throw new InvalidOperationException("Product with this id does not exist");
            }
            return  existingProduct;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return (await _context.Products.ToListAsync())!;
        }
    }
}
