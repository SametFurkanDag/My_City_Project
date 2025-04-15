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
        public IActionResult Get()
        {
            return Ok(_context.Resellers.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var reseller = _context.Resellers.Find(id);
            if (reseller == null) return NotFound();
            return Ok(reseller);
        }

        [HttpPost]
        public IActionResult Post(Reseller reseller)
        {
            _context.Resellers.Add(reseller);
            _context.SaveChanges();
            return CreatedAtAction(nameof(Get), new { id = reseller.ResellerId }, reseller);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Reseller updatedReseller)
        {
            var reseller = _context.Resellers.Find(id);
            if (reseller == null) return NotFound();

            reseller.ResellerName = updatedReseller.ResellerName;
            reseller.ResellerLocation = updatedReseller.ResellerLocation;

            _context.SaveChanges();
            return Ok(reseller);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var reseller = _context.Resellers.Find(id);
            if (reseller == null) return NotFound();

            _context.Resellers.Remove(reseller);
            _context.SaveChanges();
            return Ok();
        }
    }
}
