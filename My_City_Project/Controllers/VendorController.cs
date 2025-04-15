using Microsoft.AspNetCore.Mvc;
using My_City_Project.Data;
using My_City_Project.Entities;

namespace My_City_Project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VendorController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public VendorController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Vendors.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var vendor = _context.Vendors.Find(id);
            if (vendor == null) return NotFound();
            return Ok(vendor);
        }

        [HttpPost]
        public IActionResult Post(Vendor vendor)
        {
            _context.Vendors.Add(vendor);
            _context.SaveChanges();
            return Ok(vendor);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Vendor updatedVendor)
        {
            var vendor = _context.Vendors.Find(id);
            if (vendor == null) return NotFound();

            vendor.VendorName = updatedVendor.VendorName;
           

            _context.SaveChanges();
            return Ok(vendor);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var vendor = _context.Vendors.Find(id);
            if (vendor == null) return NotFound();

            _context.Vendors.Remove(vendor);
            _context.SaveChanges();
            return Ok();
        }
    }
}
