using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonProject.Model;
using PersonProject.Services;

namespace PersonProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }
        [HttpGet("persons")]
        public ActionResult GetPersons()
        {
            var persons = _personService.GetPerson();
            return Ok(persons);
        }

        [HttpGet("person/:id")]
        public ActionResult GetPersonId(int id)
        {
            var person = _personService.GetPersonById(id);
            if(person == null) return NotFound();
            return Ok(person);
        }

        [HttpPost("person")]
        public ActionResult InsertPerson(PersonModel pesrson)
        {
            var newPerson = new PersonModel { Age = pesrson.Age, DateOfBirth = pesrson.DateOfBirth, Name = pesrson.Name};
            return Ok(newPerson);
        }
    }
}
