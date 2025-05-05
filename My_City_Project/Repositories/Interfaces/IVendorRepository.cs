using My_City_Project.Model.Entities;

namespace My_City_Project.Repositories.Interfaces
{
    public interface IVendorRepository
    {
        List<Vendor> GetAllVendors();
        Vendor GetVendorById(Guid id);
        void CreateVendor(Vendor vendor);
        void UpdateVendor( Vendor vendor);
        void DeleteVendor(Guid id);
    }
}
