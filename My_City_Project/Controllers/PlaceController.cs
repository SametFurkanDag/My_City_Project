using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using My_City_Project.Data;
using My_City_Project.Model.Entities;

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
        public IActionResult GetAllPlaces()
        {
            var places = _context.Places.ToList();
            return Ok(places);
        }

        [HttpPost]
        public IActionResult CreatePlace(Places place)
        {
            _context.Places.Add(place);
            _context.SaveChanges();
            return Ok("Yer eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePlace(int id)
        {
            var place = _context.Places.Find(id);
            if (place == null)
                return NotFound("Yer bulunamadı");

            _context.Places.Remove(place);
            _context.SaveChanges();
            return Ok("Yer silindi");
        }
    }
}
