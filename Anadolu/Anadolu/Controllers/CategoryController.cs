using Anadolu.DTO;

using Anadolu.Models;
using Anadolu.Repository;
using Anadolu.Repository.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace Anadolu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IUnitOfWork unit;
        private readonly IHostingEnvironment host;
        public CategoryController(IUnitOfWork _unit, IHostingEnvironment _host)
        {
            unit = _unit;
            host = _host;
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory([FromForm] CategoryDTO catDTO)
        {
            ResultDTO result = new ResultDTO();
            if (ModelState.IsValid)
            {
                Category category = new Category();
                category.Name = catDTO.Name;

                UploaderImage up=new UploaderImage(host);
                string fileName = await up.Uploade(catDTO.File);

                category.ImagePath = "http://localhost:5194/images/" + fileName;
                unit.CategoryRepository.Add(category);

                result.Data = catDTO;
                result.IsPassed= true;
                return Ok(result);
            }

            result.IsPassed = false;
            result.Data = "ModelState Is Invalid";
            return BadRequest(result);
        }
    }
}
