using apiCadastro.Models;
using apiCadastro.Services;
using Microsoft.AspNetCore.Mvc;

namespace apiCadastro.Controllers;


[ApiController]
[Route("[controller]")]
public class CadastroController : ControllerBase
{

    [HttpGet]
    [Route("BuscarCadastroMotorista")]
    public Motorista Get()
    {        
        var lista =  CadastroServices.ListaDeMotoristasFake();
        Random rnd = new Random();
        var motorista = lista[rnd.Next(lista.Count)];
        return motorista;
    }

    
}


