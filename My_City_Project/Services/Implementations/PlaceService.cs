using My_City_Project.Model.Entities;
using My_City_Project.Repositories.Interfaces;
using My_City_Project.Services.Interfaces;
using System.Collections.Generic;

namespace My_City_Project.Services.Implementations
{
    public class PlaceService : IPlaceService
    {
        private readonly IPlaceRepository _placeRepository;

        public PlaceService(IPlaceRepository placeRepository)
        {
            _placeRepository = placeRepository;
        }

        public List<Places> GetAllPlaces()
        {
            return _placeRepository.GetAllPlaces();
        }

        public Places GetPlaceById(Guid id)
        {
            return _placeRepository.GetPlaceById(id);
        }

        public void CreatePlace(Places place)
        {
            _placeRepository.AddPlace(place);
        }

        public void UpdatePlace(Places place)
        {
            _placeRepository.UpdatePlace(place);
        }

        public void DeletePlace(Guid id)
        {
            _placeRepository.DeletePlace(id);
        }
    }
}
