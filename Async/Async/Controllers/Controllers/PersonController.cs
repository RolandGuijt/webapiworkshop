using AFirstEndpoint;
using AFirstEndpoint.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Controllers.Controllers
{
    [ApiController]
    [Route("Persons")]
    public class PersonController : Controller
    {
        private readonly IPersonRepository _Repo;

        public PersonController(IPersonRepository repo)
        {
            _Repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetPersons()
        {
            return Ok(await _Repo.GetPersons());
        }

        [HttpGet("{personId}")]
        public async Task<IActionResult> GetPerson(int personId)
        {
            var person = await _Repo.GetPerson(personId);
            if (person == null)
            {
                return NotFound();
            }
            return Ok(person);
        }

        [HttpPost]
        [ProducesResponseType(201)]
        public async Task<IActionResult> PostPerson(PersonDto person)
        {
            var newPerson = await _Repo.AddPerson(person);
            return CreatedAtAction(nameof(GetPerson), new {personId = newPerson.Id}, newPerson);
        }
    }
}
