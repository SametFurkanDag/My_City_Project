using Microsoft.AspNetCore.Mvc;
using My_City_Project.Data;
using My_City_Project.Model.Entities;

namespace My_City_Project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderItemController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public OrderItemController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllOrderItems()
        {
            return Ok(_context.OrderItems.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetOrderItemById(int id)
        {
            var item = _context.OrderItems.Find(id);
            if (item == null) return NotFound();
            return Ok(item);
        }

        [HttpPost]
        public IActionResult CreateOrderItem(OrderItem item)
        {
            _context.OrderItems.Add(item);
            _context.SaveChanges();
            return Ok(item);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateOrderItem(int id, OrderItem updatedItem)
        {
            var item = _context.OrderItems.Find(id);
            if (item == null) return NotFound();

            item.OrderId = updatedItem.OrderId;
            item.ProductId = updatedItem.ProductId;
            item.Quantity = updatedItem.Quantity;
            item.Price = updatedItem.Price;

            _context.SaveChanges();
            return Ok(item);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteOrderItem(int id)
        {
            var item = _context.OrderItems.Find(id);
            if (item == null) return NotFound();

            _context.OrderItems.Remove(item);
            _context.SaveChanges();
            return Ok();
        }
    }
}
