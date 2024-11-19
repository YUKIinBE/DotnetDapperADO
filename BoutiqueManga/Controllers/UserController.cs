using BoutiqueManga.API.DTOInsertForm;
using BoutiqueManga.API.DTOs;
using BoutiqueManga.API.Mappers;
using BoutiqueManga.BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BoutiqueManga.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(IUserService service) : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<User>))]
        public IActionResult GetAll()
        {
            IEnumerable<User> users;

            try
            {
                users = service.GetAll().Select(model => model.ToDTO());
                return Ok(users);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(User))]
        public IActionResult GetById(int id)
        {
            try
            {
                User result = service.GetById(id).ToDTO();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            //TODO Add IdNotFoundException
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(User))]
        public IActionResult Create(UserInsertForm form)
        {
            try
            {
                User result = service.Create(form.ToModel(), form.Password).ToDTO();
                return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
