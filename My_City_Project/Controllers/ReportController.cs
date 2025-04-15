using Microsoft.AspNetCore.Mvc;
using My_City_Project.Data;
using My_City_Project.Entities;

namespace My_City_Project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReportController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public ReportController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Reports.ToList());
        }

        [HttpPost]
        public IActionResult Post(Report report)
        {
            _context.Reports.Add(report);
            _context.SaveChanges();
            return CreatedAtAction(nameof(Get), new { id = report.ReportId }, report);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var report = _context.Reports.Find(id);
            if (report == null) return NotFound();

            _context.Reports.Remove(report);
            _context.SaveChanges();
            return Ok();
        }
    }
}
