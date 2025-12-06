using HexagonalDemo.Application.Dtos;
using HexagonalDemo.Application.Ports;
using HexagonalDemo.Domain.Entities;

namespace HexagonalDemo.Application.UseCases
{
    public class GetProductUseCase
    {
        private readonly IProductRepository _repo;

        public GetProductUseCase(IProductRepository repo)
        {
            _repo = repo;
        }

        public async Task<ProductDto?> Execute(int id)
        {
            var product = await _repo.GetByIdAsync(id);

            if (product == null) return null;

            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name
            };
        }

        public async Task<List<ProductDto?>> getAllProduct()
        {
            var products = await _repo.GetAllAsync();

            if (products == null || !products.Any())
                return new List<ProductDto>();

            var result = products.Select(p => new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                // agrega más propiedades si las tienes
            }).ToList();

            return result;
        }
            
    }
}
