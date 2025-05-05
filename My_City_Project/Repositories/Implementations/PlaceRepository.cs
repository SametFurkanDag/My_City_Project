using My_City_Project.Data;
using My_City_Project.Model.Entities;
using My_City_Project.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace My_City_Project.Repositories.Implementations
{
    public class PlaceRepository : IPlaceRepository
    {
        private readonly ApplicationContext _context;

        public PlaceRepository(ApplicationContext context)
        {
            _context = context;
        }

        public List<Places> GetAllPlaces()
        {
            return _context.Places.ToList();
        }

        public Places GetPlaceById(Guid id)
        {
            return _context.Places.Find(id);
        }

        public void AddPlace(Places place)
        {
            _context.Places.Add(place);
            _context.SaveChanges();
        }

        public void UpdatePlace(Places place)
        {
            _context.Places.Update(place);
            _context.SaveChanges();
        }

        public void DeletePlace(Guid id)
        {
            var place = _context.Places.Find(id);
            if (place != null)
            {
                _context.Places.Remove(place);
                _context.SaveChanges();
            }
        }
    }
}
