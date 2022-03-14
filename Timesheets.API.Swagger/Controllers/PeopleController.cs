using Microsoft.AspNetCore.Mvc;
using Timesheets.BL.Models;
using Timesheets.DB;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Timesheets.API.Swagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly IPeople _people;

        public PeopleController(IPeople people)
        {
            _people = people;
        }

        // GET: api/<PeopleController>
        [HttpGet]
        public List<Person> Get()
        {
            return _people.GetPeople();
        }

        // GET api/<PeopleController>/5               // GET /persons/{id}  — получение человека по идентификатору
        [HttpGet("{id}")]
        public List<Person> Get(int id)
        {
            return _people.GetPerson(id);
        }


        //GET api/<PeopleController>/FirstName         // GET /persons/search?searchTerm={term} — поиск человека по имени
        [HttpGet("SearchPerson/{firstName}")]
        public List<Person> SearchPerson(string firstName)
        {
            return _people.SearchPerson(firstName);
        }


        //GET api/<PeopleController>/FirstName         // GET /persons/?skip={5}&take={10} — получение списка людей с пагинацией
        [HttpGet("PagePeople/")]
        public List<Person> PagePeople([FromQuery] int skip, [FromQuery] int take)
        {
            return _people.PagePeople(skip, take);
        }

        // POST api/<PeopleController>                 //  POST /persons — добавление новой персоны в коллекцию
        [HttpPost]
        public void Post([FromBody] Person person)
        {
             _people.AddPerson(person);
        }

        // PUT api/<PeopleController>/5
        [HttpPut]                              // PUT /persons — обновление существующей персоны в коллекции
        public void Put([FromBody] Person person)
        {
            _people.UpdatePerson(person);
        }

        // DELETE api/<PeopleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _people.DeletePerson(id);
        }
    }
}
