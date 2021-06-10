using LBC.Beauty.Parlour.Management.Service.Authentication;
using LBC.Beauty.Parlour.Management.Service.Entity;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LBC.Beauty.Parlour.Management.Service.Controllers
{
    [ApiVersion("1.0")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    [Route("api/admin/")]
    public class MyTokenController : Controller
    {
        private readonly IJwtAuthenticationManager jwtAuthenticationManager;
        public MyTokenController(IJwtAuthenticationManager jwtAuthenticationManager)
        {
            this.jwtAuthenticationManager = jwtAuthenticationManager;
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] UserCred userCred)
        {
            var token = jwtAuthenticationManager.Authenticate(userCred.UserName, userCred.Password);
            if (token == null)
                return Unauthorized();
            return Ok(token);
        }
    }
}
