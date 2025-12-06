using HexagonalDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexagonalDemo.Infrastructure.Data
{
    public static class FakeDb
    {
        public static List<Product> Products = new()
        {
            new Product { Id = 1, Name = "Laptop" },
            new Product { Id = 2, Name = "Teclado" }
        };
    }
}
