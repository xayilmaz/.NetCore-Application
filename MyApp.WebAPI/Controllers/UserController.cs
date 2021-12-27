using Microsoft.AspNetCore.Mvc;
using MyApp.Business.Repositories.UserRepository;
using MyApp.Business.Requests.User;
using MyApp.Data;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        // GET: api/<UserController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await _userRepository.GetUser();
            if (response == null)
            {
                return NotFound("Bulunamadı");
            }
            return Ok(response);
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await _userRepository.GetUserById(id);
            if (response == null)
            {
                return NotFound("Bulunamadı");
            }
            return Ok(response);
        }

        [HttpGet("UserwithDepartmentAndRole/{id}")]
        public async Task<IActionResult> GetByIdDepartment(int id)
        {
            var response = await _userRepository.GetUserByIdWithDepartment(id);
            if (response == null)
            {
                return NotFound("Bulunamadı");
            }
            return Ok(response);
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<IActionResult> Post(PostUserRequest postUserRequest)
        {

            var response = await _userRepository.PostUser(postUserRequest);
            if (response == null)
            {
                return NotFound("Hata oluştu");
            }
            return Created(response.Id.ToString(), response);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
