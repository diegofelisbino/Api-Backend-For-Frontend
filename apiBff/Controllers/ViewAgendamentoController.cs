using apiBff.Interfaces;
using apiBff.Models;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Http.StatusCodes;

namespace apiBff.Controllers;

[ApiController]
[Route("[controller]")]
public class ViewAgendamentoController : MainController
{
    private readonly IFrontAgendamentoService _service;    

    public ViewAgendamentoController(INotificador notificador,IFrontAgendamentoService service) : base(notificador)
    {
        _service = service;
    }

    [HttpGet]
    [Route("BuscarDadosFrontAgendamento")]
    public async Task<ActionResult<FrontAgendamentoPendentemModel>> BuscarDadosViewAgendamento()
    {
        var frontAgendamento = await _service.BuscarDadosViewAgendamento();        

        if (frontAgendamento == null)
        {
            NotificarErro("Falha ao buscar dados");
            return CustonResponse();
        }

        if(!ModelState.IsValid) return CustonResponse(ModelState);

        return CustonResponse(frontAgendamento);
    }
}



