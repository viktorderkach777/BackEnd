using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd.ViewModel;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        // GET api/animal/search
        [HttpGet("search")]
        public IActionResult Get()
        {
            List<ProductViewModel> model = new List<ProductViewModel>
           {
               new ProductViewModel {
                   Id=5,
                   Name="Oil",
                   Image="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQpyjEtnmv0ZnE73ZenuLFpL49qwwxDS2ViplFoL_w2Da-mxMoNNA"
               },
               new ProductViewModel {
                   Id=6,
                   Name="Paint",
                   Image="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRyh2nVg2XXewCOG4G1vJQVe_YoLbcVSM8F-VNS0sS0mF8x5KYnQw"
               },
           };
            return Ok(model);
        }
    }

}
