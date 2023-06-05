using Anadolu.DTO;
using Anadolu.Models;
using Anadolu.Repository.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Anadolu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SingleProductController : ControllerBase
    {
        IUnitOfWork unitOfWork;


        public SingleProductController(IUnitOfWork _unitOfWork)
        {

            unitOfWork = _unitOfWork;


        }

        [HttpGet("product/{id}")]
        public IActionResult GetProductByID(int id)
        {
            ResultDTO result = new ResultDTO();

            var Product = unitOfWork.ProductRepository.GetProductById(id, l => l.IsDeleted == false);
            string productName = Product.Name;
            float productPrice = Product.Price;
            string productImage = Product.ImagePath;

            if (ModelState.IsValid)
            {

                SingleProductDTO singleProductDTO = new SingleProductDTO();
                singleProductDTO.ProductName = productName;
                singleProductDTO.ProductPrice = productPrice;
                singleProductDTO.ProductImage = productImage;

                if (Product != null)
                {

                    result.IsPassed = true;
                    result.Data = singleProductDTO;
                    return Ok(result);
                }
            }
            result.IsPassed = false;
            result.Data = "No user Exist With this Id";
            return BadRequest(result);
        }

        [HttpPost]
        public ActionResult<ResultDTO> AddToCart(AddToCartDTO AddToCartDTO)
        {
            ResultDTO result = new ResultDTO();
            ProductCart productcart = new ProductCart();

            if (ModelState.IsValid)
            {
                productcart.ProductId = AddToCartDTO.ProductId;

                productcart.CartId = AddToCartDTO.UserId;
                productcart.Quantity = AddToCartDTO.Quantity;



                unitOfWork.ProductCartRepository.Add(productcart);



                result.IsPassed = true;
                result.Data = productcart;
                return Ok(result);
            }
            result.IsPassed = false;
            result.Data = "ModelState Is Invalid";
            return BadRequest(result);
        }
    }
}
