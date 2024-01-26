using Microsoft.AspNetCore.Mvc;
using ShoppingList.Contracts;

namespace ShoppingList.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _productService.GetAllAsync();

            return View(model);
        }
    }
}
