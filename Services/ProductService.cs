using Microsoft.EntityFrameworkCore;
using ShoppingList.Contracts;
using ShoppingList.Data;
using ShoppingList.Models;

namespace ShoppingList.Services
{
    public class ProductService : IProductService
    {
        private readonly ShoppingListDbContext _context;

        public ProductService(ShoppingListDbContext context)
        {
            _context = context;
        }

        async public Task AddAsync(ProductViewModel model)
        {
            throw new NotImplementedException();
        }

        async public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        async public Task<IEnumerable<ProductViewModel>> GetAllAsync()
        {
            return await _context.Products
                .AsNoTracking()
                .Select(x => new ProductViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                })
                .ToListAsync();
        }

        async public Task<ProductViewModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        async public Task UpdateAsync(ProductViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
