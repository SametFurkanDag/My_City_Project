using My_City_Project.Model.Entities;
using System.Collections.Generic;

namespace My_City_Project.Repositories.Interfaces
{
    public interface IOrderItemRepository
    {
        List<OrderItem> GetAllOrderItems();
        OrderItem GetOrderItemById(Guid id);
        void AddOrderItem(OrderItem orderItem);
        void UpdateOrderItem(OrderItem orderItem);
        void DeleteOrderItem(Guid id);
    }
}
