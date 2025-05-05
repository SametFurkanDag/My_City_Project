using Microsoft.AspNetCore.Mvc;
using My_City_Project.Model.Entities;
using My_City_Project.Services.Interfaces;
using System.Collections.Generic;

namespace My_City_Project.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:ApiVersion}/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpGet]
        public IActionResult GetAllCarts()
        {
            var carts = _cartService.GetAll();
            return Ok(carts);
        }

        [HttpGet("{id}")]
        public IActionResult GetCartById(Guid id)  
        {
            var cart = _cartService.GetById(id);
            if (cart == null)
                return NotFound("Sepet bulunamadı");
            return Ok(cart);
        }

        [HttpPost]
        public IActionResult CreateCart(Cart cart)
        {
            _cartService.Add(cart);
            return Ok("Sepet eklendi");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCart(Guid id, Cart cart)  
        {
            var existingCart = _cartService.GetById(id);
            if (existingCart == null)
                return NotFound("Sepet bulunamadı");

            _cartService.Update(cart);
            return Ok("Sepet güncellendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCart(Guid id)  
        {
            var existingCart = _cartService.GetById(id);
            if (existingCart == null)
                return NotFound("Sepet bulunamadı");

            _cartService.Delete(id);
            return Ok("Sepet silindi");
        }
    }
}
