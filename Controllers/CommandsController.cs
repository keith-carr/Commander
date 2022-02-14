
using System.Collections.Generic;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase // ControllerBase not Controller, Controlerbase is the least amount of code(a security plus)
    {
        public ActionResult<IEnumerable<Command>> GetAllCommands() {

        }
    }
}


