using My_City_Project.Model.Entities;
using System.Collections.Generic;

namespace My_City_Project.Services.Interfaces
{
    public interface ICartService
    {
        List<Cart> GetAll();
        Cart GetById(Guid id);
        void Add(Cart cart);
        void Update(Cart cart);
        void Delete(Guid id);
    }
}
