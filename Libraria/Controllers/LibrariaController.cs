using Libraria.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Libraria.Mediator;
using Microsoft.AspNetCore.Authorization;
using Libraria.Entity.Entities;

namespace Libraria.Controllers
{
    [Route("api/libraria/v1")]
    [ApiController]
    public class LibrariaController : ControllerBase
    {
        private readonly ILibrariaMediator _mediator;

        public LibrariaController(ILibrariaMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        [Route("LeshoLiber")]
        // [Authorize(Roles = "Menaxher,Punonjese Sporteli")]
        public async Task<IActionResult> LeshoLiber(LeshoLiberDTO dTO)
        {
            try
            {
                var res = await _mediator.LeshoLiber(dTO);
                return Ok(res); 
            }
            catch(Exception ex)
            {
                return StatusCode(500, $" {ex.Message}");

            }
        }
        [HttpPost]
        [Route("Kerkese")]
        public async Task<IActionResult> BejKerkesePerLiber(KerkeseMarrjeLibriDTO dTO)
        {
            try
            {
                var res = await _mediator.BejKerkese(dTO);
                return Ok(res);

            }
            catch (Exception ex)
            {
                return StatusCode(500, $" {ex.Message}");
            }
            
        }
        [Route("MerrKerkesat")]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public List<KerkeseMarrjeLibri> MerrKerkesat()
        {
            return _mediator.MerrKerkesat();
        }

        [HttpPut]
        [Route("Aprovo")]
        public async Task<IActionResult> AprovoKerkese(string kerkeseId)
        {
            try
            {
                var res = await _mediator.AprovoKerkese(kerkeseId);
                return Ok(res);

            }
            catch (Exception ex)
            {
                return StatusCode(500, $" {ex.Message}");
            }

        }

        [HttpPost]
        [Route("LeshoLiberKerkese")]
        public async Task<IActionResult> LeshoLiberKerkese(string kerkeseId)
        {
            try
            {
                var res = await _mediator.LeshoLiberKerkese(kerkeseId);
                return Ok(res);

            }
            catch (Exception ex)
            {
                return StatusCode(500, $"{ex.Message}");
            }
        }


        [HttpPost]
        [Route("KtheLiber")]
        public async Task<IActionResult> KtheLiber(string marrjeLIbriID)
        {
            try
            {
                int res = 0 ;// await _mediator.AprovoKerkese(kerkeseId);
                return Ok(res);

            }
            catch (Exception ex)
            {
                return StatusCode(500, $" {ex.Message}");
            }
        }

    }
}
