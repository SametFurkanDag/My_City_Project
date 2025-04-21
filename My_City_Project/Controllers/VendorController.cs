using Microsoft.AspNetCore.Mvc;
using My_City_Project.Data;
using My_City_Project.Model.Entities;

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
        public IActionResult GetAllVendors()
        {
            var vendors = _context.Vendors.ToList();
            return Ok(vendors);
        }

        [HttpGet("{id}")]
        public IActionResult GetVendorById(int id)
        {
            var vendor = _context.Vendors.Find(id);
            if (vendor == null) return NotFound("Satıcı bulunamadı");
            return Ok(vendor);
        }

        [HttpPost]
        public IActionResult CreateVendor(Vendor vendor)
        {
            _context.Vendors.Add(vendor);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetVendorById), new { id = vendor.VendorId }, vendor);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateVendor(int id, Vendor updatedVendor)
        {
            var vendor = _context.Vendors.Find(id);
            if (vendor == null) return NotFound("Satıcı bulunamadı");

            vendor.VendorName = updatedVendor.VendorName;

            _context.SaveChanges();
            return Ok(vendor);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteVendor(int id)
        {
            var vendor = _context.Vendors.Find(id);
            if (vendor == null) return NotFound("Satıcı bulunamadı");

            _context.Vendors.Remove(vendor);
            _context.SaveChanges();
            return Ok("Satıcı silindi");
        }
    }
}
