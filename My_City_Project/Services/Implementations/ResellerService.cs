using My_City_Project.Model.Entities;
using My_City_Project.Repositories.Interfaces;
using My_City_Project.Services.Interfaces;
using System.Collections.Generic;

namespace My_City_Project.Services.Implementations
{
    public class ResellerService : IResellerService
    {
        private readonly IResellerRepository _resellerRepository;

        public ResellerService(IResellerRepository resellerRepository)
        {
            _resellerRepository = resellerRepository;
        }

  
        public void CreateReseller(Reseller reseller)
        {
            _resellerRepository.AddReseller(reseller);
        }

      
        public void UpdateReseller(Reseller reseller)
        {
            _resellerRepository.UpdateReseller(reseller);
        }

       
        public void DeleteReseller(Guid id)
        {
            _resellerRepository.DeleteReseller(id);
        }

       
        public List<Reseller> GetAllResellers()
        {
            return _resellerRepository.GetAllResellers();
        }

      
        public Reseller GetResellerById(Guid id)
        {
            return _resellerRepository.GetResellerById(id);
        }
    }
}
