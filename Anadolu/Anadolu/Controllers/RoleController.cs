using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Anadolu.DTO;

namespace Anadolu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly RoleManager<IdentityRole> roleManager;


        public RoleController(RoleManager<IdentityRole> RoleManager)
        {
            roleManager = RoleManager;
        }
        

        [HttpPost]
        public async Task<IActionResult> New(RoleDto roleDto)
        {
            ResultDTO resultDTO = new ResultDTO();
            if (ModelState.IsValid)
            {
                IdentityRole roleModel = new IdentityRole();
                roleModel.Name = roleDto.RoleName;
                IdentityResult result = await roleManager.CreateAsync(roleModel);
                if (result.Succeeded)
                {
                    resultDTO.IsPassed = true;
                    resultDTO.Data="Created Success";
                    return Ok(resultDTO);
                }
                else
                {
                    resultDTO.IsPassed = false;
                    ModelState.AddModelError("", result.Errors.FirstOrDefault().Description);
                }

            }
            resultDTO.Data = ModelState;
            return BadRequest(resultDTO);
        }
    }
}
