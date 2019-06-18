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
    public class AnimalController : ControllerBase
    {
        static List<AnimalViewModel> data = new List<AnimalViewModel>
           {
               new AnimalViewModel {
                   Id=4,
                   Name="Верблуюд",
                   Image="http://www.origins.org.ua/pictures/photo_verblud_3.jpg"
               },
               new AnimalViewModel {
                   Id=7,
                   Name="Білка",
                   Image="https://ichef.bbci.co.uk/news/976/cpsprodpb/7624/production/_104444203_d03fb5eb-685c-42c3-8fa2-eea0ee2dac26.jpg"
               },
           };

        // GET api/animal/search
        [HttpGet("search")]
        public IActionResult Get()
        {
           
            return Ok(data);
        }

        // POST api/animal/add
        [HttpPost("add")]
        public IActionResult Post( [FromBody] AnimalAddViewModel model)
        {
            Random rand = new Random();
            data.Add(new AnimalViewModel
            {
                Id = rand.Next(10, 342123),
                Name = model.Name,
                Image = model.Image
            });
            return Ok();
        }
    }

}
