using apiBff.Dtos;
using apiBff.Interfaces;
using apiBff.Models;
using AutoMapper;

namespace apiBff.Services
{
    public class FrontAgendamentoService : IFrontAgendamentoService
    {
        private readonly ICadastroService _cadastroService;
        private readonly IOperacionalService _operacionalService;
        private readonly IMapper _mapper;

        public FrontAgendamentoService(ICadastroService cadastroService, IOperacionalService operacionalService, IMapper mapper)
        {
            _cadastroService = cadastroService;
            _operacionalService = operacionalService;
            _mapper = mapper;
        }
        public async Task<FrontAgendamentoPendentemModel> BuscarDadosViewAgendamento()
        {
            var frontAgendamento = new Models.FrontAgendamentoPendentemModel();
            
            var cadastroMotorista = await _cadastroService.BuscarCadastroMotorista();
            frontAgendamento =  _mapper.Map<FrontAgendamentoPendentemModel>(cadastroMotorista) ;

            var terminais = await _operacionalService.BuscarSituacaoOperacional();            
            frontAgendamento.SituacaoOperacionalTerminais = _mapper.Map<List<SituacaoOperacionalModel>>(terminais);          

            var agendamentos =  await _operacionalService.BuscarAgendamentos();
            frontAgendamento.Agendamentos = _mapper.Map<List<AgendamentoPendenteModel>>(agendamentos);           

            return frontAgendamento;
        }
    }
}