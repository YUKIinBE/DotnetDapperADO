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
    public class MMUserVolumeController(IMMUserVolumeService service) : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<MMUserVolume>))]
        public IActionResult Get(int? userId, string? isbn)
        {
            IEnumerable<MMUserVolume> uvs;

            try
            {
                uvs = service.Get(userId, isbn).Select(model => model.ToDTO());
                return Ok(uvs);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(MMUserVolume))]
        public IActionResult GetById(int id)
        {
            try
            {
                MMUserVolume result = service.GetById(id).ToDTO();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            //TODO Add IdNotFoundException
        }
        [HttpGet("user/{userId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<MMUserVolume>))]
        public IActionResult GetByUserId(int userId)
        {
            IEnumerable<MMUserVolume> uvs;
            try
            {
                uvs = service.GetByUserId(userId).Select(model => model.ToDTO());
                return Ok(uvs);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            //TODO Add IdNotFoundException
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(MMUserVolume))]
        public IActionResult Create(MMUserVolumeInsertForm form)
        {
            try
            {
                MMUserVolume result = service.Create(form.ToModel()).ToDTO();
                return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
