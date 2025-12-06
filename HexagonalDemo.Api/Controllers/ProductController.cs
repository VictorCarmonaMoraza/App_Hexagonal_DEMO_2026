using HexagonalDemo.Application.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace HexagonalDemo.Api.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        private readonly GetProductUseCase _getProductUseCase;

        public ProductController(GetProductUseCase getProductUseCase)
        {
            _getProductUseCase = getProductUseCase;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _getProductUseCase.Execute(id);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpGet("allProduct")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _getProductUseCase.getAllProduct();
            return Ok(result);
        }
    }
}
