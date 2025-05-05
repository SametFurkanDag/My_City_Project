using My_City_Project.Model.Entities;
using System.Collections.Generic;
using System;

namespace My_City_Project.Services.Interfaces
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(Guid id);
        void Add(Product product);
        void Update(Product product);
        void Delete(Guid id);
    }
}
