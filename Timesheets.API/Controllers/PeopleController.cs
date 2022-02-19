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


    }
}
