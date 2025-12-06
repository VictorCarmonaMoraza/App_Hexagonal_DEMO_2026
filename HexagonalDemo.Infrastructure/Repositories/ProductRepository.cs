using HexagonalDemo.Application.Ports;
using HexagonalDemo.Domain.Entities;
using HexagonalDemo.Infrastructure.Data;

namespace HexagonalDemo.Infrastructure.Repositories
{
    public class ProductRepository: IProductRepository
    {
        public Task<Product?> GetByIdAsync(int id)
        {
            var product = FakeDb.Products.FirstOrDefault(p => p.Id == id);
            return Task.FromResult(product);
        }

        public Task<List<Product>> GetAllAsync()
        {
            var products = FakeDb.Products.ToList();
            return Task.FromResult(FakeDb.Products);
        }
    }
}
