namespace BuberBreakfast.Controllers;
using Microsoft.AspNetCore.Mvc;

public class ErrorsController : ControllerBase {
    [Route("api/error")]
    public IActionResult Error()
    {
        return Problem();
    }
}