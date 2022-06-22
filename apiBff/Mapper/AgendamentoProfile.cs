using apiBff.Dtos;
using apiBff.Models;
using AutoMapper;

namespace apiBff.Mappper
{
    public class AgendamentoProfile : Profile
    {
        public AgendamentoProfile()
        {
            CreateMap<AgendamentoDto, AgendamentoPendenteModel>()
                .ForMember(f => f.AgendamentoDataPlanejada, map => map.MapFrom(ap => ap.DataEntrada))
                .ForMember(f => f.AgendamentoMotivacao, map => map.MapFrom(ap => ap.Motivacao))
                .ForMember(f => f.AgendamentoPlacaCavalo, map => map.MapFrom(ap => ap.PlacaCavalo))
                .ForMember(f => f.AgendamentoPlacaReboque, map => map.MapFrom(ap => ap.PlacaReboque));
        }
    }

    public class MotoristaProfile : Profile
    {
        public MotoristaProfile()
        {
            CreateMap<MotoristaDto, FrontAgendamentoPendentemModel>()
                .ForMember(f => f.CadastroFotoMotorista, map => map.MapFrom(m => m.Foto))
                .ForMember(f => f.CadastroNomeMotorista, map => map.MapFrom(m => m.Nome));
        }
    }

    public class TerminalProfile : Profile
    {
        public TerminalProfile()
        {
            CreateMap<TerminalDto, SituacaoOperacionalModel>()
            .ForMember(s => s.SituacaoNomeTerminal, map => map.MapFrom(t => t.NomeTerminal))
            .ForMember(s => s.SituacaoStatusOperacional, map => map.MapFrom(t => t.StatusOperacional));
        }

    }
}