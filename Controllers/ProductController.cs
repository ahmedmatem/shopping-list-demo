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

        [HttpPost]
        public async Task<IActionResult> Add(ProductViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            await productService.AddAsync(model);

            return RedirectToAction(nameof(Index));
        }

        //[HttpPost]
        //public Task<IActionResult> DeleteProduct(int id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
