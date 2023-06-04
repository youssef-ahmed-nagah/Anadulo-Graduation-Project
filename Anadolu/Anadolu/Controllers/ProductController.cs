using Anadolu.DTO;
using Anadolu.Models;
using Anadolu.Repository.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace Anadolu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IUnitOfWork unit;
        private readonly IHostingEnvironment host;
        public ProductController(IUnitOfWork _unit, IHostingEnvironment _host)
        {
            unit = _unit;
            host = _host;
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(ProductDTO productDTO)
        {
            ResultDTO result = new ResultDTO();
            if (ModelState.IsValid)
            {
                Product product = new Product(); 
                product.Name = productDTO.Name;
                product.Description = productDTO.Description;
                product.Quantity = productDTO.Quantity;
                product.Price = productDTO.Price;

                UploaderImage up = new UploaderImage(host);
                string fileName = await up.Uploade(productDTO.File);

                product.ImagePath = "http://localhost:5194/images/" + fileName;
                unit.ProductRepository.Add(product);

                result.Data = productDTO;
                result.IsPassed = true;
                return Ok(result);
            }

            result.IsPassed = false;
            result.Data = "ModelState Is Invalid";
            return BadRequest(result);
        }
    }
}
