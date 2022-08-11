using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EmpresariosBlazor.Data.Product
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Models.Product>> GetAll()
        {
            return await _context.Product.ToListAsync();
        }

        public async Task<bool> SaveProduct(Models.Product product)
        {
            _context.Product.Add(product);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}