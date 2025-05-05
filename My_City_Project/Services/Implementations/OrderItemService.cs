using My_City_Project.Model.Entities;
using My_City_Project.Repositories.Interfaces;
using My_City_Project.Services.Interfaces;
using System.Collections.Generic;

namespace My_City_Project.Services.Implementations
{
    public class OrderItemService : IOrderItemService
    {
        private readonly IOrderItemRepository _orderItemRepository;

        public OrderItemService(IOrderItemRepository orderItemRepository)
        {
            _orderItemRepository = orderItemRepository;
        }

         public List<OrderItem> GetAllOrderItems()
        {
            return _orderItemRepository.GetAllOrderItems();
        }

        public OrderItem GetOrderItemById(Guid id)
        {
            return _orderItemRepository.GetOrderItemById(id);
        }

        public void CreateOrderItem(OrderItem item)
        {
            _orderItemRepository.AddOrderItem(item);
        }

        public void UpdateOrderItem(Guid id, OrderItem updatedItem)
        {
            _orderItemRepository.UpdateOrderItem(updatedItem);
        }

        public void DeleteOrderItem(Guid id)
        {
            _orderItemRepository.DeleteOrderItem(id);
        }
    }
}
