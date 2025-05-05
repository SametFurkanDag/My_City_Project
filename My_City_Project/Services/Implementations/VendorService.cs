using My_City_Project.Model.Entities;
using My_City_Project.Repositories.Interfaces;
using My_City_Project.Services.Interfaces;
using System.Collections.Generic;

namespace My_City_Project.Services.Implementations
{
    public class VendorService : IVendorService
    {
        private readonly IVendorRepository _vendorRepository;

        public VendorService(IVendorRepository vendorRepository)
        {
            _vendorRepository = vendorRepository;
        }

        public void CreateVendor(Vendor vendor)
        {
            _vendorRepository.CreateVendor(vendor);
        }

        public void UpdateVendor(Vendor vendor)
        {
            _vendorRepository.UpdateVendor(vendor);
        }

        public void DeleteVendor(Guid id)
        {
            _vendorRepository.DeleteVendor(id);
        }

        public List<Vendor> GetAllVendors()
        {
            return _vendorRepository.GetAllVendors();  
        }

        public Vendor GetVendorById(Guid id)
        {
            return _vendorRepository.GetVendorById(id);  
        }
    }
}
