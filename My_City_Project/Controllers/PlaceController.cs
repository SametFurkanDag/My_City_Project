using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using My_City_Project.Data;
using My_City_Project.Entities;

namespace My_City_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaceController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public PlaceController(ApplicationContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var places = _context.Places.ToList();
            return Ok(places);
        }
        [HttpPost]
        public IActionResult Add(Places places)
        {
            _context.Places.Add(places);
            _context.SaveChanges();
            return Ok("Yer eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var places = _context.Places.Find(id);
            if (places == null)
                return NotFound("Yer bulunamadı");

            _context.Places.Remove(places);
            _context.SaveChanges();
            return Ok("Yer silindi");
        }

    }
}
