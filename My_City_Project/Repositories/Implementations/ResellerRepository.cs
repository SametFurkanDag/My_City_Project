using My_City_Project.Data;
using My_City_Project.Model.Entities;
using My_City_Project.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace My_City_Project.Repositories.Implementations
{
    public class ResellerRepository : IResellerRepository
    {
        private readonly ApplicationContext _context;

        public ResellerRepository(ApplicationContext context)
        {
            _context = context;
        }


        public List<Reseller> GetAllResellers()
        {
            return _context.Resellers.ToList();
        }

        public Reseller GetResellerById(Guid id)
        {
            return _context.Resellers.Find(id);
        }

        public void AddReseller(Reseller reseller)
        {
            _context.Resellers.Add(reseller);
            _context.SaveChanges();
        }

        public void UpdateReseller(Reseller reseller)
        {
            _context.Resellers.Update(reseller);
            _context.SaveChanges();
        }

        public void DeleteReseller(Guid id)
        {
            var reseller = _context.Resellers.Find(id);
            if (reseller != null)
            {
                _context.Resellers.Remove(reseller);
                _context.SaveChanges();
            }
        }
    }
}
