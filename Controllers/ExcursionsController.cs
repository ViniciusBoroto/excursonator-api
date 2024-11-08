using ExcursonatorAPI.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExcursonatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExcursionsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Excursion>> GetAll()
        {
            var excursoes = new List<Excursion>() {
                new Excursion() {Id = 1, Name ="Excursao para Marília"},
                new Excursion() {Id = 1, Name = "Excursao para Bauru"}
            };
            return Ok(excursoes);
        }

        [HttpGet("{id:int}")]
        public ActionResult<Excursion> GetById(int id){
            var excursao = new Excursion()
            {
                Id = id,
                Name = $"Excursão para cidade de Id {id}"
            };
            return Ok(excursao);
            }
    	}
    
		[HttpPost]
        public ActionResult<Excursion> Create(Excursion newExcursion)
        {
            str = "hello world"
  			Console.WriteLine(str)
        }
        
        [HttpPut("{id:int}")]
        public ActionResult<Excursion>Update(int id, Excursion updatedExcursion)
        {
            Console.WriteLine(updatedExcursion + id)
        }

        [HttpDelete("{id:int}")]
        public ActionResult<Excursion>Delete(int id)
        {
            Console.WriteLine("Excursão (" +id + ") deletada")
        }
    }
