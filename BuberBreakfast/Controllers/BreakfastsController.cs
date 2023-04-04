using BuberBreakfast.Contracts.Breakfast;
using BuberBreakfast.Models;

namespace BuberBreakfast.Controllers
{

    using Microsoft.AspNetCore.Mvc;

    [Route("api/breakfasts")]
    [ApiController]
    public class BreakfastsController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreateBreakfast(CreateBreakfastRequest request)
        {
            var breakfast = new Breakfast(
                Guid.NewGuid(),
                request.Name,
                request.Description,
                request.StartDateTime,
                request.EndDateTime,
                DateTime.UtcNow,
                request.Savory,
                request.Sweet
            );

            // Save to Database

            var response = new BreakfastResponse(
                breakfast.Id,
                breakfast.Name,
                breakfast.Description,
                breakfast.StartDateTime,
                breakfast.EndDateTime,
                breakfast.LastModifiedDateTime,
                breakfast.Savory,
                breakfast.Sweet
            );
            return CreatedAtAction(
                actionName: nameof(GetBreakfast),
                routeValues: new { id = breakfast.Id },
                value: response);
        }
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetBreakfast(Guid id)
        {
            return Ok(id);
        }
        [HttpPut("{id:guid}")]
        public async Task<IActionResult> UpsertBreakfast(Guid id, UpsertBreakfastRequest request)
        {
            return Ok(request);
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteBreakfast(Guid id)
        {
            return Ok(id);
        }
    }
}