using ClothingShop.Application.Services;
using ClothingShop.Communication.Requests;
using ClothingShop.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace ClothingShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClothController : ControllerBase
    {
        private readonly ClothService _service;

        public ClothController(ClothService service)
        {
            _service = service;
        }

        [HttpPost]
        [ProducesResponseType(typeof(ResponseCloth), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Register([FromBody] RequestCloth request)
        {
            var response = await _service.Register(request);

            return Created(string.Empty, response);
        }

        [HttpGet]
        [ProducesResponseType(typeof(ResponseCloth), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> GetAll()
        {
            var response = await _service.GetAll();

            if (response.Clothes.Any())
            {
                return Ok(response);
            }

            return NoContent();
        }
    }
}
