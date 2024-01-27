using Microsoft.EntityFrameworkCore;
using ShoppingList.Contracts;
using ShoppingList.Data;
using ShoppingList.Models;

namespace ShoppingList.Services
{
    public class ProductService : IProductService
    {
        private readonly ShoppingListDbContext context;

        public ProductService(ShoppingListDbContext context)
        {
            this.context = context;
        }

        public async Task AddAsync(ProductViewModel model)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(int id)
        {
            var product = await context.FindAsync<Product>(id);
            if (product != null)
            {
                context.Remove(product);
            }
        }

        public async Task<IEnumerable<ProductViewModel>> GetAllAsync()
        {
            return await context.Products
                .AsNoTracking()
                .Select(x => new ProductViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                })
                .ToListAsync();
        }

        public async Task<ProductViewModel> GetByIdAsync(int id)
        {
            var entity = await context.Products.FindAsync(id);

            return entity == null
                ? throw new ArgumentException("Invalid product.")
                : new ProductViewModel { Id = entity.Id, Name = entity.Name };
        }

        public async Task UpdateAsync(ProductViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
