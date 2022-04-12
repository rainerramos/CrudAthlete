using CA.Domain;
using CA.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AthleteController : ControllerBase
    {
        private readonly IAthleteService _athleteService;

        public AthleteController(IAthleteService athleteService)
        {
            _athleteService = athleteService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
           IEnumerable<Athlete> athletes = _athleteService.GetAll();
            return Ok(athletes);
        }

        [HttpPost]
        public IActionResult Add(Athlete athlete)
        {
            bool cpfIsValid = _athleteService.IsCpf(athlete.CPF);

            if (cpfIsValid)
            {
                _athleteService.Add(athlete);
                return StatusCode(201);
            }
            
                ModelState.AddModelError("Cpf", "Cpf inválido");
                return BadRequest(ModelState);            
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _athleteService.Delete(id);
            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            Athlete athlete = _athleteService.GetById(id);
            return Ok(athlete);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, Athlete athlete)
        {
            _athleteService.Update(id, athlete);
            return NoContent();
        }
    }
}
