using My_City_Project.Model.Entities;
using System.Collections.Generic;

namespace My_City_Project.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        List<Order> GetAllOrders();
        Order GetOrderById(int id);
        void AddOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(int id);
    }
}
