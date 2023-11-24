using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Libraria.Mediator;
using Microsoft.AspNetCore.Authorization;
using Libraria.Models.DTO;
using Libraria.Entity.Entities;

namespace Libraria.Controllers
{
    [Route("api/lexues/v1")]
    [ApiController]
    public class LexuesController : ControllerBase
    {
        private readonly ILibrariaMediator _librariaMediator;
        
        public LexuesController(ILibrariaMediator ibrariaMediator)
        {
            _librariaMediator = ibrariaMediator;
        }
        [HttpPost]
        [Route("ShtoLexues")]
       // [Authorize(Roles = "Menaxher,Punonjese Sporteli")]
        public async Task<IActionResult> ShtoLexues(ShtoLexuesDTO dto)
        {
            try
            {
                var res = await this._librariaMediator.ShtoLexues(dto);
                return Ok(res);


            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
        [HttpGet]
        [Route("MerrLexuesit")]
        [Authorize]
        public List<Lexues> MerrLexuesit()
        {
            var lexuesit = this._librariaMediator.MerrLexuesit();
            return lexuesit;
        }

        [HttpGet]
        [Route("GjejLexues")]
        [Authorize]
        public Lexues GjejLexues(string id)
        {
            var lexuesit = this._librariaMediator.GjejLexues(id);
            return lexuesit;
        }

    }
}
