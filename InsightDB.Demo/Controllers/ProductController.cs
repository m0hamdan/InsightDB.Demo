using AutoMapper;
using InsightDB.Demo.Data;
using InsightDB.Demo.Models;
using InsightDB.Demo.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InsightDB.Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;


        public ProductController(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;   
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Product))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _productRepository.GetProduct(id);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);

        }
        [HttpGet("paged")]
        public async Task<PageableObject<Product>> GetPaged(int startIndex, int pageSize)
        {
            var result = await  _productRepository.GetProductsPaged(startIndex, pageSize);
            return _mapper.Map<PageableObject<Product>>(result);
        }
        [HttpGet("top")]
        public Task<IList<CategoryTopProducts>> GetTopProducts()
        {
            return _productRepository.GetCategoriesIncludeTopProducts();
        }
        [HttpGet("categories")]
        public Task<IList<ProductCategory>> GetCategories()
        {
            return _productRepository.GetProductsCategories();
        }

        [HttpGet("")]
        public Task<IList<Product>> GetProducts()
        {
            return _productRepository.GetProducts();
        }
    }
}
