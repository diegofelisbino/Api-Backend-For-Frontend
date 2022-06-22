using apiBff.Interfaces;
using apiBff.Models;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Http.StatusCodes;

namespace apiBff.Controllers;

[ApiController]
[Route("[controller]")]
public class ViewAgendamentoController : ControllerBase
{
    private readonly IFrontAgendamentoService _service;

    public ViewAgendamentoController(IFrontAgendamentoService service)
    {
        _service = service;
    }

    [HttpGet]
    [Route("BuscarDadosFrontAgendamento")]
    public async Task<ActionResult<FrontAgendamentoPendentemModel>> BuscarDadosViewAgendamento()
    {
        var frontAgendamento = await _service.BuscarDadosViewAgendamento();        
        
        if (frontAgendamento == null) return BadRequest("Falha ao buscar dados");

        return Ok(frontAgendamento);

        
    }
}

