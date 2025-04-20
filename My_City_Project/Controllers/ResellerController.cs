using Microsoft.AspNetCore.Mvc;
using My_City_Project.Data;
using My_City_Project.Model.Entities;

namespace My_City_Project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ResellerController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public ResellerController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllResellers()
        {
            var resellers = _context.Resellers.ToList();
            return Ok(resellers);
        }

        [HttpGet("{id}")]
        public IActionResult GetReseller(int id)
        {
            var reseller = _context.Resellers.Find(id);
            if (reseller == null) return NotFound();
            return Ok(reseller);
        }

        [HttpPost]
        public IActionResult CreateReseller(Reseller reseller)
        {
            _context.Resellers.Add(reseller);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetReseller), new { id = reseller.ResellerId }, reseller);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateReseller(int id, Reseller updatedReseller)
        {
            var reseller = _context.Resellers.Find(id);
            if (reseller == null) return NotFound();

            reseller.ResellerName = updatedReseller.ResellerName;
            reseller.ResellerLocation = updatedReseller.ResellerLocation;

            _context.SaveChanges();
            return Ok(reseller);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteReseller(int id)
        {
            var reseller = _context.Resellers.Find(id);
            if (reseller == null) return NotFound();

            _context.Resellers.Remove(reseller);
            _context.SaveChanges();
            return Ok("Reseller deleted successfully");
        }
    }
}
