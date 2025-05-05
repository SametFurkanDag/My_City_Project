using My_City_Project.Model.Entities;
using System.Collections.Generic;

namespace My_City_Project.Services.Interfaces
{
    public interface IPlaceService
    {
        List<Places> GetAllPlaces();
        Places GetPlaceById(Guid id);
        void CreatePlace(Places place);
        void DeletePlace(Guid id);
        void UpdatePlace(Places place);
    }
}
