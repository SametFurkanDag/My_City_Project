using My_City_Project.Model.Entities;
using My_City_Project.Repositories.Interfaces;
using My_City_Project.Services.Interfaces;
using System.Collections.Generic;

namespace My_City_Project.Services.Implementations
{
    public class CartService : ICartService
    {
        private readonly ICartRepository _cartRepository;

        public CartService(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public List<Cart> GetAll()
        {
            return _cartRepository.GetAllCarts();
        }

        public Cart GetById(Guid id)
        {
            return _cartRepository.GetCartById(id);
        }

        public void Add(Cart cart)
        {
            _cartRepository.AddCart(cart);
        }

        public void Update(Cart cart)
        {
            _cartRepository.UpdateCart(cart);
        }

        public void Delete(Guid id)
        {
            _cartRepository.DeleteCart(id);
        }

       
    }
}
