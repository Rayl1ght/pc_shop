using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.EntityFrameworkCore;
using site.Data;
using site.Models;
using site.Models.Domain;


namespace Kours.Controllers
{
    public class ProductController : Controller
    {
        private readonly MVCMagazinDbContext mvcMagazinDbContext;

        public ProductController(MVCMagazinDbContext mvcMagazinDbContext)
        {
            this.mvcMagazinDbContext = mvcMagazinDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var Product = await mvcMagazinDbContext.Product.ToListAsync();
            return View(Product);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddpRroductViewModel addProductRequest)
        {
            var product = new Product()
            {
                Id = Guid.NewGuid(),
                Name = addProductRequest.Name,
                Price = addProductRequest.Price
            };

            await mvcMagazinDbContext.Product.AddAsync(product);
            await mvcMagazinDbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> View(Guid id)
        {
            var product = await mvcMagazinDbContext.Product.FirstOrDefaultAsync(x => x.Id == id);
            if (product != null)
            {
                var viewModel = new UpdateProductViewModel()
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price
                };
                return await Task.Run(() => View("View", viewModel));
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> View(UpdateProductViewModel model)
        {
            var product = await mvcMagazinDbContext.Product.FindAsync(model.Id);
            if (product != null)
            {
                product.Name = model.Name;
                product.Price = model.Price;

                await mvcMagazinDbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(UpdateProductViewModel model)
        {
            var product = await mvcMagazinDbContext.Product.FindAsync(model.Id);

            if (product != null)
            {
                mvcMagazinDbContext.Product.Remove(product);
                await mvcMagazinDbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }

}
