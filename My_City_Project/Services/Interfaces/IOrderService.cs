using My_City_Project.Model.Entities;
using System.Collections.Generic;

namespace My_City_Project.Services.Interfaces
{
    public interface IOrderService
    {
        List<Order> GetAllOrders();
        Order GetOrderById(int id);
        void CreateOrder(Order order);
        void UpdateOrder(int id, Order updatedOrder);
        void DeleteOrder(int id);
    }
}
