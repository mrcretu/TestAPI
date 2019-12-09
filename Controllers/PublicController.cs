using Microsoft.AspNetCore.Mvc;
using OMRO.Models.Input;
using OMRO.Models.Output;
using System;

namespace OMRO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublicController : ControllerBase
    {
        [HttpGet("Info")]
        public ActionResult<InfoOutputModel> Info(
            [FromHeader(Name = "X-Client-SessionId")] Guid sessionId)    
        {
            return Ok(new InfoOutputModel());
        }

        [HttpPost("startregistration")]
        public ActionResult<StartRegistrationOutputModel> StartRegistration(
            [FromHeader(Name = "X-Client-SessionId")] Guid sessionId,
            [FromBody] StartUserRegistrationModel startUserRegistrationModel)
        {
            return Ok(new StartRegistrationOutputModel());
        }

        [HttpPost("resendemailcode")]
        public IActionResult ResendEmailCode(
            [FromHeader(Name = "X-Client-SessionId")] Guid sessionId,
            [FromBody] ResendEmailCodeModel resendEmailCodeModel)
        {
            return Ok();
        }
    }
}
