using Microsoft.AspNetCore.Mvc;
using PlatformDemo.Filters;
using PlatformDemo.Models;

namespace PlatformDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Get all the needed tickets");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok($"Reading ticket {id}");
        }
        [HttpPost]
        [Ticket_EnsureEnteredDate]
        public IActionResult Post([FromBody] Ticket ticket)
        {
            return Ok(ticket);
        }
        [HttpPut]
        public IActionResult Put()
        {
            return Ok("Updating a ticket");
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok("Deleting a ticket");
        }
    }
}
