using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAPIOng.Models;
using WebAPIOng.Services;

namespace WebAPIOng.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private readonly PetService _petService;
        public PetController(PetService petService)
        {
            _petService = petService;
        }

        [HttpGet]
        public ActionResult<List<Pet>> GetAll() => _petService.GetAll();

        [HttpGet("Nome/{n}", Name = "GetNome")]
        public ActionResult<Pet> GetByName(string n)
        {
            var dog = _petService.GetByName(n);
            if (dog == null) return NotFound();
            return Ok(dog);
        }

        [HttpPost]
        public ActionResult<Pet> AdicionaPet(Pet pet)
        {
            _petService.Create(pet);
            return CreatedAtRoute("GetNome", pet.Nome);
        }
        [HttpPut]
        public ActionResult<Pet> AtualizaPet(Pet pet)
        {
            var dog = _petService.GetByName(pet.Nome);
            if (dog == null) return NotFound();
            _petService.Update(pet);
            return NoContent();
        }
        [HttpDelete]
        public ActionResult<Pet> Delete (Pet pet)
        {
            var dog = _petService.GetByName(pet.Nome);
            if (dog == null) return NotFound();
            _petService.Remove(pet);
            return NoContent();
        }
    }
}
