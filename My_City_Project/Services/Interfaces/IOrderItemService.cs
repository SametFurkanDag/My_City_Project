using My_City_Project.Model.Entities;
using System.Collections.Generic;

namespace My_City_Project.Services.Interfaces
{
    public interface IOrderItemService
    {
        List<OrderItem> GetAllOrderItems();
        OrderItem GetOrderItemById(Guid id);
        void CreateOrderItem(OrderItem item);
        void UpdateOrderItem(Guid id, OrderItem updatedItem);
        void DeleteOrderItem(Guid id);
    }
}
