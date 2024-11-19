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
    public class CollectionController(ICollectionService service) : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Collection>))]
        public IActionResult GetAll()
        {
            IEnumerable<Collection> collections;

            try
            {
                collections = service.GetAll().Select(model => model.ToDTO());
                return Ok(collections);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Collection))]
        public IActionResult GetById(int id)
        {
            try
            {
                Collection result = service.GetById(id).ToDTO();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            //TODO Add IdNotFoundException
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(Collection))]
        public IActionResult Create(CollectionInsertForm form)
        {
            try
            {
                Collection result = service.Create(form.ToModel()).ToDTO();
                return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
