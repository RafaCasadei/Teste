using AutoMapper;
using Examples.Charge.Application.Interfaces;
using Examples.Charge.Application.Messages.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Charge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneController : ControllerBase
    {
        private readonly IPhoneFacade _facade;
        private readonly IMapper _mapper;

        public PhoneController(IPhoneFacade facade, IMapper mapper)
        {
            _facade = facade;
            _mapper = mapper;
        }

        [HttpPut]
        public async Task<IActionResult> Alterar([FromQuery]int id,[FromBody]PersonPhoneInputRequest request)
        {
            if (request == null)
                return BadRequest();

            await _facade.Alterar(id, request);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Salvar([FromBody] PersonPhoneInputRequest request)
        {
            if (request == null)
                return BadRequest();

            await _facade.Salvar(request);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Deletar([FromQuery] int id)
        {
            if (id == 0)
                return BadRequest();

            await _facade.Remover(id);
            return Ok();
        }
    }
}
