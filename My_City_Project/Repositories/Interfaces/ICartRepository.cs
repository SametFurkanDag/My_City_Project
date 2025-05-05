using My_City_Project.Model.Entities;
using System.Collections.Generic;

namespace My_City_Project.Repositories.Interfaces
{
    public interface ICartRepository
    {
        List<Cart> GetAllCarts();
        Cart GetCartById(Guid id);
        void AddCart(Cart cart);
        void UpdateCart(Cart cart);
        void DeleteCart(Guid id);
    }
}
