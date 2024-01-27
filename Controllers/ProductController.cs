using Microsoft.AspNetCore.Mvc;
using ShoppingList.Contracts;
using ShoppingList.Models;

namespace ShoppingList.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await productService.GetAllAsync();

            return View(model);
        }

        public IActionResult Add()
        {
            return View(new ProductViewModel());
        }

        //[HttpPost]
        //public Task<IActionResult> DeleteProduct(int id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
