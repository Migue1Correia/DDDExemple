using Domain.Commands;
using Domain.NovaPasta;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controler
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculoController : ControllerBase
    {
        private readonly IVeiculosService _veiculosService;
        public VeiculoController(IVeiculosService veiculoService)
        {
            _veiculosService = veiculoService;
        }
        [HttpPost]
        [Route("CadastrarVeiculos")]
        public async Task <IActionResult> PostAsy([FromBody] VeiculoCommand command)

        {  
            return Ok(await _veiculosService.PostAsy(command));
        }

        [HttpGet]
        [Route("SimularAlugue")]
        public IActionResult GetAsync()
        {
            return Ok();
        }
        [HttpPost]
        [Route("Alugar")]
        public IActionResult PostAsync()
        {
            return Ok();
        }
    }
}
