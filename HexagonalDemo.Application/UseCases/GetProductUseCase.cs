using HexagonalDemo.Application.Dtos;
using HexagonalDemo.Application.Ports;

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
    }
}
