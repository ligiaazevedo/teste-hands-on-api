using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Teste.HandsOn.API.Domain;
using Teste.HandsOn.Infra.Context;

namespace Teste.HandsOn.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> products = new List<Product>();

        [HttpGet]
        public async Task<ActionResult<Product>> GetProductByIdAsync(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            var context = new HandsOnContext();
            if (product == null)
            {
                return BadRequest("Product not found.");
            }
            return Ok(product);
        }

        [HttpPut]
        public async Task<ActionResult<List<Product>>> PutProductCreateOrUpdate(Product request)
        {
            var product = products.Find(p => p.Id == request.Id);
            if (product == null)
            {
                return BadRequest("Product not found.");
            }

            product.Name = request.Name;
            product.Price = request.Price;
            return Ok(product);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Product>> DeleteProduct(int id)
        {
            var product = products.Find(p => p.Id == id);
            if (product == null)
                return BadRequest("Product not found.");

            products.Remove(product);
            return Ok(product);
        }

    }

}

