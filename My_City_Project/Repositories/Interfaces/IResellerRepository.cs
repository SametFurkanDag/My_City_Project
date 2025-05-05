using My_City_Project.Model.Entities;
using System.Collections.Generic;

namespace My_City_Project.Repositories.Interfaces
{
    public interface IResellerRepository
    {
        List<Reseller> GetAllResellers();
        Reseller GetResellerById(Guid id);
        void AddReseller(Reseller reseller);
        void UpdateReseller(Reseller reseller);
        void DeleteReseller(Guid id);
    }
}
