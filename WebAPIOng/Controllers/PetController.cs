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
        public ActionResult<Pet> AdicionaDog(Pet pet)
        {
            _petService.Create(pet);
            return CreatedAtRoute("BuscaNome", pet.Nome);
        }
    }
}
