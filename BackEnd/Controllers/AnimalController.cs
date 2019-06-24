using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BackEnd.DAL.Enteties;
using BackEnd.ViewModel;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class AnimalController : ControllerBase
    {
        //static List<AnimalViewModel> data = new List<AnimalViewModel>
        //   {
        //       new AnimalViewModel {
        //           Id=4,
        //           Name="Верблуюд",
        //           Image="http://www.origins.org.ua/pictures/photo_verblud_3.jpg"
        //       },

        //       new AnimalViewModel {
        //           Id=7,
        //           Name="Білка",
        //           Image="https://ichef.bbci.co.uk/news/976/cpsprodpb/7624/production/_104444203_d03fb5eb-685c-42c3-8fa2-eea0ee2dac26.jpg"
        //       },
        //   };

        private readonly EFContext _context;
        public AnimalController(EFContext context)
        {
            _context = context;
        }

        // GET api/animal/search
        [HttpGet("search")]
        public IActionResult Get()
        {
            Thread.Sleep(3000);
            List<AnimalViewModel> model = _context.Animals
                  .Select(a => new AnimalViewModel
                  {
                      Id = a.Id,
                      Name = a.Name,
                      Image = a.Image
                  }).ToList();

            return Ok(model);
        }

        // POST api/animal/add
        [HttpPost("add")]
        public IActionResult Post( [FromBody] AnimalAddViewModel model)
        {
            //Random rand = new Random();
            _context.Animals.Add(new DbAnimal
            {               
                Name = model.Name,
                Image = model.Image
            });
            _context.SaveChanges();
            return Ok();
        }
    }

}
