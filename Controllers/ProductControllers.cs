using Microsoft.AspNetCore.Mvc;
using DotNetProductAPI.Data;
using DotNetProductAPI.Models;
using Microsoft.Extensions.Logging;  // Add this import for logging
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DotNetProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ILogger<ProductController> _logger;  // Declare logger

        // Inject logger into the constructor
        public ProductController(AppDbContext context, ILogger<ProductController> logger)
        {
            _context = context;
            _logger = logger;  // Initialize logger
        }

        // GET: api/product
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            _logger.LogInformation("GET request to /api/product received.");
            var products = _context.Products.ToList();
            if (!products.Any())
            {
                _logger.LogWarning("No products found.");
            }
            return products;
        }

        // GET: api/product/{id}
        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            _logger.LogInformation($"GET request to /api/product/{id} received.");
            var product = _context.Products.Find(id);
            if (product == null)
            {
                _logger.LogWarning($"Product with ID {id} not found.");
                return NotFound();
            }
            return product;
        }

        // POST: api/product
        [HttpPost]
        public ActionResult<Product> CreateProduct(Product product)
        {
            _logger.LogInformation("POST request to /api/product received.");
            _context.Products.Add(product);
            _context.SaveChanges();
            _logger.LogInformation($"Product with ID {product.Id} created.");
            return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
        }

        // PUT: api/product/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, Product product)
        {
            _logger.LogInformation($"PUT request to /api/product/{id} received.");
            if (id != product.Id)
            {
                _logger.LogWarning("Product ID mismatch.");
                return BadRequest();
            }
            _context.Entry(product).State = EntityState.Modified;
            _context.SaveChanges();
            _logger.LogInformation($"Product with ID {id} updated.");
            return NoContent();
        }

        // DELETE: api/product/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            _logger.LogInformation($"DELETE request to /api/product/{id} received.");
            var product = _context.Products.Find(id);
            if (product == null)
            {
                _logger.LogWarning($"Product with ID {id} not found.");
                return NotFound();
            }
            _context.Products.Remove(product);
            _context.SaveChanges();
            _logger.LogInformation($"Product with ID {id} deleted.");
            return NoContent();
        }
    }
}
