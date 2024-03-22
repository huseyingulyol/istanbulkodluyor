using Business.Abstracts;
using Business.Concretes;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService productService; 

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public List<Product> GetAll()
        {
            return productService.GetAll();
        }

        [HttpGet("id")]
        public Product GetById([FromQuery] int id)
        {
            return productService.GetById(id);
        }

        [HttpPost("add")]
        public void Add([FromBody] Product product)
        {
            productService.Add(product);
        }

        [HttpPost("delete")]
        public void Delete([FromBody] int id)
        {
            productService.Delete(id);
        }

        [HttpPost("update")]
        public void Update([FromBody] Product product)
        {
            productService.Update(product);
        }

    }
}
