using apiBff.Dtos;
using apiBff.Interfaces;
using Refit;

namespace apiBff.Services
{
    public class CadastroService : ICadastroService
    {
        private readonly ICadastroService _cadastroService;
       
       public CadastroService()
       {
            _cadastroService = RestService.For<ICadastroService>("http://localhost:5207");       
            
       }
        public Task<MotoristaDto> BuscarCadastroMotorista()
        {
            return _cadastroService.BuscarCadastroMotorista();            
        }
    }
}