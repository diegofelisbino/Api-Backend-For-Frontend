using apiBff.Dtos;
using apiBff.Interfaces;
using Refit;

namespace apiBff.Services
{
    public class OperacionalService : IOperacionalService
    {
        private readonly IOperacionalService _service;
        public OperacionalService()
        {
            _service = RestService.For<IOperacionalService>("https://localhost:7213");    
        }
        
       public Task<List<AgendamentoDto>> BuscarAgendamentos()
        {
            return _service.BuscarAgendamentos();            
        }

        public Task<List<TerminalDto>> BuscarSituacaoOperacional()
        {
            return _service.BuscarSituacaoOperacional();
        }
    }
}