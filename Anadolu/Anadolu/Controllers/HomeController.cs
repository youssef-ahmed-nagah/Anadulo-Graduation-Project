using Anadolu.DTO;
using Anadolu.Models;
using Anadolu.Repository;
using Anadolu.Repository.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Anadolu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        IUnitOfWork unitOfWork;


        public HomeController(IUnitOfWork _unitOfWork)
        {

            unitOfWork = _unitOfWork;


        }
        //[HttpGet("Products")]
        //public IActionResult GetAllProducts()
        //{
        //    ResultDTO result = new ResultDTO();

        //    var products = unitOfWork.ProductRepository.GetAllProducts(l => l.IsDeleted == false);

        //    List<ProuductHomeDTO> prouductHomeDTO = new List<ProuductHomeDTO>();

        //    foreach (var p in products)
        //    {
        //        ProuductHomeDTO protduct = new ProuductHomeDTO
        //        {
        //            ProductName = p.Name,

        //            ProductImage = p.ImagePath,

        //        };
        //        prouductHomeDTO.Add(protduct);

        //    }



        //    result.IsPassed = true;
        //    result.Data = prouductHomeDTO;
        //    return Ok(result);
        //}

        [HttpGet("Categories")]
        public IActionResult GetAllCategories()
        {
            ResultDTO result = new ResultDTO();

            var categories = unitOfWork.CategoryRepository.GetAll(l => l.IsDeleted == false);

            List<CategoryHomeDTO> categoryHomeDTO = new List<CategoryHomeDTO>();

            foreach (var c in categories)
            {
                CategoryHomeDTO Category = new CategoryHomeDTO
                {
                    CategoryName = c.Name,

                    CategoryImage = c.ImagePath,

                };
                categoryHomeDTO.Add(Category);

            }



            result.IsPassed = true;
            result.Data = categoryHomeDTO;
            return Ok(result);
        }

        [HttpGet("Discounts")]
        public IActionResult GetAllProductsInDiscount()
        {
            ResultDTO result = new ResultDTO();

            var products = unitOfWork.ProductRepository.GetAll(l => l.IsDeleted == false);
            List<Discount> discounts = unitOfWork.DiscountRepository.GetAll(l => false);
            for (int i = 0; i < products.Count; i++)
            {
                int id = products[i].Id;
                Discount discount = unitOfWork.DiscountRepository.GetById(id, d => false);
                discounts.Add(discount);
            }

            List<DiscountsInHome> discountsInHome = new List<DiscountsInHome>();
            for (int i = 0; i < products.Count; i++)
            {
                DiscountsInHome dis = new DiscountsInHome();
                if (discounts[i] != null)
                {
                    dis.ProductName = products[i].Name;
                    dis.DiscountValue = discounts[i].Value;
                    discountsInHome.Add(dis);
                }

            }




            result.IsPassed = true;
            result.Data = discountsInHome;
            return Ok(result);



        }
    }
}
