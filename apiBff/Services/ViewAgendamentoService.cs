using apiBff.Interfaces;
using apiBff.Models;

namespace apiBff.Services
{
    public class FrontAgendamentoService : IFrontAgendamentoService
    {
        private readonly ICadastroService _cadastroService;
        private readonly IOperacionalService _operacionalService;

        public FrontAgendamentoService(ICadastroService cadastroService, IOperacionalService operacionalService)
        {
            _cadastroService = cadastroService;
            _operacionalService = operacionalService;
        }
        public async Task<FrontAgendamentoPendente> BuscarDadosViewAgendamento()
        {
            var frontAgendamento = new Models.FrontAgendamentoPendente();
            frontAgendamento.Agendamentos = new List<AgendamentoPendente>();
            frontAgendamento.SituacaoOperacionalTerminais = new List<SituacaoOperacional>();

            var cadastroMotorista = await _cadastroService.BuscarCadastroMotorista();
            frontAgendamento.CadastroFotoMotorista = cadastroMotorista.Foto;
            frontAgendamento.CadastroNomeMotorista = cadastroMotorista.Nome;

            var terminais = await _operacionalService.BuscarSituacaoOperacional();            
            if (terminais.Count > 0)
            {
                foreach (var terminal in terminais)
                {          
                    Models.SituacaoOperacional situacao = new SituacaoOperacional();
                    situacao.SituacaoNomeTerminal = terminal.NomeTerminal;
                    situacao.SituacaoStatusOperacional = terminal.StatusOperacional;

                    frontAgendamento.SituacaoOperacionalTerminais.Add(situacao);
                }

            }

            var agendamentos = await _operacionalService.BuscarAgendamentos();

            if (agendamentos.Count > 0)
            {
                foreach (var agendamento in agendamentos)
                {
                    Models.AgendamentoPendente agendamentoPendente = new AgendamentoPendente();

                    agendamentoPendente.AgendamentoDataPlanejada = agendamento.DataEntrada;
                    agendamentoPendente.AgendamentoMotivacao = agendamento.Motivacao;
                    agendamentoPendente.AgendamentoPlacaCavalo = agendamento.PlacaCavalo;
                    agendamentoPendente.AgendamentoPlacaReboque = agendamento.PlacaReboque;

                    frontAgendamento.Agendamentos.Add(agendamentoPendente);
                }
            }

            return frontAgendamento;
        }
    }
}