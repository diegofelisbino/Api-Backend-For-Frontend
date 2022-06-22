using Microsoft.AspNetCore.Mvc;
using apiOperacional.Models;
using Bogus;
using apiOperacional.Services;

namespace apiOperacional.Controllers;

[ApiController]
[Route("[controller]")]
public class AgendamentoController : ControllerBase
{
    [HttpGet]
    [Route("BuscarAgendamentos")]
    public IEnumerable<Agendamento> Get()
    {
        var lista = AgendamentoService.ListaDeAgendamentosFake();
        return lista;
    }

   
}
