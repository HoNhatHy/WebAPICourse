using Microsoft.AspNetCore.Mvc;
using PlatformDemo.Models;

namespace PlatformDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectsController:ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("There are all the projects");
        }

        [HttpGet("{id}")]
        public IActionResult GetProject(int id)
        {
            return Ok("This is one seperate project with id: " + id);
        }

        [HttpGet]
        [Route("/api/projects/{pid}/tickets")]
        public IActionResult GetProjectTicket(int pid, [FromQuery] int tid)
        {
            return Ok($"Reading project {pid}, ticket {tid}");
        }

        //[HttpGet]
        //[Route("/api/projects/{pid}/tickets")]
        //public IActionResult GetProjectTicket(Ticket ticket)
        //{
        //    if (ticket == null) return BadRequest("Parameters are not provided properly");
        //    if (ticket.TicketId == 0)
        //    {
        //        return Ok($"Reading all the tickets belong to project #{ticket.ProjectId}");
        //    }
        //    else return Ok($"Reading project #{ticket.ProjectId}, ticket #{ticket.TicketId}, title: {ticket.Title}, description: {ticket.Description}");
        //}

        [HttpPost]
        public IActionResult Post()
        {
            return Ok("Create a new project");
        }

        [HttpPatch()]
        public IActionResult Patch()
        {
            return Ok("Updating a project");
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok("Delete a project");
        }
    }
}
