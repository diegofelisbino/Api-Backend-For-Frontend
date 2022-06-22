using Microsoft.AspNetCore.Mvc;
using apiOperacional.Models;
using Bogus;
using apiOperacional.Services;

namespace apiOperacional.Controllers;

[ApiController]
[Route("[controller]")]
public class TerminalController : ControllerBase
{
    [HttpGet]
    [Route("BuscarSituacaoOperacional")]
    public IEnumerable<Terminal> Get()
    {
        var lista = TerminalService.ListaDeTerminaisFake();
        return lista;
    }
}
