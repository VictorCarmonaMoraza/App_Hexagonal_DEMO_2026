using Microsoft.AspNetCore.Mvc;

namespace HexagonalDemo.Api.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
