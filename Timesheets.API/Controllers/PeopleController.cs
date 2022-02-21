using Microsoft.AspNetCore.Mvc;
using Timesheets.BL.Models;
using Timesheets.DB;

namespace Timesheets.API.Controllers
{
    public class PeopleController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPeople _people;

        public PeopleController(ILogger<HomeController> logger, IPeople people)
        {
            _logger = logger;
            _people = people;
        }

        public IActionResult People()
        {
            return View();
        }

        [HttpGet]
        public List<Person> Get()
        {
            return _people.GetPeople(); 
        }

        [HttpGet("{id}")]
        public List<Person> GetPerson2(int id)
        {
            return _people.GetPerson(id);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPerson(int id)
        {
            return View( _people.GetPerson(id));
        }
    }
}
