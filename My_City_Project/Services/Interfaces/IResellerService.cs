using My_City_Project.Model.Entities;
using System.Collections.Generic;

namespace My_City_Project.Services.Interfaces
{
    public interface IResellerService
    {
        List<Reseller> GetAllResellers();
        Reseller GetResellerById(Guid id);
        void CreateReseller(Reseller reseller);
        void UpdateReseller( Reseller reseller);
        void DeleteReseller(Guid id);
    }
}
