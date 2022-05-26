using Microsoft.AspNetCore.Mvc;
using Timesheets.API.EF.PostgreSQL.Models;
using Timesheets.API.EF.PostgreSQL.Repository;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Timesheets.API.EF.PostgreSQL.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserRepository _userRepository;


        public UserController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // GET: api/<UserController>
        [HttpGet]
        public async Task<ActionResult<User>> Get()
        {
            var res=await _userRepository.Get();
            return Ok(res);
        }

        //// GET api/<UserController>/5               //
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<UserController>
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] User userNew)
        {
            await _userRepository.Add(userNew);

            return NoContent();
        }

        //// PUT api/<UserController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] User user)
        {
            await _userRepository.Update(user);

            return NoContent();
        }




        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _userRepository.Delete(id);
            return NoContent();
        }
    }
}
