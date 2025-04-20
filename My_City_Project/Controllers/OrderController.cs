using Microsoft.AspNetCore.Mvc;
using My_City_Project.Data;
using My_City_Project.Entities;

namespace My_City_Project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public OrderController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllOrders()
        {
            return Ok(_context.Orders.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetOrderById(int id)
        {
            var order = _context.Orders.Find(id);
            if (order == null) return NotFound();
            return Ok(order);
        }

        [HttpPost]
        public IActionResult CreateOrder(Order order)
        {
            var cart = _context.Carts.Find(order.CartId);
            if (cart == null)
                return NotFound("Sepet bulunamadı");

            order.TotalAmount = cart.TotalPrice;
            order.OrderDate = DateTime.Now;

            _context.Orders.Add(order);
            _context.SaveChanges();
            return Ok(order);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateOrder(int id, Order updatedOrder)
        {
            var order = _context.Orders.Find(id);
            if (order == null) return NotFound();

            order.CartId = updatedOrder.CartId;
            order.TotalAmount = updatedOrder.TotalAmount;
            order.OrderDate = updatedOrder.OrderDate;

            _context.SaveChanges();
            return Ok(order);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteOrder(int id)
        {
            var order = _context.Orders.Find(id);
            if (order == null) return NotFound();

            _context.Orders.Remove(order);
            _context.SaveChanges();
            return Ok();
        }
    }
}
