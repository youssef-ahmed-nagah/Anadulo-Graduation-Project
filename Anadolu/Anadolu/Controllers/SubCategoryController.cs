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
    public class SubCategoryController : ControllerBase
    {
        private readonly IUnitOfWork unit;
        private readonly IHostingEnvironment host;
        public SubCategoryController(IUnitOfWork _unit, IHostingEnvironment _host)
        {
            unit = _unit;
            host = _host;
        }

        public async Task<IActionResult> AddSubCategory([FromForm] CategoryDTO subCatDTO)
        {
            ResultDTO result = new ResultDTO();
            if (ModelState.IsValid)
            {
                SubCategory subCategory = new SubCategory();
                subCategory.Name = subCatDTO.Name;

                UploaderImage up = new UploaderImage(host);
                string fileName = await up.Uploade(subCatDTO.File);

                subCategory.ImagePath = "http://localhost:5292/images/" + fileName;
                unit.SubCategoryRepository.Add(subCategory);

                result.Data = subCatDTO;
                result.IsPassed = true;
                return Ok(result);
            }

            result.IsPassed = false;
            result.Data = "ModelState Is Invalid";
            return BadRequest(result);
        }
    }
}
