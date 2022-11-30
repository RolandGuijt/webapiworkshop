using AFirstEndpoint;
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
        public IActionResult GetPersons()
        {
            return Ok(_Repo.GetPersons());
        }

        [HttpGet("{personId}")]
        public IActionResult GetPerson(int personId)
        {
            var person = _Repo.GetPerson(personId);
            if (person == null)
            {
                return NotFound();
            }
            return Ok(person);
        }
    }
}
