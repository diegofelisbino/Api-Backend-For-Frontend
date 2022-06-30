using apiBff.Interfaces;
using apiBff.Models;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Http.StatusCodes;

namespace apiBff.Controllers;

[ApiController]
[Route("Bff")]
public class ViewAgendamentoController : MainController
{
    private readonly IFrontAgendamentoService _service;

    public ViewAgendamentoController(INotificador notificador, IFrontAgendamentoService service) : base(notificador)
    {
        _service = service;
    }

    [HttpGet("BuscarDadosFrontAgendamento")]    
    public async Task<ActionResult<FrontAgendamentoPendentemModel>> BuscarDadosViewAgendamento()
    {
        var frontAgendamento = await _service.BuscarDadosViewAgendamento();        

        if (frontAgendamento == null)
        {
            NotificarErro("Falha ao buscar dados");
            return CustomResponse();
        }

        if(!ModelState.IsValid) return CustomResponse(ModelState);

        return CustomResponse(frontAgendamento);
    }
}



