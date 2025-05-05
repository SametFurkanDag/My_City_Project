using My_City_Project.Model.Entities;
using System.Collections.Generic;

namespace My_City_Project.Services.Interfaces
{
    public interface IVendorService
    {
        List<Vendor> GetAllVendors();
        Vendor GetVendorById(Guid id);
        void CreateVendor(Vendor vendor);
        void UpdateVendor( Vendor vendor);
        void DeleteVendor(Guid id);
    }
}
