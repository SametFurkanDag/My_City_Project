using Microsoft.AspNetCore.Mvc;
using My_City_Project.Data;
using My_City_Project.Model.Entities;
using System.Collections.Generic;

namespace My_City_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public CartController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetCart()
        {
            var cartItems = _context.Carts.ToList();
            var products = _context.Products.ToList();

            foreach (var item in cartItems)
            {
                foreach (var product in products)
                {
                    if (product.ProductId == item.ProductId)
                    {
                        item.ProductName = product.ProductName;
                        item.TotalPrice = product.ProductPrice * item.Quantity;
                        break;
                    }
                }
            }

            return Ok(cartItems);
        }
        [HttpPost]
        public IActionResult AddToCart(Cart item)
        {
            var product = _context.Products.Find(item.ProductId);
            if (product == null)
                return NotFound("Ürün bulunamadı");

            item.ProductName = product.ProductName;
            item.TotalPrice = product.ProductPrice * item.Quantity;

            _context.Carts.Add(item);
            _context.SaveChanges();
            return Ok(item);
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteFromCart(int id)
        {
            var item = _context.Carts.Find(id); 
            if (item == null)
                return NotFound();

            _context.Carts.Remove(item);
            _context.SaveChanges();
            return Ok("Ürün sepetten silindi");
        }
    }
}
