using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WeaverPersonalAssistantBot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoRiaBotController : ControllerBase
    {
        [HttpGet]
        public IActionResult Webhook()
        {
            return Ok("Hello");
        }
    }
}
