﻿using Domain.Commands;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controler
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculoController : ControllerBase
    {
        [HttpPost("CadastrarVeiculos")]
        public IActionResult PostAsy([FromBody] VeiculoCommand command)
        {
            return Ok();

        }
        public IActionResult SimularAluguel()
        {
            return Ok();
        }

        public IActionResult Alugar()
        {
            return Ok();
        }
    }
}
