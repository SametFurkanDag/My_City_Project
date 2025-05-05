using My_City_Project.Model.Entities;
using My_City_Project.Repositories.Interfaces;
using My_City_Project.Services.Interfaces;
using System.Collections.Generic;
using System; 

namespace My_City_Project.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAllProducts();
        }

        public Product GetById(Guid id)
        {
            return _productRepository.GetProductById(id);
        }

        public void Add(Product product)
        {
            _productRepository.AddProduct(product);
        }

        public void Update(Product product)
        {
            _productRepository.UpdateProduct(product);
        }

        public void Delete(Guid id)
        {
            _productRepository.DeleteProduct(id);
        }
    }
}
