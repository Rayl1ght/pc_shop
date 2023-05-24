using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.EntityFrameworkCore;
using site.Data;
using site.Models.Domain;
using site.Models;

namespace Kours.Controllers
{
    public class OrderController : Controller
    {
        private readonly MVCMagazinDbContext mvcMagazinDbContext;

        public OrderController(MVCMagazinDbContext mvcMagazinDbContext)
        {
            this.mvcMagazinDbContext = mvcMagazinDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var Order = await mvcMagazinDbContext.Order.ToListAsync();
            return View(Order);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddOrderViewModel addOrderRequest)
        {
            var order = new Order()
            {
                Id = Guid.NewGuid(),
                ClientID = addOrderRequest.ClientID,
                EmployeeId = addOrderRequest.EmployeeId,
                ProductId = addOrderRequest.ProductId,
                NumberContact = addOrderRequest.NumberContact,
                Data = addOrderRequest.Data
            };

            await mvcMagazinDbContext.Order.AddAsync(order);
            await mvcMagazinDbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> View(Guid id)
        {
            var order = await mvcMagazinDbContext.Order.FirstOrDefaultAsync(x => x.Id == id);
            if (order != null)
            {
                var viewModel = new UpdateOrderViewModel()
                {
                    Id = order.Id,
                    ClientID = order.ClientID,
                    EmployeeId = order.EmployeeId,
                    ProductId = order.ProductId,
                    NumberContact = order.NumberContact,
                    Data = order.Data
                };
                return await Task.Run(() => View("View", viewModel));
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> View(UpdateOrderViewModel model)
        {
            var order = await mvcMagazinDbContext.Order.FindAsync(model.Id);
            if (order != null)
            {
                order.ClientID = model.ClientID;
                order.EmployeeId = model.EmployeeId;
                order.ProductId = model.ProductId;
                order.NumberContact = model.NumberContact;
                order.Data = model.Data;

                await mvcMagazinDbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(UpdateOrderViewModel model)
        {
            var order = await mvcMagazinDbContext.Order.FindAsync(model.Id);

            if (order != null)
            {
                mvcMagazinDbContext.Order.Remove(order);
                await mvcMagazinDbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }

}

