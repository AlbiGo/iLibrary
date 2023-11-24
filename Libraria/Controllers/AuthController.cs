using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Libraria.Mediator;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Libraria.Models.DTO;

namespace Libraria.Controllers
{
    [Route("api/auth/v1")]
    [ApiController]
    public class AuthController: ControllerBase
    {
        private readonly IAuthMediator _authMediator;

        public AuthController(IAuthMediator authMediator)
        {
            _authMediator = authMediator;
        }
        [Route("Register")]
       // [Authorize(Roles = "Menaxher")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public async Task<IActionResult> Register(RegisterUserDTO dTO)
        {
            try
            {
                var result = await _authMediator.Register(dTO);
                if (result.Succeeded)
                {
                    var res = new ResponseDTO()
                    {
                        KodiDaljes = 1,
                        Pershkrim = "User created Succsesfully."
                    };
                    return Ok(res);

                }
                else return BadRequest();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }

        [Route("LogIn")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public async Task<IActionResult> LogIn(string username , string passowrd)
        {
            try
            {
                var dto = new LoginRequestDTO()
                {
                    UserName = username,
                    Password = passowrd
                };
                var result = await _authMediator.LogIn(dto);
                if (result != null && result.KodiDaljes == 1)
                    return Ok(result);
                else
                    return Unauthorized(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }
    }
}
