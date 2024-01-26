using ShoppingList.Models;

namespace ShoppingList.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductViewModel>> GetAllAsync();

        Task<ProductViewModel> GetByIdAsync(int id);

        Task AddAsync(ProductViewModel model);

        Task UpdateAsync(ProductViewModel model);

        Task DeleteAsync(int id);
    }
}
