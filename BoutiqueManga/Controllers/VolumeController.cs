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
    public class VolumeController(IVolumeService service) : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Volume>))]
        public IActionResult GetAll()
        {
            IEnumerable<Volume> volumes;

            try
            {
                volumes = service.GetAll().Select(model => model.ToDTO());
                return Ok(volumes);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpGet("{isbn}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Volume))]
        public IActionResult GetByISBN(string isbn)
        {
            try
            {
                Volume result = service.GetByISBN(isbn).ToDTO();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            //TODO Add IsbnNotFoundException
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(Volume))]
        public IActionResult Create(VolumeInsertForm form)
        {
            try
            {
                Volume result = service.Create(form.ToModel()).ToDTO();
                return CreatedAtAction(nameof(GetByISBN), new { ISBN = result.ISBN }, result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Volume))]
        public IActionResult Update(VolumeInsertForm form)
        {
            try
            {
                Volume result = service.Update(form.ToModel()).ToDTO();
                return CreatedAtAction(nameof(GetByISBN), new { ISBN = result.ISBN }, result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpPatch]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Volume))]
        public IActionResult UpdateStockByISBN(string isbn, int stockToAdd)
        {
            try
            {
                Volume result = service.UpdateStockByISBN(isbn, stockToAdd).ToDTO();
                return CreatedAtAction(nameof(GetByISBN), new { ISBN = result.ISBN }, result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
