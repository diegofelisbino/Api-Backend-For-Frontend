using apiBff.Interfaces;
using Microsoft.AspNetCore.Mvc;

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
    public async Task<Models.FrontAgendamentoPendente> BuscarDadosViewAgendamento()
    {
        return await _service.BuscarDadosViewAgendamento();
    }
}

