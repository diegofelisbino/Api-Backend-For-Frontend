using apiBff.Dtos;
using Refit;

namespace apiBff.Interfaces
{
    public interface IOperacionalService
    {
        [Get("/Agendamento/BuscarAgendamentos")]
        Task<List<AgendamentoDto>> BuscarAgendamentos();

        [Get("/Terminal/BuscarSituacaoOperacional")]
        Task<List<TerminalDto>> BuscarSituacaoOperacional();
    }

}