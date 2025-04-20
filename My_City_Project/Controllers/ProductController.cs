using Microsoft.AspNetCore.Mvc;
using My_City_Project.Data;
using My_City_Project.Entities;

namespace My_City_Project.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public ProductController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = _context.Products.ToList();
            return Ok(products);
        }

        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return Ok("Ürün eklendi");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, Product product)
        {
            var value = _context.Products.Find(id);
            if (value == null)
                return NotFound("Ürün bulunamadı");

            value.ProductName = product.ProductName;
            value.ProductPrice = product.ProductPrice;
            _context.SaveChanges();
            return Ok("Ürün güncellendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null)
                return NotFound("Ürün bulunamadı");

            _context.Products.Remove(product);
            _context.SaveChanges();
            return Ok("Ürün silindi");
        }
    }
}
