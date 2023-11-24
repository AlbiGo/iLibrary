using Libraria.Entity.Entities;
using Libraria.Mediator;
using Libraria.Models.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Libraria.Controllers
{
    [Route("api/liber/v1")]
    [ApiController]
    public class LIberController : ControllerBase
    {
        private readonly ILiberMediator _mediator ;
        public LIberController(ILiberMediator mediator)
        {
            _mediator = mediator;
        }
        [Route("ShtoLiber")]
        [Authorize(Roles = "Menaxher,Punonjese Sporteli")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public async Task<IActionResult> ShtoLiber(Liber liber)
        {
            try
            {
                var res = await _mediator.ShtoLiber(liber);
                return Ok(res);

            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [Route("MerLibrat")]
        //[Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public List<LiberDTO> MerrLibrat()
        {
            var res = this._mediator.MerrLibrat();
            var librat = res.Select(p => new LiberDTO()
            {
                Autori = p.Autori,
                DataRegj = p.DataRegj,
                ID = p.ID,
                Pershkrimi = p.Pershkrimi,
                Titulli = p.Titulli
            }).ToList();
            return librat;
        }
        [Route("MerLibratELire")]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public List<Liber> MerrLibratELire()
        {
            var res = this._mediator.MerrLibratELire();
            return res;
        }
    }
}
