using HexagonalDemo.Domain.Entities;

namespace HexagonalDemo.Application.Ports
{
    public interface IProductRepository
    {
        Task<Product?> GetByIdAsync(int id);
    }
}
