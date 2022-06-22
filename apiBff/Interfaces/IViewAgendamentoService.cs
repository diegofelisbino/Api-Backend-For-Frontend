using apiBff.Models;

namespace apiBff.Interfaces
{
    public interface IFrontAgendamentoService
    {
        Task<FrontAgendamentoPendente> BuscarDadosViewAgendamento();
    }
}