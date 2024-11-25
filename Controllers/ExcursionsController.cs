using ExcursonatorAPI.Data.Repositories;
using ExcursonatorAPI.Models.DTOs;
using ExcursonatorAPI.Models.Entities;
using ExcursonatorAPI.Models.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExcursonatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExcursionsController : ControllerBase
    {
        private readonly IExcursionsRepository _excursionsRepository;

        public ExcursionsController(IExcursionsRepository excursionsRepository)
        {
            this._excursionsRepository = excursionsRepository;
        }
        [HttpGet]
        public ActionResult<List<Excursion>> GetAll()
        {
            return Ok(_excursionsRepository.GetAll());
            //var excursoes = new List<Excursion>() {
            //    new Excursion() {Id = 1, Name ="Excursao para Marília", Local="Marilia"},
            //    new Excursion() {Id = 1, Name = "Excursao para Bauru", Local="Bauru"}
            //};
            //return Ok(excursoes);
        }

        [HttpGet("{id:int}")]
        public ActionResult<Excursion> GetById(int id)
        {
            var excursao = _excursionsRepository.GetById(id);
            if (excursao is null) return NotFound();

            return Ok(excursao);
        }
        [HttpPost]
        public ActionResult<Excursion> Create(ExcursionDTO newExcursion)
        {
            var success = _excursionsRepository.Create(newExcursion);
            if (success) return Ok(newExcursion);
            else throw new Exception("Erro ao criar uma excursao");
        }

        [HttpPut("{id:int}")]
        public ActionResult<Excursion> Update(int id, ExcursionDTO updatedExcursion)
        {
            var success = _excursionsRepository.Update(id, updatedExcursion);
            if (success) return Ok(updatedExcursion);
            return StatusCode(StatusCodes.Status500InternalServerError, $"Ocorreu um erro ao atualizar a excursão de id \'{id}\'");
        }

        [HttpDelete("{id:int}")]
        public ActionResult<Excursion> Delete(int id)
        {
            var success = _excursionsRepository.Delete(id);
            if (success) return Ok();
            return BadRequest();

        }
    }
}
