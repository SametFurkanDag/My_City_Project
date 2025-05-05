using My_City_Project.Model.Entities;
using System.Collections.Generic;

namespace My_City_Project.Repositories.Interfaces
{
    public interface IPlaceRepository
    {
        List<Places> GetAllPlaces();   
        Places GetPlaceById(Guid id);  
        void AddPlace(Places place);   
        void UpdatePlace(Places place); 
        void DeletePlace(Guid id);     
    }
}
